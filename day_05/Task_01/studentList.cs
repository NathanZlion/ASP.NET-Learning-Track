
using System.Text.Json;

namespace StudentManagementSystem {
    class StudentList<T> {

        private List<T> listOfStudents = new();

        public void AddStudent(T student) {
            listOfStudents.Add(student);
        }

        public void displayStudents() {
            if (listOfStudents.Count > 0) {
                foreach (T student in listOfStudents) {
                    Console.WriteLine(student!.ToString());
                }
            } else {
                Console.WriteLine("The list of students is empty ...");
            }
        }


        public void SearchById(int id) {
            List<Student>? students = listOfStudents as List<Student>;
            IEnumerable<Student> filteredResult =
            from student in students
            where student.RollNumber == id
            select student;

            if (filteredResult.Count() > 0) {
                foreach (Student student in filteredResult) {
                    Console.WriteLine(student.ToString());
                }
            } else {
                Console.WriteLine("No Student by that Id found");
            }
        }


        public void SearchByName(string name) {
            List<Student>? students = listOfStudents as List<Student>;
            IEnumerable<Student> filteredResult =
            from student in students
            where student.Name == name
            select student;

            if (filteredResult.Count() > 0) {
                foreach (Student student in filteredResult) {
                    Console.WriteLine(student.ToString());
                }
            } else {
                Console.WriteLine("No Student by that Name found");
            }
        }
        public string? Serialize(string fileName) {
            try {
                string jsonString = JsonSerializer.Serialize<List<T>>(listOfStudents);
                Console.WriteLine(jsonString);
                Console.WriteLine("here");
                File.WriteAllText(fileName, jsonString);
                Console.WriteLine("Reached Here ");
                return jsonString;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void DeSerialize(string filePath) {
            try {
                if (!File.Exists(filePath)) {
                    // Create an empty file if it doesn't exist
                    File.Create(filePath).Close();
                }

                string json = File.ReadAllText(filePath);
                listOfStudents = JsonSerializer.Deserialize<List<T>>(json)!;
            } catch (Exception) {
                throw;
            }
        }
    }
}