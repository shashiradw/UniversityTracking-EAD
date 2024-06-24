namespace UniversitySystemWFP
{
    partial class SessionAddEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sessionid = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_start_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_time = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rb_recurring = new System.Windows.Forms.RadioButton();
            this.rb_oneoff = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dtp_end_time);
            this.groupBox1.Controls.Add(this.dtp_start_time);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.tb_sessionid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Session ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recurring or One off :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            // 
            // tb_sessionid
            // 
            this.tb_sessionid.Location = new System.Drawing.Point(205, 87);
            this.tb_sessionid.Name = "tb_sessionid";
            this.tb_sessionid.ReadOnly = true;
            this.tb_sessionid.Size = new System.Drawing.Size(236, 22);
            this.tb_sessionid.TabIndex = 5;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(205, 133);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(236, 22);
            this.dtp_date.TabIndex = 6;
            // 
            // dtp_start_time
            // 
            this.dtp_start_time.Location = new System.Drawing.Point(205, 174);
            this.dtp_start_time.Name = "dtp_start_time";
            this.dtp_start_time.Size = new System.Drawing.Size(236, 22);
            this.dtp_start_time.TabIndex = 7;
            // 
            // dtp_end_time
            // 
            this.dtp_end_time.Location = new System.Drawing.Point(205, 225);
            this.dtp_end_time.Name = "dtp_end_time";
            this.dtp_end_time.Size = new System.Drawing.Size(236, 22);
            this.dtp_end_time.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_oneoff);
            this.panel1.Controls.Add(this.rb_recurring);
            this.panel1.Location = new System.Drawing.Point(205, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 32);
            this.panel1.TabIndex = 9;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(328, 433);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(428, 433);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // rb_recurring
            // 
            this.rb_recurring.AutoSize = true;
            this.rb_recurring.Location = new System.Drawing.Point(15, 7);
            this.rb_recurring.Name = "rb_recurring";
            this.rb_recurring.Size = new System.Drawing.Size(86, 20);
            this.rb_recurring.TabIndex = 10;
            this.rb_recurring.Text = "Recurring";
            this.rb_recurring.UseVisualStyleBackColor = true;
            this.rb_recurring.CheckedChanged += new System.EventHandler(this.rb_recurring_CheckedChanged);
            // 
            // rb_oneoff
            // 
            this.rb_oneoff.AutoSize = true;
            this.rb_oneoff.Checked = true;
            this.rb_oneoff.Location = new System.Drawing.Point(115, 6);
            this.rb_oneoff.Name = "rb_oneoff";
            this.rb_oneoff.Size = new System.Drawing.Size(71, 20);
            this.rb_oneoff.TabIndex = 11;
            this.rb_oneoff.TabStop = true;
            this.rb_oneoff.Text = "One-off";
            this.rb_oneoff.UseVisualStyleBackColor = true;
            // 
            // SessionAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 485);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_submit);
            this.Name = "SessionAddEditForm";
            this.Text = "SessionAddEditForm";
            this.Load += new System.EventHandler(this.SessionAddEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_end_time;
        private System.Windows.Forms.DateTimePicker dtp_start_time;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox tb_sessionid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton rb_recurring;
        private System.Windows.Forms.RadioButton rb_oneoff;
    }
}