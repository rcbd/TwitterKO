using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwitterKO.Models;

namespace TwitterKO.Controllers
{
    public class TweetController : ApiController
    {
        public IEnumerable<Tweet> Get(string query)
        {
            var tweets = new List<Tweet>();

            var i = 0;
            while (i < 10)
            {
                tweets.Add(new Tweet {Message = Guid.NewGuid().ToString()});
                i++;
            }

            return tweets;
        }

    }
}
