using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Post
    {
        public string Content;
        public User Author;
        public List<Comment> Comments;

        public Post(string content, User author)
        {
            Content = content;
            Author = author;
            Comments = new List<Comment>();
        }
    }
}
