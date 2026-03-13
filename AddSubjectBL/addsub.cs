using System;
using subjects;
using Models;

namespace AddSubjectBL
{
    public class AddSubBL
    {
        private AddSubject addSubject = new AddSubject();

        public void AddSubject(string subjectName, string schedule)
        {
            bool added = addSubject.Add(subjectName, schedule);

            if (added)
            {
                Console.WriteLine("Subject added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add subject. Subject list may be full.");
            }
        }

        public void ShowSubjects()
        {
            addSubject.ShowSubjects();
        }
        public void RemoveSubject(int subjectIndex)
        {
            bool removed = addSubject.Remove(subjectIndex);

            if (removed)
                Console.WriteLine("Subject removed successfully.");
            else
                Console.WriteLine("Failed to remove subject.");
        }
    }
}

