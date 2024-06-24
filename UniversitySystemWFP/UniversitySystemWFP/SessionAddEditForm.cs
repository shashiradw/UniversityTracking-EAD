using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.core.Model;

namespace UniversitySystemWFP
{
    public partial class SessionAddEditForm : Form
    {
        private BindingSource studySessionBindingSource = new BindingSource();
        private Session m_session;

        public SessionAddEditForm(Session session)
        {
            InitializeComponent();
            m_session = session;
            if (m_session == null){
                m_session = new Session();
            }

            //Disable past days
            dtp_date.MinDate = DateTime.Now;

            // Configure start time
            dtp_start_time.Format = DateTimePickerFormat.Time;
            dtp_start_time.ShowUpDown = true;
            dtp_start_time.MinDate = DateTime.Now;

            //Configure end time
            dtp_end_time.Format = DateTimePickerFormat.Time;
            dtp_end_time.ShowUpDown = true;
            dtp_end_time.MinDate = DateTime.Now;

            // Add event handlers for ValueChanged event
            dtp_start_time.ValueChanged += new EventHandler(dtp_start_time_ValueChanged);
            dtp_end_time.ValueChanged += new EventHandler(dtp_end_time_ValueChanged);

            studySessionBindingSource.DataSource = m_session;

            // Data binding
            dtp_date.DataBindings.Add("Value", studySessionBindingSource, "date", true, DataSourceUpdateMode.OnPropertyChanged);
            dtp_start_time.DataBindings.Add("Value", studySessionBindingSource, "start_time", true, DataSourceUpdateMode.OnPropertyChanged);
            dtp_end_time.DataBindings.Add("Value", studySessionBindingSource, "end_time", true, DataSourceUpdateMode.OnPropertyChanged);
            rb_recurring.DataBindings.Add("Checked", studySessionBindingSource, "isRecurring", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_session.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SessionAddEditForm_Load(object sender, EventArgs e)
        {

            //studySessionBindingSource.ResetBindings(false);
            dtp_date.DataBindings["Value"].WriteValue();
            dtp_start_time.DataBindings["Value"].WriteValue();
            dtp_end_time.DataBindings["Value"].WriteValue();
            rb_recurring.DataBindings["Checked"].WriteValue();

        }

        private void rb_recurring_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_recurring.Checked) return;

            MessageBox.Show("Message box clicked!");
        }

        private void dtp_start_time_ValueChanged(object sender, EventArgs e)
        {
            // If the user enter start_time later to end_time, This will handle
            if (dtp_end_time.Value.TimeOfDay <= dtp_start_time.Value.TimeOfDay)
            {
                dtp_end_time.Value = dtp_start_time.Value.AddMinutes(1);
            }
        }

        private void dtp_end_time_ValueChanged(object sender, EventArgs e)
        {
            // If the user enter end_time earlier to start_time, This will handle
            if (dtp_end_time.Value.TimeOfDay <= dtp_start_time.Value.TimeOfDay)
            {
                dtp_end_time.Value = dtp_start_time.Value.AddMinutes(5);
            }
        }
    }
}
