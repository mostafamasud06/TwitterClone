
using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class10_PolymorphismTest_
    {
        public void Run() 
        {
            ILikeable likeableTweet = new Tweet("This is another tweet!");

            Console.WriteLine(likeableTweet.CanBeLiked());

            var maxTweetLength = 200;
        }

    }
}
