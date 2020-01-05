using System;

namespace IndividualProject
{
    class Assignment
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime subDateTime { get; set; }
        public float oralMark { get; set; }
        public float totalMark { get; set; }

        public Assignment() { }
        public Assignment(string title, string description, DateTime subDateTime, float oralMark, float totalMark)
        {
            this.title = title;
            this.description = description;
            this.subDateTime = subDateTime;
            this.oralMark = oralMark;
            this.totalMark = totalMark;
        }
        public void Print()
        {
            Console.WriteLine($"Assignment:{title} {description} until {subDateTime.ToShortDateString()} oral mark{oralMark} and total {totalMark}");
        }
        public void SimplePrint()
        {
            Console.WriteLine($"\t\tAssignment:{title} {description}");
        }
    }
}
