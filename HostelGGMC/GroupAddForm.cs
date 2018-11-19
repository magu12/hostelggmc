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
    public partial class GroupAddForm : Form
    {
        GroupController groupController = new GroupController();
        public GroupAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupController.AddGroup(new Group { GroupName = textBox1.Text, Courses = int.Parse(textBox2.Text) });
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }
    }
}
