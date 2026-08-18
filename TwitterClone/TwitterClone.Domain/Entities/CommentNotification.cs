using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification:Notification
    {
        public CommentNotification(Guid commentByUserId) :base("comment")
        {
            CommentByUserId = commentByUserId;
        }

        public Guid CommentByUserId { get; set; }

        public void CommentNotificationMessage(string message) 
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            
            return $"CommentByUserId: {CommentByUserId} ";
        }

        public override string GetMessage()
        {
            return $"User with ID {CommentByUserId} commented on your post. Check to reply";
        }
    }
}
