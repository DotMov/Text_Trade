﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Eric TODO

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class TraderList : DataBase
{

    private DataBase db = new DataBase();
    private List<int> traderList = new List<int>();

	public virtual void Add(Trader trader) // this function probably needs to be moved to the trader class
	{

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            //conn.ConnectionString = db.ConnString;
            conn.Open();

            string sql;

            if (trader.Trader_id == -1)
            {

                sql = "INSERT into [UserList] (username, password, deleted, classschedule) "
                        + "VALUES ( @uname , @pword, 0, @CSched"
                        + "SELECT cast(scope_identity() as int)";

            }

            else
            {

                sql = "INSERT into [UserList] (username, password, deleted, classschedule) "
                        + "VALUES ( @uname , @pword, 0, @CSched"
                        + "WHERE trader_id = @trader_id";

            }

            SqlCommand command = new SqlCommand(sql,conn);

            command.Parameters.AddWithValue("uname", trader.UserName);
            command.Parameters.AddWithValue("pword", trader.Password);
            command.Parameters.AddWithValue("CSched", trader.Class_Schedule);

            if (trader.Trader_id == -1)
            {

                trader.Trader_id = (int)command.ExecuteScalar();

            }

            else
            {

                command.Parameters.AddWithValue("trader_id", trader.Trader_id);

                command.ExecuteNonQuery();

            }

        }

	}

    public void CreateList()
    {

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string query = "SELECT trader_id FROM TraderList";

            using (SqlCommand command = new SqlCommand(query, conn))
            {

                using (SqlDataReader dbreader = command.ExecuteReader())
                {

                    while (dbreader.Read())
                    {

                        traderList.Add(Convert.ToInt32(dbreader.GetString(0)));

                    }

                }

            }

        }

    }

	public virtual TraderList SearchForUser()
	{
		throw new System.NotImplementedException();
	}

}

