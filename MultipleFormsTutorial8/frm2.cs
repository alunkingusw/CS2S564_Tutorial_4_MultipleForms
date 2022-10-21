using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleFormsTutorial8
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        //option one - pass string as argument
        public frm2(string argument)
        {
            InitializeComponent();
            txtBox1.Text = argument;
        }

        //option two, create a setter to change the textbox
        public void setText(string argument)
        {
            txtBox1.Text = argument;
        }

        //option three, change modifiers to public

        private void frm2_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string concatenation = txtBox1.Text + " " + txtBox2.Text;
            frmMain parent = (frmMain)this.Owner;
            //option 1 - set using a setter
            parent.updateString(concatenation);

            //option 2 - set using modifier
            //parent.txtTextBox.Text = concatenation;

            this.Dispose();
        }
    }
}
