﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Listing
{
	public virtual string title
	{
		get;
		set;
	}

	public virtual string author
	{
		get;
		set;
	}

	public virtual string edition
	{
		get;
		set;
	}

	public virtual string isbn
	{
		get;
		set;
	}

	public virtual string courseCode
	{
		get;
		set;
	}

	public virtual string courseLevel
	{
		get;
		set;
	}

	public virtual string lastUsed
	{
		get;
		set;
	}

	public virtual string condition
	{
		get;
		set;
	}

	public virtual double price
	{
		get;
		set;
	}

	public virtual image picture
	{
		get;
		set;
	}

	public virtual string description
	{
		get;
		set;
	}

	public Listing()
	{
	}

    public Listing(string title, string author, string edition, string isbn, string cC, string cL, string condition, double price)
    {
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.courseCode = cC;
        this.courseLevel = cL;
        this.condition = condition;
        this.price = price;
    }

    public virtual void UpdateAll(string title, string author, string edition, string isbn, string cC, string cL, string condition, double price, string lastUsed, image picture, string description)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateAuthor(string author)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateCondition(string condition)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateCourseCode(string cC)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateCourseLevel(string cL)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateDescription(string desciption)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateEdition(string edition)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateISBN(string isbn)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateLastUsed(string lastUsed)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdatePicture(image picture)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdatePrice(double price)
	{
		throw new System.NotImplementedException();
	}

	public virtual void UpdateTitle(string title)
	{
		throw new System.NotImplementedException();
	}

}

