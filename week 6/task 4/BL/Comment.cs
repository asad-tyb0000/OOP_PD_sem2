using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Comment
    {
        public string Text;
        public User Author;

        public Comment(string text, User author)
        {
            Text = text;
            Author = author;
        }
        public string GetText() 
        {
            return Text; 
        }
        public void SetText(string text) 
        {
            Text = text;
        }
    }
}