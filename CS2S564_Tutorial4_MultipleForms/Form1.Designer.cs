namespace CS2S564_Tutorial4_MultipleForms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowSecondForm = new System.Windows.Forms.Button();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowSecondForm
            // 
            this.btnShowSecondForm.Location = new System.Drawing.Point(12, 41);
            this.btnShowSecondForm.Name = "btnShowSecondForm";
            this.btnShowSecondForm.Size = new System.Drawing.Size(198, 23);
            this.btnShowSecondForm.TabIndex = 0;
            this.btnShowSecondForm.Text = "Show Second Form";
            this.btnShowSecondForm.UseVisualStyleBackColor = true;
            this.btnShowSecondForm.Click += new System.EventHandler(this.btnShowSecondForm_Click);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(12, 12);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(198, 23);
            this.txtTextBox.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 78);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.btnShowSecondForm);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnShowSecondForm;
        private TextBox txtTextBox;
    }
}