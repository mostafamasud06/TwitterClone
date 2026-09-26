namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {

        private string _firstName;
        private string _lastName;
        private string _email;

        // Constructor Chaining , in here base clase (BaseEntity.cs)'s constructor called , by that constructors parameter value passed
        // passrd by this constructor
        public User() : base(Guid.NewGuid())
        {

        }
        public string FirstName // Property for the user's first name
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public override string DescribeRecord()
        {

            return $"FirstName: {FirstName}, LastName: {LastName}, Email: {Email}";
        }


        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _inComingNotifications = new List<Guid>();


        public void Follow(Guid userId)
        {
            if (!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }

        }

        public void UnFollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }

        }
    

        public void AddNotification(Guid notificationId)
            {
             if(!_inComingNotifications.Contains(notificationId))
            {
                _inComingNotifications.Add(notificationId);
            }

                
            }
    }
}
