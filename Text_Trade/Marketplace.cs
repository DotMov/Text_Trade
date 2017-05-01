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

public class Marketplace
{

    public const int LISTINGLIFE = 30;

    private int listingLifetime;
    public List<Listing> listings; //?
    private DataBase db = new DataBase();

	public int ListingLifeTime
	{

		get { return this.listingLifetime; }
		set { this.listingLifetime = value; }

    }

	public List<Listing> Listing
	{

		get { return this.listings; }

    }

	public virtual void RenewListing(Listing listing)
	{

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string sql;

            if (listing.Listing_id == -1)
            {

                sql = "UPDATE [UserList] "
                        + "SET listinglife = 30"
                        + "WHERE listing_id = @lid";

            }

            else
            {

                sql = "UPDATE [UserList] "
                        + "SET listinglife = 30"
                        + "WHERE listing_id = @lid";

            }

            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("lid", listing.Listing_id);

            command.ExecuteNonQuery();

        }

	}

	public virtual void AddListing(Listing listing,int trader_id)
	{

        listing.CreateListing(trader_id);

	}

	public virtual void RemoveListing(Listing listing)
	{
        db.Delete("listings", "listing_id", listing.Listing_id);
	}

	public virtual void FilterResults()
	{
		throw new System.NotImplementedException();
	}

	public void SearchAll()
	{

       // List<Listing> listings;

        listings = db.SearchForListing();

       // return listings;

	}

    public void SearchByBookTitle(string title)        //newly added Radio button for search by book title option - Linh
    {

       // List<Listing> listings;

        listings = db.SearchForListing("title", title);

        //return listings;

    }
    public void SearchByAuthor(string author)
	{

        //List<Listing> listings;

        listings = db.SearchForListing("author",author);

        //return listings;

    }

	public void SearchByCourse(string cC, string cL)
	{

        //List<Listing> listings;

        listings = db.SearchForListing("courseCode",cC,"courseLevel",cL);

        //return listings;

    }

	public void SearchByISBN(string isbn)
	{

       // List<Listing> listings;

        listings = db.SearchForListing("isbn",isbn);

       // return listings;

    }

	public void SearchFromSchedule(ClassSchedule classSchedule)
	{

      //  List<Listing> listings;

        listings = db.SearchForListing();

       // return listings;

    }

}

