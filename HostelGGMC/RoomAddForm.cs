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
    public partial class RoomAddForm : Form
    {
        RoomController roomController = new RoomController();
        public RoomAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomController.AddRoom(new Room { Stage = int.Parse(textBox1.Text), Number = int.Parse(textBox2.Text) });
            this.Close();
        }
    }
}
