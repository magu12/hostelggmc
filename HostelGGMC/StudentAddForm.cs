using MainLibrary;
using System;
using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelGGMC
{
    public partial class StudentAddForm : Form
    {
        StudentController studentController = new StudentController();
        RoomController roomController = new RoomController();
        GroupController groupController = new GroupController();
        public StudentAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte roomType = new byte();
                if (cbRoomType.SelectedItem.ToString().Split()[0] == "Двойка")
                    roomType = 1;
                if (cbRoomType.SelectedItem.ToString().Split()[0] == "Тройка")
                    roomType = 0;
                studentController.AddStudent(new Student
                {
                    Envicted = 0,
                    Inhabited = 0,
                    GroupName = cbGroup.SelectedItem.ToString(),
                    GroupNumber = int.Parse(txtNumberGroup.Text),
                    Room = cbStage.SelectedItem.ToString()+"-"+cbRoom.SelectedItem.ToString().Split()[0],
                    StudentName = txtStudentName.Text,
                    RoomType = roomType
                });
            }
            catch(Exception ex)
            {
                Log.WriteLog(ex.Message);
            }
            this.Close();
        }

        private void StudentAddForm_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            cbRoomType.Items.Clear();
            var result = roomController.RoomSearch(int.Parse(cbStage.SelectedItem.ToString()));
            foreach (Room room in result)
            {
                if (roomController.StudentInRoomSearch(room) - 5 != 0)
                { cbRoom.Items.Add(room.Number + " (Свободных мест - "+(5 - roomController.StudentInRoomSearch(room))+")"); }
            };
           
        }

        private void cbGroup_Enter(object sender, EventArgs e)
        {
            cbGroup.Items.Clear();
            var result = groupController.GetAllGroups();
            if (result.Count() > 1)
            {
                foreach(var item in result)
                {
                    cbGroup.Items.Add(item.GroupName);
                }
            }
        }

        private void cbRoomType_Enter(object sender, EventArgs e)
        {
            if (cbRoom.SelectedItem != null)
            {
                cbRoomType.Items.Clear();
                int dvoika = roomController.StudentCountFor2(new Room
                {
                    Stage = int.Parse(cbStage.SelectedItem.ToString()),
                    Number = int.Parse(cbRoom.SelectedItem.ToString().Split()[0])
                });
                int troika = roomController.StudentCountFor3(new Room
                {
                    Stage = int.Parse(cbStage.SelectedItem.ToString()),
                    Number = int.Parse(cbRoom.SelectedItem.ToString().Split()[0])
                });

                if (2 - dvoika != 0)
                    cbRoomType.Items.Add(string.Format("Двойка (свободно: {0})", 2 - dvoika));
                if (3 - troika != 0)
                    cbRoomType.Items.Add(string.Format("Тройка (свободно: {0})", 3 - troika));
            }
        }
    }
}
