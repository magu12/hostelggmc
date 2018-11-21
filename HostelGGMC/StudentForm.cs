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
        RoomController roomController = new RoomController();

        public void DoOperationsFilter()
        {
            var student = studentController.GetAllStudents();

            dgStudent.Rows.Clear();

            if (cbStage.SelectedIndex >= 0)
            {
                var filter =
                from d in student
                where d.Room.ToString()[0] == cbStage.SelectedItem.ToString()[0]
                select d;
                student = filter;
            }
            if (cbRoom.SelectedIndex >= 0 && cbStage.SelectedIndex >= 0)
            {
                var filter =
                from d in student
                where d.Room.ToString() == (cbStage.SelectedItem.ToString() + "-" + cbRoom.SelectedItem.ToString())
                select d;
                student = filter;
            }
            if (tbStudent.Text.Length >= 1)
            {
                var filter =
                from d in student
                where d.StudentName.StartsWith(tbStudent.Text)
                select d;
                student = filter;
            }
            if (cbGroupName.SelectedIndex >= 0)
            {
                var filter =
                from d in student
                where d.GroupName.ToString() == cbGroupName.SelectedItem.ToString()
                select d;
                student = filter;
            }
            if (tbGroupNomber.Text.Length >= 1)
            {
                var filter =
                from d in student
                where d.GroupNumber.ToString().StartsWith(tbGroupNomber.Text)
                select d;
                student = filter;
            }
            if (cbInhabited.Checked == true)
            {
                var filter =
                from d in student
                where d.Inhabited == 1
                select d;
                student = filter;
            }
            if (cbNotInhabited.Checked == true)
            {
                var filter =
                from d in student
                where d.Inhabited == 0
                select d;
                student = filter;
            }
            if (cbEvited.Checked == true)
            {
                var filter =
                from d in student
                where d.Envicted == 1
                select d;
                student = filter;
            }

            foreach (Student students in student)
            {
                dgStudent.Rows.Add(students.Id, students.StudentName, students.Room,
                  students.Inhabited, students.Envicted, students.GroupName, students.GroupNumber, ConvertRoomType(students.RoomType));
            }
        }

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            FillData();
        }
        public void FillData()
        {
            var result = studentController.GetAllStudents();
            dgStudent.Rows.Clear();
            foreach (Student student in result)
            {
                dgStudent.Rows.Add(student.Id, student.StudentName, student.Room,
                   student.Inhabited, student.Envicted, student.GroupName, student.GroupNumber, ConvertRoomType(student.RoomType));
            }
        }

        public string ConvertRoomType(byte bt)
        {
            if (bt == 1)
                return "Двойка";
            return "Тройка";
        }

        private void DefaultForm()
        {
            cbRoom.SelectedItem = null;
            cbStage.SelectedItem = null;
            cbGroupName.SelectedItem = null;
            tbGroupNomber.Text = null;
            tbStudent.Text = null;
            cbInhabited.Checked = false;
            cbNotInhabited.Checked = false;
            cbEvited.Checked = false;
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

        private void cbStage_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cbStage.SelectedItem != null)
                {
                    DoOperationsFilter();
                }
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoom.SelectedItem != null)
            {
                DoOperationsFilter();
            }
        }

        private void cbRoom_Enter(object sender, EventArgs e)
        {
            var rooms = roomController.RoomSearch(int.Parse(cbStage.SelectedItem.ToString()));
            cbRoom.Items.Clear();
            foreach (Room rm in rooms)
                cbRoom.Items.Add(rm.Number);
        }

        private void tbStudent_TextChanged(object sender, EventArgs e)
        {
            DoOperationsFilter();
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupName.SelectedItem != null)
            {
                DoOperationsFilter();
            }
        }

        private void tbGroupNomber_TextChanged(object sender, EventArgs e)
        {
            if (tbGroupNomber.Text != null)
            {
                DoOperationsFilter();
            }
        }

        private void cbNotInhabited_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotInhabited.Checked == true)
            {
                cbInhabited.Checked = false; cbEvited.Checked = false;
                DoOperationsFilter();
            }
            else if (cbInhabited.Checked == false && cbEvited.Checked == false) { DefaultForm(); StudentForm_Load(sender, e); }
        }

        private void cbInhabited_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInhabited.Checked == true)
            {
                cbNotInhabited.Checked = false; cbEvited.Checked = false;
                DoOperationsFilter();
            }
            else if (cbNotInhabited.Checked == false && cbEvited.Checked == false) { DefaultForm(); StudentForm_Load(sender, e); };
        }

        private void cbEvited_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvited.Checked == true)
            {
                cbInhabited.Checked = false; cbNotInhabited.Checked = false;
                DoOperationsFilter();
            }
            else if (cbNotInhabited.Checked == false && cbInhabited.Checked == false) { DefaultForm(); StudentForm_Load(sender, e); }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            StudentAddForm studentAddForm = new StudentAddForm();
            studentAddForm.ShowDialog();
            StudentForm_Load(sender, e);
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Потвердите удаление.", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                studentController.DeleteStudent(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
                StudentForm_Load(sender, e);

            }
        }
    }
}