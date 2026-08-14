using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet:Tweet
    {
        public Retweet(Guid tweetByUserId) :base("tweet") 
        {
            TweetByUserId = tweetByUserId;
        }

        public Guid TweetByUserId { get; set; }

    }
}
