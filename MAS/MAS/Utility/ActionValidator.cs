﻿// Copyright (c) Omar AL Zabir. All rights reserved.
// For continued development and updates, visit http://msmvps.com/omar

using System;
using System.Web;

public static class ActionValidator
{
    private const int DURATION = 10; // 10 min period

    /*
    * Type of actions and their maximum value per period
    *
    */

    public enum ActionTypeEnum
    {
        None = 0,
        FirstVisit = 20, // The most expensive one, choose the value wisely.
        Revisit = 1000, // Welcome to revisit as many times as user likes
        Postback = 5000, // Not must of a problem for us
        AddNewWidget = 100,
        AddNewPage = 100,
    }

    private class HitInfo
    {
        public int Hits;
        private DateTime _ExpiresAt = DateTime.Now.AddMinutes(DURATION);

        public DateTime ExpiresAt
        {
            get { return _ExpiresAt; }
            set { _ExpiresAt = value; }
        }
    }

    public static bool IsValid(ActionTypeEnum actionType)
    {
        HttpContext context = HttpContext.Current;
        if (context.Request.Browser.Crawler) return false;

        string key = actionType.ToString() + context.Request.UserHostAddress;

        HitInfo hit = (HitInfo) (context.Cache[key] ?? new HitInfo());

        if (hit.Hits > (int) actionType) return false;
        else hit.Hits++;

        if (hit.Hits == 1)
            context.Cache.Add(key, hit, null, DateTime.Now.AddMinutes(DURATION),
                              System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal,
                              null);

        return true;
    }
}
