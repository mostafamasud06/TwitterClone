
namespace TwitterClone.Domain.Entities
{
    public abstract class Notification:BaseEntity
    {
        // FIELDS - Private variables that store data
        private Guid _userId;
        private string _title;
        private string _type;
        private string _message;
        private bool _isRead;
        public Notification(string notificationtype):base(Guid.NewGuid()) 
        {
            _type = notificationtype;
        }

        public Guid UserId
        {
            get {  return _userId; }
            set { _userId = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        // only child class will able to get this propertys like Notification
        protected string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public string GetNotificationInformation()
        {
            
            return $"UserId: {_userId}, NotificationType: {_type}, MessageRead: {_isRead}";
        }

        public abstract string GetMessage();
        
    }
}
