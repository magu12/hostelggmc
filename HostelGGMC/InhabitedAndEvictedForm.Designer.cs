namespace HostelGGMC
{
    partial class InhabitedAndEvictedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStage = new System.Windows.Forms.ComboBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDefault = new System.Windows.Forms.LinkLabel();
            this.buttonInhabired = new System.Windows.Forms.Button();
            this.buttonEndStudyYear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbEvited = new System.Windows.Forms.CheckBox();
            this.cbNotInhabited = new System.Windows.Forms.CheckBox();
            this.cbInhabited = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbGroupNomber = new System.Windows.Forms.TextBox();
            this.cbGroupName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEvicted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStudent
            // 
            this.dgStudent.AllowUserToAddRows = false;
            this.dgStudent.AllowUserToDeleteRows = false;
            this.dgStudent.AllowUserToResizeColumns = false;
            this.dgStudent.AllowUserToResizeRows = false;
            this.dgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.dgStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgStudent.Location = new System.Drawing.Point(0, 0);
            this.dgStudent.MultiSelect = false;
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.RowHeadersVisible = false;
            this.dgStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudent.Size = new System.Drawing.Size(827, 450);
            this.dgStudent.TabIndex = 3;
            this.dgStudent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgStudent_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Блок";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Заселённый";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Выселенный";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Группа";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Номер группы";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Тип комнаты";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // cbStage
            // 
            this.cbStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStage.FormattingEnabled = true;
            this.cbStage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbStage.Location = new System.Drawing.Point(6, 33);
            this.cbStage.Name = "cbStage";
            this.cbStage.Size = new System.Drawing.Size(108, 21);
            this.cbStage.TabIndex = 4;
            this.cbStage.SelectedIndexChanged += new System.EventHandler(this.cbStage_SelectedIndexChanged);
            this.cbStage.Enter += new System.EventHandler(this.cbStage_Enter);
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(120, 33);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(102, 21);
            this.cbRoom.TabIndex = 5;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            this.cbRoom.Enter += new System.EventHandler(this.cbRoom_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Этаж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Комната";
            // 
            // lbDefault
            // 
            this.lbDefault.AutoSize = true;
            this.lbDefault.Location = new System.Drawing.Point(96, 313);
            this.lbDefault.Name = "lbDefault";
            this.lbDefault.Size = new System.Drawing.Size(55, 13);
            this.lbDefault.TabIndex = 8;
            this.lbDefault.TabStop = true;
            this.lbDefault.Text = "Сбросить";
            this.lbDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonInhabired
            // 
            this.buttonInhabired.Location = new System.Drawing.Point(833, 357);
            this.buttonInhabired.Name = "buttonInhabired";
            this.buttonInhabired.Size = new System.Drawing.Size(240, 23);
            this.buttonInhabired.TabIndex = 9;
            this.buttonInhabired.Text = "Заселить";
            this.buttonInhabired.UseVisualStyleBackColor = true;
            this.buttonInhabired.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEndStudyYear
            // 
            this.buttonEndStudyYear.Location = new System.Drawing.Point(833, 415);
            this.buttonEndStudyYear.Name = "buttonEndStudyYear";
            this.buttonEndStudyYear.Size = new System.Drawing.Size(240, 23);
            this.buttonEndStudyYear.TabIndex = 10;
            this.buttonEndStudyYear.Text = "Конец учебного года";
            this.buttonEndStudyYear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbDefault);
            this.groupBox1.Location = new System.Drawing.Point(833, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 339);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbEvited);
            this.groupBox5.Controls.Add(this.cbNotInhabited);
            this.groupBox5.Controls.Add(this.cbInhabited);
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 71);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Заселён/не заселён, выселен:";
            // 
            // cbEvited
            // 
            this.cbEvited.AutoSize = true;
            this.cbEvited.Location = new System.Drawing.Point(74, 42);
            this.cbEvited.Name = "cbEvited";
            this.cbEvited.Size = new System.Drawing.Size(71, 17);
            this.cbEvited.TabIndex = 2;
            this.cbEvited.Text = "Выселен";
            this.cbEvited.UseVisualStyleBackColor = true;
            this.cbEvited.CheckedChanged += new System.EventHandler(this.cbEvited_CheckedChanged);
            // 
            // cbNotInhabited
            // 
            this.cbNotInhabited.AutoSize = true;
            this.cbNotInhabited.Location = new System.Drawing.Point(142, 19);
            this.cbNotInhabited.Name = "cbNotInhabited";
            this.cbNotInhabited.Size = new System.Drawing.Size(85, 17);
            this.cbNotInhabited.TabIndex = 1;
            this.cbNotInhabited.Text = "Не заселён";
            this.cbNotInhabited.UseVisualStyleBackColor = true;
            this.cbNotInhabited.CheckedChanged += new System.EventHandler(this.cbNotInhabited_CheckedChanged);
            // 
            // cbInhabited
            // 
            this.cbInhabited.AutoSize = true;
            this.cbInhabited.Location = new System.Drawing.Point(6, 19);
            this.cbInhabited.Name = "cbInhabited";
            this.cbInhabited.Size = new System.Drawing.Size(69, 17);
            this.cbInhabited.TabIndex = 0;
            this.cbInhabited.Text = "Заселён";
            this.cbInhabited.UseVisualStyleBackColor = true;
            this.cbInhabited.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbGroupNomber);
            this.groupBox4.Controls.Add(this.cbGroupName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 65);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "По группе и(или) курсу:";
            // 
            // tbGroupNomber
            // 
            this.tbGroupNomber.Location = new System.Drawing.Point(122, 33);
            this.tbGroupNomber.Name = "tbGroupNomber";
            this.tbGroupNomber.Size = new System.Drawing.Size(100, 20);
            this.tbGroupNomber.TabIndex = 11;
            this.tbGroupNomber.TextChanged += new System.EventHandler(this.tbGroupNomber_TextChanged);
            // 
            // cbGroupName
            // 
            this.cbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupName.FormattingEnabled = true;
            this.cbGroupName.Items.AddRange(new object[] {
            "ПК",
            "ПСК",
            "ЭК",
            "ЛЧС",
            "ТОС",
            "ТОМ"});
            this.cbGroupName.Location = new System.Drawing.Point(6, 32);
            this.cbGroupName.Name = "cbGroupName";
            this.cbGroupName.Size = new System.Drawing.Size(108, 21);
            this.cbGroupName.TabIndex = 8;
            this.cbGroupName.SelectedIndexChanged += new System.EventHandler(this.cbGroupName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер группы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbStudent);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "По личным атрибутам студента:";
            // 
            // tbStudent
            // 
            this.tbStudent.Location = new System.Drawing.Point(6, 37);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.Size = new System.Drawing.Size(216, 20);
            this.tbStudent.TabIndex = 10;
            this.tbStudent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStudent_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ФИО:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbRoom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "По этажу и блоку:";
            // 
            // buttonEvicted
            // 
            this.buttonEvicted.Location = new System.Drawing.Point(833, 386);
            this.buttonEvicted.Name = "buttonEvicted";
            this.buttonEvicted.Size = new System.Drawing.Size(240, 23);
            this.buttonEvicted.TabIndex = 13;
            this.buttonEvicted.Text = "Выселить";
            this.buttonEvicted.UseVisualStyleBackColor = true;
            this.buttonEvicted.Click += new System.EventHandler(this.buttonEvicted_Click);
            // 
            // InhabitedAndEvictedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.buttonEvicted);
            this.Controls.Add(this.buttonInhabired);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEndStudyYear);
            this.Controls.Add(this.dgStudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InhabitedAndEvictedForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заселение и выселение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InhabitedAndEvictedForm_FormClosing);
            this.Load += new System.EventHandler(this.InhabitedAndEvictedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.ComboBox cbStage;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbDefault;
        private System.Windows.Forms.Button buttonInhabired;
        private System.Windows.Forms.Button buttonEndStudyYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEvicted;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbEvited;
        private System.Windows.Forms.CheckBox cbNotInhabited;
        private System.Windows.Forms.CheckBox cbInhabited;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox tbGroupNomber;
        private System.Windows.Forms.ComboBox cbGroupName;
        private System.Windows.Forms.Label label6;
    }
}