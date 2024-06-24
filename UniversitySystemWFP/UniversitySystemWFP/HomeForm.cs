using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UniversitySystem.core.Model;
using UniversitySystem.core.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversitySystemWFP
{

    public partial class HomeForm : Form
    {
        private BindingSource studentBindingSource = new BindingSource();
        private ISubjectService subjectService;
        private Student m_student;
        private Subject m_selectedSubject;

    
        Session session = new Session
        {
            id = 1,
            date = DateTime.Today,
            start_time = DateTime.Today.AddHours(9),
            end_time = DateTime.Today.AddHours(12),
            isRecurring = false,
            breaks = new List<Break>
            {
                new Break
                {
                    id = 1,
                    date = DateTime.Today,
                    start_time = DateTime.Today.AddHours(10),
                    end_time = DateTime.Today.AddHours(10).AddMinutes(30),
                    isRecurring = false
                },
                new Break
                {
                    id = 2,
                    date = DateTime.Today,
                    start_time = DateTime.Today.AddHours(11),
                    end_time = DateTime.Today.AddHours(11).AddMinutes(30),
                    isRecurring = false
                }
            }
        };

        Session session2 = new Session
        {
            id = 2,
            date = DateTime.Today,
            start_time = DateTime.Today.AddHours(5),
            end_time = DateTime.Today.AddHours(6),
            isRecurring = false,
            breaks = new List<Break>
            {
                new Break
                {
                    id = 1,
                    date = DateTime.Today,
                    start_time = DateTime.Today.AddHours(10),
                    end_time = DateTime.Today.AddHours(10).AddMinutes(30),
                    isRecurring = false
                }
            }
        };

        List<Session> sessions = new List<Session>();
        List<Session> sessions2 = new List<Session>();

        public HomeForm(Student student)
        {
            InitializeComponent();
            m_student = student;
            studentBindingSource.DataSource = m_student;
            subjectService= new SubjectService();

            // Add data
            sessions.Add(session);
            sessions2.Add(session2);

            Subject sub1 = new Subject
            {
                name = "Maths",
                sessions = sessions,
                assessment = new List<KnowledgeAssessment>(),
                student = m_student
            };

            Subject sub2 = new Subject
            {
                name = "Science",
                sessions = sessions2,
                assessment = new List<KnowledgeAssessment>(),
                student = m_student
            };

            m_student.subjects.Add(sub1);
            m_student.subjects.Add(sub2);

            //set default 'weekly' to the combo view
            cb_view.SelectedIndex = 0;

            //Bind date to the form
            txt_stuID.DataBindings.Add("Text", studentBindingSource, "stu_id");
            txt_student_name.DataBindings.Add("Text", studentBindingSource, "name");

            //Temp
            
            cb_subject.DataSource = m_student.subjects;
            cb_subject.DisplayMember = "name";
            cb_subject.SelectedIndex = 0;
            m_selectedSubject = m_student.subjects[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            m_student = null;
        }

        private void btn_manage_session_Click(object sender, EventArgs e)
        {
            Hide();
            ManageSession manage_session_page = new ManageSession(m_student);
            manage_session_page.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_generate_report_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_stuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_DataBind(List<Session> sessions)
        {
            dataGridView2.Rows.Clear();

            // Bind StudySessions to DataGridView
            foreach (var session in sessions)
            {
                int rowIndex = dataGridView2.Rows.Add(
                    session.id,
                    session.date.ToShortDateString(),
                    session.start_time.ToString("hh:mm tt"),
                    session.end_time.ToString("hh:mm tt"),
                    session.isRecurring ? "Yes" : "No"
                );

                // Add break sessions as child rows (expandable)
                foreach (var breakSession in session.breaks)
                {
                    dataGridView2.Rows.Add(
                        "",
                        breakSession.date.ToShortDateString(),
                        breakSession.start_time.ToString("hh:mm tt"),
                        breakSession.end_time.ToString("hh:mm tt"),
                        breakSession.isRecurring ? "Yes" : "No"
                    );

                    // Set the DataGridViewRow hierarchy
                    dataGridView2.Rows[rowIndex].Cells[0].Value = session.id.ToString();
                    dataGridView2.Rows[rowIndex].Tag = session.breaks; // Tag can be used to store additional data
                }
            }
        }

        private void loadGrid_DataChanges()
        {
            if (subjectService == null || m_selectedSubject == null) return;

            string selected_view = cb_view.Text;
            DateTime selected_start_date = dtp_start.Value.Date;

            List<Session> filteredSessions = subjectService.filterSubjectByDate(m_selectedSubject, selected_start_date, selected_view);
            DataGrid_DataBind(filteredSessions);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadGrid_DataChanges();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void searchAndViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load the table data upon sub changes
            if (cb_subject.SelectedItem is Subject selectedSubject)
            {
                m_selectedSubject = (Subject)cb_subject.SelectedItem;
                loadGrid_DataChanges();
            }
        }

        private void cb_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGrid_DataChanges();
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            loadGrid_DataChanges(); 
        }
    }
}
