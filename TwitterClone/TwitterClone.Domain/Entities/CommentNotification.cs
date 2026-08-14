using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification:Notification
    {
        public CommentNotification(string commentByUserId) :base("comment")
        {
            CommentByUserId = commentByUserId;
        }

        public string CommentByUserId { get; set; }

        public void CommentNotificationMessage(string message) 
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            
            return $"CommentByUserId: {CommentByUserId} ";
        }
    }
}
