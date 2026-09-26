using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal class Follow:BaseEntity
    {
        private Guid _followerId;
        private Guid _followingId;

        public Follow():base(Guid.NewGuid())
        {
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public override string DescribeRecord()
        {
            
            return $"FollowerId: {FollowerId}, FollowingId: {FollowingId}";
        }
    }
}
