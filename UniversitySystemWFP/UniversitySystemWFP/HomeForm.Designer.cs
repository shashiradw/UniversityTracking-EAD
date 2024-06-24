namespace UniversitySystemWFP
{
    partial class HomeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_studentID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stuID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_generate_report = new System.Windows.Forms.Button();
            this.btn_manage_session = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_day_activities = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_recurring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.cb_view = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_day_activities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1192, 769);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_studentID
            // 
            this.lbl_studentID.AutoSize = true;
            this.lbl_studentID.Location = new System.Drawing.Point(52, 41);
            this.lbl_studentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_studentID.Name = "lbl_studentID";
            this.lbl_studentID.Size = new System.Drawing.Size(45, 16);
            this.lbl_studentID.TabIndex = 1;
            this.lbl_studentID.Text = "Stu. ID";
            this.lbl_studentID.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.link_logout);
            this.groupBox1.Controls.Add(this.txt_student_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_stuID);
            this.groupBox1.Controls.Add(this.lbl_studentID);
            this.groupBox1.Location = new System.Drawing.Point(56, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1307, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student details:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.Location = new System.Drawing.Point(1187, 40);
            this.link_logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(48, 16);
            this.link_logout.TabIndex = 4;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "Logout";
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // txt_student_name
            // 
            this.txt_student_name.Location = new System.Drawing.Point(579, 37);
            this.txt_student_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(324, 22);
            this.txt_student_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name:";
            // 
            // txt_stuID
            // 
            this.txt_stuID.Location = new System.Drawing.Point(137, 37);
            this.txt_stuID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stuID.Name = "txt_stuID";
            this.txt_stuID.Size = new System.Drawing.Size(212, 22);
            this.txt_stuID.TabIndex = 2;
            this.txt_stuID.TextChanged += new System.EventHandler(this.txt_stuID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btn_generate_report);
            this.panel1.Controls.Add(this.btn_manage_session);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1047, 184);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 535);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(44, 393);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(272, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "Predict future";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 306);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Predict future";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 220);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 52);
            this.button5.TabIndex = 3;
            this.button5.Text = "Knowledge Assessment";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_generate_report
            // 
            this.btn_generate_report.Location = new System.Drawing.Point(44, 138);
            this.btn_generate_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generate_report.Name = "btn_generate_report";
            this.btn_generate_report.Size = new System.Drawing.Size(272, 52);
            this.btn_generate_report.TabIndex = 2;
            this.btn_generate_report.Text = "Generate Report";
            this.btn_generate_report.UseVisualStyleBackColor = true;
            this.btn_generate_report.Click += new System.EventHandler(this.btn_generate_report_Click);
            // 
            // btn_manage_session
            // 
            this.btn_manage_session.Location = new System.Drawing.Point(44, 56);
            this.btn_manage_session.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manage_session.Name = "btn_manage_session";
            this.btn_manage_session.Size = new System.Drawing.Size(272, 52);
            this.btn_manage_session.TabIndex = 1;
            this.btn_manage_session.Text = "Manage Session";
            this.btn_manage_session.UseVisualStyleBackColor = true;
            this.btn_manage_session.Click += new System.EventHandler(this.btn_manage_session_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Action Panel:";
            // 
            // gb_day_activities
            // 
            this.gb_day_activities.Controls.Add(this.cb_view);
            this.gb_day_activities.Controls.Add(this.label5);
            this.gb_day_activities.Controls.Add(this.label4);
            this.gb_day_activities.Controls.Add(this.cb_subject);
            this.gb_day_activities.Controls.Add(this.dataGridView2);
            this.gb_day_activities.Controls.Add(this.dataGridView1);
            this.gb_day_activities.Controls.Add(this.dtp_start);
            this.gb_day_activities.Controls.Add(this.label3);
            this.gb_day_activities.Location = new System.Drawing.Point(56, 160);
            this.gb_day_activities.Margin = new System.Windows.Forms.Padding(4);
            this.gb_day_activities.Name = "gb_day_activities";
            this.gb_day_activities.Padding = new System.Windows.Forms.Padding(4);
            this.gb_day_activities.Size = new System.Drawing.Size(971, 596);
            this.gb_day_activities.TabIndex = 4;
            this.gb_day_activities.TabStop = false;
            this.gb_day_activities.Text = "Weekly View";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subject:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cb_subject
            // 
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Location = new System.Drawing.Point(357, 24);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(195, 24);
            this.cb_subject.TabIndex = 9;
            this.cb_subject.SelectedIndexChanged += new System.EventHandler(this.cb_subject_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_date,
            this.col_id,
            this.col_start_time,
            this.col_end_time,
            this.col_recurring});
            this.dataGridView2.Location = new System.Drawing.Point(32, 122);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(884, 428);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(554, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 7;
            // 
            // col_date
            // 
            this.col_date.HeaderText = "Date";
            this.col_date.MinimumWidth = 6;
            this.col_date.Name = "col_date";
            this.col_date.Width = 125;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_id.Width = 125;
            // 
            // col_start_time
            // 
            this.col_start_time.HeaderText = "start_time";
            this.col_start_time.MinimumWidth = 6;
            this.col_start_time.Name = "col_start_time";
            this.col_start_time.Width = 125;
            // 
            // col_end_time
            // 
            this.col_end_time.HeaderText = "end_time";
            this.col_end_time.MinimumWidth = 6;
            this.col_end_time.Name = "col_end_time";
            this.col_end_time.Width = 125;
            // 
            // col_recurring
            // 
            this.col_recurring.HeaderText = "Recurring";
            this.col_recurring.MinimumWidth = 6;
            this.col_recurring.Name = "col_recurring";
            this.col_recurring.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Starts:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(510, 81);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(285, 22);
            this.dtp_start.TabIndex = 3;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // cb_view
            // 
            this.cb_view.FormattingEnabled = true;
            this.cb_view.Items.AddRange(new object[] {
            "Weekly",
            "Day"});
            this.cb_view.Location = new System.Drawing.Point(186, 78);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(195, 24);
            this.cb_view.TabIndex = 14;
            this.cb_view.SelectedIndexChanged += new System.EventHandler(this.cb_view_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "View:";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 825);
            this.Controls.Add(this.gb_day_activities);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_day_activities.ResumeLayout(false);
            this.gb_day_activities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_studentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_student_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stuID;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generate_report;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gb_day_activities;
        private System.Windows.Forms.Button btn_manage_session;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_recurring;
        private System.Windows.Forms.ComboBox cb_view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label3;
    }
}

