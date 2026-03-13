using System;
using System.Collections.Generic;
using Models;

namespace subjects
{
    public class AddSubject
    {
        private List<Subject> subjects = new List<Subject>();
        private int maxSubjects = 5;

        public bool Add(string subjectName, string schedule)
        {
            if (subjects.Count >= maxSubjects)
            {
                Console.WriteLine("Subject List is Full");
                return false;
            }

            subjects.Add(new Subject(subjectName, schedule));
            return true;
        }

        public void ShowSubjects()
        {
            if (subjects.Count == 0)
            {
                Console.WriteLine("No subjects added yet.");
                return;
            }

            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {subjects[i]}");
            }
        }

        public bool Remove(int subjectIndex)
        {
            if (subjectIndex < 1 || subjectIndex > subjects.Count)
            {
                Console.WriteLine("Invalid subject number.");
                return false;
            }

            subjects.RemoveAt(subjectIndex - 1);
            return true;
        }
    }
}
