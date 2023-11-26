using static University.Program;

namespace University
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        // Інтерфейс для виведення інформації про особу
        public interface IPerson
        {
            string GetPersonInfo();
        }

        public interface IStudent : IPerson
        {
            void Write();
        }

        public abstract class Person : IPerson
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract string GetPersonInfo();
        }

        public class University
        {
            public string Name { get; set; }
            public List<Faculty> Faculties { get; } = new List<Faculty>();

            public University(string name)
            {
                Name = name;
            }

            public void AddFaculty(string facultyName)
            {
                Faculties.Add(new Faculty(facultyName));
            }
        }

        public class Faculty
        {
            public string Name { get; set; }
            public List<Department> Departments { get; } = new List<Department>();

            public Faculty(string name)
            {
                Name = name;
            }

            public void AddDepartment(string departmentName)
            {
                Departments.Add(new Department(departmentName));
            }
        }

        public class Department
        {
            public string Name { get; set; }
            public List<StudentGroup> StudentGroups { get; } = new List<StudentGroup>();

            public Department(string name)
            {
                Name = name;
            }

            public void AddStudentGroup(string groupName)
            {
                StudentGroups.Add(new StudentGroup(groupName));
            }
        }

        public class StudentGroup
        {
            public string Name { get; set; }
            public List<Student> Students { get; } = new List<Student>();

            public StudentGroup(string name)
            {
                Name = name;
            }

            public void AddStudent(string studentName, int age, Faculty faculty, Department department)
            {
                Students.Add(new Student(studentName, age, this, faculty, department));
            }
        }

        public class Student : Person, IStudent
        {
            private Faculty? faculty;
            private Department? department;

            public StudentGroup Group { get; set; }
            public Faculty StudentFaculty { get; set; }
            public Department StudentDepartment { get; set; }

            public Student(string name, int age, StudentGroup group, Faculty faculty, Department department)
            {
                Name = name;
                Age = age;
                Group = group;
                StudentFaculty = faculty;
                StudentDepartment = department;
            }

            public override string GetPersonInfo()
            {
                return $"Студент: {Name}, Вік: {Age}, Група: {Group.Name}, Факультет: {StudentFaculty.Name}, Кафедра: {StudentDepartment.Name}";
            }

            public void Write()
            {
                MessageBox.Show($"Студент {Name} пише...");
            }
        }
    }
}