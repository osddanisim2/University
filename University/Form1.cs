using System.Windows.Forms;
using static University.Program;

namespace University
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            if (int.TryParse(textBoxAge.Text, out age))
            {
                Faculty faculty = new Faculty(textBoxFaculty.Text);
                Department department = new Department(textBoxDepartment.Text);
                StudentGroup group = new StudentGroup(textBoxGroup.Text);

                Student myStudent = new Student(textBoxName.Text, age, group, faculty, department);
                MessageBox.Show(myStudent.GetPersonInfo());
            }
            else
            {
                MessageBox.Show("Некоректне значення віку.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age;
            if (int.TryParse(textBoxAge.Text, out age))
            {
                Faculty faculty = new Faculty(textBoxFaculty.Text);
                Department department = new Department(textBoxDepartment.Text);
                StudentGroup group = new StudentGroup(textBoxGroup.Text);

                Student myStudent = new Student(textBoxName.Text, age, group, faculty, department);
                myStudent.Write();
            }
            else
            {
                MessageBox.Show("Некоректне значення віку.");
            }
            }
    }
}