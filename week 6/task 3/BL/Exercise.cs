using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Exercise
    {
        private string Name;
        private List<Set> Sets = new List<Set>();

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public List<Set> GetSets()
        {
            return Sets;
        }

        public void AddSet(Set set)
        {
            Sets.Add(set);
        }

        public Exercise(string Name)
        {
            SetName(Name);
        }

    }
}
