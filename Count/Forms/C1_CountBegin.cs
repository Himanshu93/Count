using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count.Forms
{
    public partial class C1_CountBegin : Form
    {
        public C1_CountBegin()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            C1_2_CreateCompany createCompany = new C1_2_CreateCompany();
            createCompany.Show();
            this.Hide();
        }

        private void C1_CountBegin_Load(object sender, EventArgs e)
        {

        }
    }
}
