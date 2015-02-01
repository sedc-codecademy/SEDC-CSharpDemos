using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLibrary;

namespace DemoForms
{
    public partial class MyMainForm : Form
    {
        public MyMainForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = HelloWorlder.GetHelloWorld();
        }
    }
}
