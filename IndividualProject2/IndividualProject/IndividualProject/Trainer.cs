using System;

namespace IndividualProject
{
    class Trainer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string subject { get; set; }
        public Trainer() { }
        public Trainer(string firstName, string lastName, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }

        public void Print()
        {
            Console.WriteLine($"Trainer : {firstName} {lastName} teaches {subject}");
        }
    }
}
