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

public class DataBase
{

    private const string CONNSTRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Database\\TTDatabase.mdf;Integrated Security=True;Connect Timeout=30";


    public string ConnString
	{
		get { return CONNSTRING; }
	}

	public virtual void Insert()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Remove()
	{
		throw new System.NotImplementedException();
	}

}

