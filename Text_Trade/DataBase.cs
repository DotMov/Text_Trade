﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Eric ToDo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

public class DataBase
{

    private const string CONNSTRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Database\\TTDB.mdf;Integrated Security=True;Connect Timeout=30";

    public virtual Marketplace Marketplace
    {
        get;
        set;
    }

    public virtual WatchList WatchList
    {
        get;
        set;
    }

    public virtual SellList SellList
    {
        get;
        set;
    }

    public virtual TraderList UserList
    {
        get;
        set;
    }

    public virtual ListingList ListingList
    {
        get;
        set;
    }

    public string ConnString
	{
		get { return CONNSTRING; }
	}

	public virtual void Insert(string tableName, string fieldName, int pKey)
	{

        using (SqlConnection conn = new SqlConnection())
        {

            conn.ConnectionString = DataBase.CONNSTRING;
            conn.Open();

            string sql;
            sql = "INSERT FROM [" + tableName + "] WHERE [" + fieldName + "] = @id";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", pKey);

            command.ExecuteNonQuery();

        }

	}

	public virtual void Delete(string tableName, string fieldName, int pKey)
	{

        using (SqlConnection conn = new SqlConnection())
        {

            conn.ConnectionString = DataBase.CONNSTRING;
            conn.Open();

            String sql;
            sql = "UPDATE [" + tableName + "] SET deleted = 1 WHERE [" + fieldName + "] = @id";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", pKey);

            command.ExecuteNonQuery();

        }

    }


    public List<Listing> SearchForListing(string fieldname = null, string field = null,string fieldname2 = null, string field2 = null)
    {

        List<Listing> listings = new List<Listing>();

        using (SqlConnection conn = new SqlConnection(CONNSTRING))
        {

            conn.Open();

            string sql;

            if (fieldname == null && field == null)
            {

                sql = "SELCT * FROM (Listings)";

            }

            else if (fieldname == null || field == null)
            {

                throw new ArgumentException("make sure fields are set");

            }

            else if (fieldname2 != null && field2 != null)
            {

                sql = "SELCT * FROM (Listings) WHERE @fieldname = @field and @fieldname2 = @field2";

            }

            else
            {

                sql = "SELCT * FROM (Listings) WHERE @fieldname = @field"; 

            }

            using (SqlCommand command = new SqlCommand(sql, conn))
            {

                command.Parameters.AddWithValue("fieldname", fieldname);
                command.Parameters.AddWithValue("field", field);

                if (fieldname2 != null && field2 != null)
                {

                    command.Parameters.AddWithValue("fieldname2", fieldname2);
                    command.Parameters.AddWithValue("field2", field2);

                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Listing templisting = new Listing();

                    templisting.Listing_id = reader.GetInt32(0);
                    templisting.Title = reader.GetString(1);
                    templisting.Author = reader.GetString(2);
                    templisting.Edition = reader.GetString(3);
                    templisting.Isbn = reader.GetString(4);
                    string CCode = reader.GetString(5);
                    string CLevel = reader.GetString(6);
                    templisting._Course = new Course(CCode, CLevel);
                    templisting.LastUsed = reader.GetString(7);
                    Condition conditionstring = (Condition)Enum.Parse(typeof(Condition), reader.GetString(8));
                    templisting.Condition = conditionstring;
                    templisting.Description = reader.GetString(9);
                    templisting.Deleted = reader.GetInt32(10);
                    templisting.Price = reader.GetInt32(11);
                    templisting.Listinglife = reader.GetInt32(12);
                    templisting.Trader_id = reader.GetInt32(13);

                    listings.Add(templisting);

                }

            }

            

        }

        return listings;

    }
    
    public List<Trader> SearchForTrader(int traderid = 0)
    {

        List<Trader> traders = new List<Trader>();

        using (SqlConnection conn = new SqlConnection(CONNSTRING))
        {
            conn.Open();

            string sql;

            if (traderid == 0)
            {

                sql = "SELECT * FROM TraderList";

            }

            else
            {

                sql = "SELECT * FROM TraderList WHERE trader_id = @traderid";

            }

            using (SqlCommand command = new SqlCommand(sql, conn))
            {

                if (traderid != 0)
                {

                    command.Parameters.AddWithValue("traderid", traderid);

                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Trader temptrader = new Trader();

                    if (reader.GetInt32(3) != 1)
                    {

                        temptrader.Trader_id = reader.GetInt32(0);
                        temptrader.Username = reader.GetString(1);
                        temptrader.Class_Schedule = new ClassSchedule(reader.GetString(4));
                        temptrader.Warnings = reader.GetInt32(5);

                        traders.Add(temptrader);

                    }

                }

            }

        }

        return traders;

    }


    //overloaded SearchForTrader that uses a string representing the trader's username
    //used for login process
    //empty string will return list of all traders
    public List<Trader> SearchForTrader(string uName)
    {

        List<Trader> traders = new List<Trader>();

        using (SqlConnection conn = new SqlConnection(ConnString))
        {

            conn.Open();
            string sql;

            if (uName == "")
            {

                sql = "SELECT * FROM TraderList";

            }

            else
            {

                sql = "SELECT * FROM TraderList WHERE username = @uName";

            }

            using (SqlCommand command = new SqlCommand(sql, conn))
            {

                if (uName != "")
                {

                    command.Parameters.AddWithValue("uName", uName);

                    command.ExecuteNonQuery();

                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Trader temptrader = new Trader();

                    temptrader.Trader_id = reader.GetInt32(0);
                    temptrader.Username = reader.GetString(1);
                    temptrader.Password = reader.GetString(2);
                    temptrader.Deleted = reader.GetInt32(3);
                    if (!reader.IsDBNull(4))
                    {

                        temptrader.Class_Schedule = new ClassSchedule(reader.GetString(4));

                    }
                    temptrader.Warnings = reader.GetInt32(5);
                    temptrader.FirstName = reader.GetString(6);
                    temptrader.LastName = reader.GetString(7);
                    //Email email = new Email(reader.GetString(8));
                    //temptrader._Email = email;

                    if (temptrader.Deleted == 0)
                    {

                        traders.Add(temptrader);

                    }

                }

            }

            conn.Close();

        }

        return traders;

    }

}

