using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterKO.Models
{
    public class TwitterSearchModel
    {

        public static IEnumerable<string> GetTweets(string query)
        {
            return new String[]{ "foo", "bar" }.ToList();
        }

    }
}