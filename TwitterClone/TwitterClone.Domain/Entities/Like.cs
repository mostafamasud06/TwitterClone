using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _likedAt;

        public Like()
        {
            _userId = Guid.NewGuid();
            _tweetId = Guid.NewGuid();
           
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public string TwitterId
        {
            get { return _likedAt; }
            set { _likedAt = value; }
        }

    }
}
