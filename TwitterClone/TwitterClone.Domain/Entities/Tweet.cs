

namespace TwitterClone.Domain.Entities
{
    public class Tweet:BaseEntity
    {
        private Guid _userid;
        
        private string _content;

        public Tweet()
        {
            _id = Guid.NewGuid();
       
        }
        public Guid UserId 
        { 
            get { return _userid; } 
            set { _userid = value; }
        }
        

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
    