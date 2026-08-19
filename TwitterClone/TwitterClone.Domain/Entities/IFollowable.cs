using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal interface IFollowable
    {
        void Follow(Guid userId);
        void UnFollow(Guid userId);
    }
}
