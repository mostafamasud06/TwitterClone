using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal class Retweet
    {
        private Guid _orginalTweetId;
        private Guid _reTweetId;
        private Guid _authorId;
        private string _reTweetContent;

        public Retweet()
        {
            _orginalTweetId = Guid.NewGuid();
            _reTweetId = Guid.NewGuid();
            _authorId = Guid.NewGuid();
        }

        public Guid OrginalTweetId
        {
            get { return _orginalTweetId; }
        }

        public Guid ReTweetId
        {
            get { return _reTweetId; }
        } 
        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string ReTweetContent
        {
            get { return _reTweetContent; }
            set { _reTweetContent = value; }
        }

    }
}
