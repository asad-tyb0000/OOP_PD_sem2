using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Routine
    {
        private string Name;
        private List<Exercise> Exercises = new List<Exercise>();

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public List<Exercise> GetExercises()
        {
            return Exercises;
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public Routine(string Name)
        {
            SetName(Name);
        }
    }
}
