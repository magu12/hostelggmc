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
    public partial class GroupForm : Form
    {
        GroupController groupController = new GroupController();
        public GroupForm()
        {
            InitializeComponent();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            var result = groupController.GetAllGroups();
            dgGroup.Rows.Clear();
            foreach (Group group in result) { dgGroup.Rows.Add(group.Id, group.GroupName, group.Courses); }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GroupAddForm groupAddForm = new GroupAddForm();
                groupAddForm.ShowDialog();
                GroupForm_Load(sender, e);

            }
            if (e.KeyCode == Keys.Delete && dgGroup.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Потвердите удаление.", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    groupController.DeleteGroup(int.Parse(dgGroup[0,dgGroup.SelectedRows[0].Index].Value.ToString()));
                    GroupForm_Load(sender, e);
                }
                
            }
        }

        private void GroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ShowBaseMenu showBaseMenu = new ShowBaseMenu();
            showBaseMenu.Show();
        }
    }
}
