﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Eric TODO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Moderator : Account
{
	public virtual Account account
	{
		get;
		set;
	}

	public virtual IEnumerable<Listing> Listing
	{
		get;
		set;
	}

	public virtual ModeratorView ModeratorView
	{
		get;
		set;
	}

	public virtual Marketplace Marketplace
	{
		get;
		set;
	}

	public virtual Search Search
	{
		get;
		set;
	}

	public virtual void RemoveListing(Listing listing)
	{
		throw new System.NotImplementedException();
	}

	public virtual void WarnTrader(Trader trader)
	{
		throw new System.NotImplementedException();
	}

	public virtual void BanTrader(Trader trader)
	{
		throw new System.NotImplementedException();
	}

	public virtual int SearchForUser(Trader trader)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ViewUserInfo(Trader trader)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ViewSystemStats()
	{
		throw new System.NotImplementedException();
	}

}

