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
    public partial class RoomForm : Form
    {
        RoomController roomController = new RoomController();
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            var result = roomController.GetAllRooms();
            dgRoom.Rows.Clear();
            foreach (Room group in result) { dgRoom.Rows.Add(group.Id, group.Stage, group.Number); }
        }

        private void dgGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RoomAddForm roomAddForm = new RoomAddForm();
                roomAddForm.ShowDialog();
                RoomForm_Load(sender, e);

            }
            if (e.KeyCode == Keys.Delete && dgRoom.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Потвердите удаление.", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    roomController.DeleteRoom(int.Parse(dgRoom[0, dgRoom.SelectedRows[0].Index].Value.ToString()));
                    RoomForm_Load(sender, e);
                }

            }
        }

        private void RoomForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ShowBaseMenu showBaseMenu = new ShowBaseMenu();
            showBaseMenu.Show();
        }
    }
}
