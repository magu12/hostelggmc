using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainLibrary;

namespace HostelGGMC
{
    public partial class MainForm : Form
    {

        GroupController gc = new GroupController();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InhabitedAndEvictedForm inhabitedAndEvictedForm = new InhabitedAndEvictedForm();
            inhabitedAndEvictedForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBaseMenu showBaseMenu = new ShowBaseMenu();
            showBaseMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
