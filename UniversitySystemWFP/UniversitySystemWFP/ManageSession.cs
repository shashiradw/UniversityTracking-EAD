using System;
using UniversitySystem.core.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystemWFP
{
    public partial class ManageSession : Form
    {
        BindingSource sessionListBidningSource = new BindingSource();
        BindingSource breakListBindingSource = new BindingSource();

        BindingList<Session> sessionBindingList;
        BindingList<Break> breakBindingList;

        //private List<Session> sessions;
        // private List<Break> breaks;

        public ManageSession(Student student)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            SessionAddEditForm sessionAddEditForm = new SessionAddEditForm(new Session());
            sessionAddEditForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            SessionAddEditForm sessionAddEditForm = new SessionAddEditForm(new Session());
            sessionAddEditForm.ShowDialog();
        }

        private void ManageSession_Load(object sender, EventArgs e)
        {
            sessionBindingList = new BindingList<Session>();
            breakBindingList = new BindingList<Break>();

            sessionListBidningSource.DataSource = sessionBindingList;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
