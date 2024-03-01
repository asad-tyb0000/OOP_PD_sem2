using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Set
    {
        private int Repetitions;
        private double Weight;

        public int GetRepetitions()
        {
            return Repetitions;
        }

        public void SetRepetitions(int Repetitions)
        {
            this.Repetitions = Repetitions;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public void SetWeight(double Weight)
        {
            this.Weight = Weight;
        }

        public Set(int Repetitions, double Weight)
        {
            SetRepetitions(Repetitions);
            SetWeight(Weight);
        }
    }
}
