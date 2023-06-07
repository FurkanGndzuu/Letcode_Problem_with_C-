using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Design_Letcode
{
    public class Twitter
    {
        List<User> users;
        
        public Twitter()
        {
            users = new List<User>();
        }

        public void PostTweet(int userId, int tweetId)
        {
            User? user = users.FirstOrDefault(x => x.UserId.Equals(userId));
            if(user is not null)
            {
               if(!user.Tweets.Any(x => x.Key == tweetId))
                {
                    user.Tweets.Add(tweetId, DateTime.UtcNow);
                }
            }
            else
            {
                users.Add(new User
                {
                    UserId = userId , 
                    Follows = new List<int>(),
                    Tweets = new Dictionary<int, DateTime> { { tweetId, DateTime.UtcNow }}
                });
            }
        }

        public IList<int> GetNewsFeed(int userId)
        {
            Dictionary<int, DateTime> dic = new Dictionary<int, DateTime>();  
            
            User user = users.FirstOrDefault(x => x.UserId.Equals(userId));
            if (user is null)
            {
                users.Add(new User { UserId = userId, Follows = new List<int>(), Tweets = new Dictionary<int, DateTime>() });
                return new List<int>();
            }
            if (user.Tweets.Count > 10)
                 foreach(var item in user.Tweets.Skip(user.Tweets.Count - 10).Take(10))
                {
                    dic.Add(item.Key, item.Value);
                }
            else
                foreach (var item in user.Tweets)
                {
                    dic.Add(item.Key, item.Value);
                }
            user.Follows.ForEach(x =>
            {
                User? newUser = users.FirstOrDefault(a => a.UserId.Equals(x));
                if(newUser is not null)
                {
                    if (newUser.Tweets.Count > 10)
                        foreach (var item in newUser.Tweets.Skip(user.Tweets.Count - 10).Take(10))
                        {
                            if(!dic.Keys.Contains(item.Key))
                                dic.Add(item.Key, item.Value);
                        }
                    else
                        foreach(var item in newUser.Tweets)
                        {
                            if (!dic.Keys.Contains(item.Key))
                                dic.Add(item.Key, item.Value);
                        }
                }
            });
            List<int> response = new List<int>();
            int a = 10;
            if (dic.Count < 10)
                a = dic.Count;
            dic.OrderByDescending(x => x.Value).Take(a).ToList().ForEach(x =>
            {
                response.Add(x.Key);
            });

            dic.Clear();
            return response;
        }

        public void Follow(int followerId, int followeeId)
        {
            User? user = users.FirstOrDefault(x => x.UserId.Equals(followerId));
            User? followeeUser = users.FirstOrDefault(x => x.UserId.Equals(followeeId));
            if (user is not null && followeeUser is not null)
            {
                user.Follows.Add(followeeId);
            }
            else if(followeeUser == null && user != null)
            {
                users.Add(new User()
                {
                    UserId = followerId,
                    Follows = new List<int>() ,
                    Tweets = new Dictionary<int, DateTime>()
                });
                user.Follows.Add(followeeId);

            }
            else if(followeeUser == null && user == null)
            {
                users.Add(new User
                {
                    UserId = followerId,
                    Follows = new List<int>() { followeeId },
                    Tweets = new Dictionary<int, DateTime>()
                });
                users.Add(new User()
                {
                    UserId = followerId,
                    Follows = new List<int>(),
                    Tweets = new Dictionary<int, DateTime>()
                });
            }
            else
            {
                users.Add(new User
                {
                    UserId = followerId,
                    Follows = new List<int>() { followeeId },
                    Tweets = new Dictionary<int, DateTime>()
                });
            }
        }

        public void Unfollow(int followerId, int followeeId)
        {
            User? user = users.FirstOrDefault(x => x.UserId.Equals(followerId));
            if(user is not null)
            {
                user.Follows.Remove(followeeId);
            }
            else
            {
                users.Add(new User
                {
                    UserId = followerId,
                    Follows = new List<int>(),
                    Tweets = new Dictionary<int, DateTime>()
                });
            }
        }
    }

    class User
    {
        public int UserId { get; set; }
        public Dictionary<int , DateTime> Tweets { get; set; }
        public List<int> Follows { get; set; }
        
    }
   
}
