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
    public partial class InhabitedAndEvictedForm : Form
    {
        StudentController studentController = new StudentController();
        RoomController roomController = new RoomController();

        public void DoOperationsFilter()
        {
            var student = studentController.GetAllStudents();
            IEnumerable<Student> result = new List<Student>();

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
                where d.StudentName == tbStudent.Text
                select d;
                student = filter;
            }
            if (cbGroupName.SelectedIndex >= 0)
            {
                var filter =
                from d in student
                where d.GroupName.ToString() == cbGroupName.SelectedIndex.ToString()
                select d;
                student = filter;
            }
            if (tbGroupNomber.Text.Length >= 1)
            {
                var filter =
                from d in student
                where d.GroupNumber.ToString() == tbGroupNomber.Text
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
            foreach (Student st in student)
            {
                dgStudent.Rows.Add(st.Id, st.StudentName, st.Room, st.Inhabited, st.Envicted, st.GroupName, st.GroupNumber, st.RoomType);
            }
        }

        public InhabitedAndEvictedForm()
        {
            InitializeComponent();
        }

        private void InhabitedAndEvictedForm_Load(object sender, EventArgs e)
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

        private void dgStudent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void InhabitedAndEvictedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DefaultForm();
            InhabitedAndEvictedForm_Load(sender, e);
        }

        private void cbStage_Enter(object sender, EventArgs e)
        {

        }

        private void cbStage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStage.SelectedItem != null)
            {
                DoOperationsFilter();
               /* var result = studentController.GetStudentsbByStage(cbStage.SelectedItem.ToString());
                dgStudent.Rows.Clear();
                foreach (Student student in result)
                {
                    if (student.RoomType == 1)
                        dgStudent.Rows.Add(student.Id, student.StudentName, student.Room,
                           student.Inhabited, student.Envicted, student.GroupName, student.GroupNumber, "Двойка");
                    if (student.RoomType == 0)
                        dgStudent.Rows.Add(student.Id, student.StudentName, student.Room,
                          student.Inhabited, student.Envicted, student.GroupName, student.GroupNumber, "Тройка");
                }*/
            }
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoom.SelectedItem != null)
            {
                DoOperationsFilter();
                /*
                var result = studentController.GetStudentsbByStage(cbStage.SelectedItem.ToString() + "-" + cbRoom.SelectedItem.ToString());
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
                */
            }
        }

        private void cbRoom_Enter(object sender, EventArgs e)
        {
            var rooms = roomController.RoomSearch(int.Parse(cbStage.SelectedItem.ToString()));
            cbRoom.Items.Clear();
            foreach (Room rm in rooms)
                cbRoom.Items.Add(rm.Number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(dgStudent[3, dgStudent.SelectedRows[0].Index].Value.ToString()) == 0)
            {
                studentController.DelEnvictedById(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
                studentController.SetInhabitedById(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
                InhabitedAndEvictedForm_Load(sender, e);
            } else
            if (int.Parse(dgStudent[3, dgStudent.SelectedRows[0].Index].Value.ToString()) == 1)
            {
                studentController.DelEnvictedById(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
                studentController.DelInhabitedById(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
                InhabitedAndEvictedForm_Load(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbStudent.Text != null)
            {
                DoOperationsFilter();
                /*
                var result = studentController.GetStudentsByName(tbStudent.Text);
                dgStudent.Rows.Clear();
                try
                {
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
                catch { }*/
            }
        }

        private void buttonEvicted_Click(object sender, EventArgs e)
        {
            studentController.DelInhabitedById(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
            studentController.SetEnvictedById(int.Parse(dgStudent[0, dgStudent.SelectedRows[0].Index].Value.ToString()));
            InhabitedAndEvictedForm_Load(sender, e);
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupName.SelectedItem != null)
            {
                var result = studentController.GetStudentsbByGroupName(cbGroupName.SelectedItem.ToString());
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
        }

        private void tbGroupNomber_TextChanged(object sender, EventArgs e)
        {
            if (tbGroupNomber.Text != null && cbGroupName.SelectedItem != null)
            {
                var result = studentController.GetStudentsbByGroupNameAndGroupNumber(cbGroupName.SelectedItem.ToString(), tbGroupNomber.Text);
                dgStudent.Rows.Clear();
                try
                {
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
                catch { }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInhabited.Checked == true)
            {
                cbNotInhabited.Checked = false; cbEvited.Checked = false;
                var result = studentController.GetStudentsbByInhabited(1);
                dgStudent.Rows.Clear();
                try
                {
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
                catch { }
            }
            else if (cbNotInhabited.Checked == false && cbEvited.Checked == false) { DefaultForm(); InhabitedAndEvictedForm_Load(sender, e); };
        }

        private void cbNotInhabited_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotInhabited.Checked == true)
            {
                cbInhabited.Checked = false; cbEvited.Checked = false;
                var result = studentController.GetStudentsbByInhabited(0);
                dgStudent.Rows.Clear();
                try
                {
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
                catch { }
            }
            else if (cbInhabited.Checked == false && cbEvited.Checked == false) { DefaultForm(); InhabitedAndEvictedForm_Load(sender, e); }
        }

        private void cbEvited_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvited.Checked == true)
            {
                cbInhabited.Checked = false; cbNotInhabited.Checked = false;
                var result = studentController.GetStudentsbByEnvicted(1);
                dgStudent.Rows.Clear();
                try
                {
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
                catch { }
            }
            else if(cbNotInhabited.Checked == false && cbInhabited.Checked == false) { DefaultForm(); InhabitedAndEvictedForm_Load(sender, e); }
        }
    }
    
}
