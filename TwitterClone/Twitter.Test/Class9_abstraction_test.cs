using TwitterClone.Domain.Entities;



// notifications a list instance -> Upcasting
var notifications = new List<Notification>
{
    new SystemNotification(),
    new LikeNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid())
};

foreach (var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}


//Notification likeNotificationMessage = new LikeNotification(Guid.NewGuid());
        //OR
//var likeNotificationMessage = new LikeNotification(Guid.NewGuid());
//Console.WriteLine(likeNotificationMessage.GetMessage());

//var systemNotificationMessage = new SystemNotification();
//Console.WriteLine(systemNotificationMessage.GetMessage());

//var mentionNotificationMessage = new MentionNotification(Guid.NewGuid());
//Console.WriteLine(mentionNotificationMessage.GetMessage());

//var friendRequestNotificationMessage = new FriendRequestNotification(Guid.NewGuid());
//Console.WriteLine(friendRequestNotificationMessage.GetMessage());


