using MainLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace HostelGGMC
{
    public partial class StudentForm : Form
    {
        StudentController studentController = new StudentController();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            var result = studentController.GetAllStudents();
            dgStudent.Rows.Clear();
            foreach (Student student in result)
            {
                if (student.RoomType == 1)
                    dgStudent.Rows.Add(student.Id, student.StudentName, student.Room,
                       student.Inhabited, student.Envicted, student.GroupName, student.GroupNumber, "Двойка");
                if (student.RoomType == 0)
                    dgStudent.Rows.Add(student.Id, student.StudentName, student.Room,
                      student.Inhabited, student.Envicted, student.GroupName, student.GroupNumber, "Тройка");
            }
        }

        private void dgStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StudentAddForm studentAddForm = new StudentAddForm();
                studentAddForm.ShowDialog();
                StudentForm_Load(sender, e);

            }
            if (e.KeyCode == Keys.Delete && dgStudent.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Потвердите удаление.", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    studentController.DeleteStudent(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
                    StudentForm_Load(sender, e);
                }

            }
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ShowBaseMenu showBaseMenu = new ShowBaseMenu();
            showBaseMenu.Show();
        }
    }
}
