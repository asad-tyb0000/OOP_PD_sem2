using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class User
    {
        public string Username;
        public List<Post> Posts;
        public List<User> Followers;
        public List<User> Followings;

        public User(string username)
        {
            Username = username;
            Posts = new List<Post>();
            Followers = new List<User>();
            Followings = new List<User>();
        }
    }
}
