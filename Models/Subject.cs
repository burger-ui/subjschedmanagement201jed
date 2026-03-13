namespace Models
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public string Schedule { get; set; }

        public Subject(string subjectName, string schedule)
        {
            SubjectName = subjectName;
            Schedule = schedule;
        }

        public override string ToString()
        {
            return $"{SubjectName} - {Schedule}";
        }
    }
}
