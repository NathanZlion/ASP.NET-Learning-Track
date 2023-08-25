
using System.Text.Json.Serialization;

namespace StudentManagementSystem {
    class Student {
        public string Name { get; set; }
        public int Age { get; set; }
        public readonly int RollNumber;
        public char Grade { get; set; }

        [JsonConstructor]
        public Student(string name, int age, int rollNumber, char grade) {
            Name = name;
            Age = age;
            RollNumber = rollNumber;
            Grade = grade;
        }

        public override string ToString() {
            return string.Format("Name: {0} | Age: {1} | RollNumber: {2} | Grade: {3}", Name, Age, RollNumber, Grade);
        }
    }
}