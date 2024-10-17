namespace CS2S564_Tutorial4_MultipleForms
{
    public partial class frmMain : Form
    {
        public static string initialVariable = "Hello MultiForms";
        public frmMain()
        {
            InitializeComponent();
        }

        //public method for call back when form 2 is closed
        public void updateString(string concat)
        {
            txtTextBox.Text = concat;
        }

        private void btnShowSecondForm_Click(object sender, EventArgs e)
        {
            //option 1 - pass string in constructor
            frm2 secondForm = new frm2(initialVariable);

            //option 2 - pass string after using setter
            //frm2 secondForm = new frm2();
            //secondForm.setText(initialVariable);

            //option 3 - use modifier to change text
            //secondForm.txtBox1.Text = initialVariable;

            //set the owner so that we can call back
            secondForm.Owner = this;
            secondForm.ShowDialog();
        }
    }
}