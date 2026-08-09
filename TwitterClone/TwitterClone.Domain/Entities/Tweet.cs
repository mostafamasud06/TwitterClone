using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;

        public Tweet()
        {
            _id = Guid.NewGuid();
            _authorId = Guid.NewGuid();
        }
        public Guid Id { get { return _id; } }
        public Guid AuthorId { get { return _authorId; } }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
    