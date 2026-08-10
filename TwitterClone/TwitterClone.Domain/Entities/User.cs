namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {

        private string _firstName;
        private string _lastName;
        private string _email;
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
    }
}
