using System.Linq.Expressions;

namespace StudentManagementSystem
{

    class Program
    {
        static void Main()
        {
            StudentList<Student> _studentList = new();

            while (true) {
                _displayOptions();
                try {
                    _getInputAndExecuteCommand(_studentList);
                } catch (Exception e) {
                    Console.WriteLine(string.Format("An Error occurred: {0}", e.Message));
                }
            }
        }

        static void _displayOptions() {
            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) Display All The Students");
            Console.WriteLine("3) Search For Student (By Name Or ID)");
            Console.WriteLine("4) Import Class From Json File");
            Console.WriteLine("5) Export Class To Json File");
            Console.WriteLine("6) Exit");
        }

        static void _getInputAndExecuteCommand(StudentList<Student> studentList) {
            if (!int.TryParse(Console.ReadLine(), out int _input)) {
                throw new InvalidCastException("Please enter an integer");
            } switch (_input) {
                case 1:
                    _createStudent(studentList);
                    break;
                case 2:
                    studentList.displayStudents();
                    break;
                case 3:
                    _searchForStudent(studentList);
                    break;
                case 4:
                    _importClassFromJsonFile(studentList);
                    break;
                case 5:
                    _exportClassToJsonFile(studentList);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    throw new Exception("Input is not Correct!");
            }
        }

        static void _createStudent(StudentList<Student> studentList) {
            Student student = _getStudentByAsking();
            studentList.AddStudent(student);
        }

        static Student _getStudentByAsking() {
            try {
                Console.WriteLine("Enter Student Name. ");
                string name = Console.ReadLine()!;
                Console.WriteLine("Enter Student Age ");
                int age = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter Student Roll Number ");
                int rollNumber = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter Student Grade ");
                char grade = char.Parse(Console.ReadLine()!);
                return new Student(name, age, rollNumber, grade);
            } catch (Exception) {
                throw;
            }
        }

        static void _searchForStudent(StudentList<Student> studentList) {
            Console.WriteLine("Search by: \n 1. id 2. name");
            int input = int.Parse(Console.ReadLine()!);

            switch (input) {
                case 1:
                    Console.WriteLine("id");
                    int id = int.Parse(Console.ReadLine()!);
                    studentList.SearchById(id);
                    break;
                case 2:
                    Console.WriteLine("name");
                    string name = Console.ReadLine()!;
                    studentList.SearchByName(name);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        static void _importClassFromJsonFile(StudentList<Student> studentList) {
            Console.WriteLine("Enter the file Name: ");
            try {
                Console.WriteLine("Reached where I ask for input");
                string fileName = Console.ReadLine()!;
                Console.WriteLine("Reached after read input");
                studentList.DeSerialize(fileName);
            } catch (Exception e) {
                Console.WriteLine(string.Format("An Error occurred: {0}", e.Message));
            }
        }

        static void _exportClassToJsonFile(StudentList<Student> studentList) {
            Console.WriteLine("Enter the file name to export to: ");
            try {
                Console.WriteLine("Reached where I ask for input");
                string fileName = Console.ReadLine()!;
                Console.WriteLine("Reached after read input");
                studentList.Serialize(fileName);
            } catch (Exception e) {
                Console.WriteLine(string.Format("An Error occurred: {0}", e.Message));
            }
        }
    }

}