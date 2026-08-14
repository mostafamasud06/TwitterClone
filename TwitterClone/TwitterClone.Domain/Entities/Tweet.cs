

namespace TwitterClone.Domain.Entities
{
    public class Tweet:BaseEntity
    {
        private Guid _userid;
        
        private string _content;

        // first base cnstructor will initialized than Tweet constructor

        public Tweet(string content):base(Guid.NewGuid())
        {
            _content = content;
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

        public override string DescribeRecord()
        {
            
            return $"UserId: {UserId}, Content: {Content}";
        }
    }
}
    