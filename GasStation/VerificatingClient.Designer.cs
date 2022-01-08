
namespace GasStation
{
    partial class VerificatingClient
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
        protected override void InitializeComponent()
        {
            base.InitializeComponent();

            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.Text = "Input name your account";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.Text = "Input password your account";
            // 
            // buttonNext
            // 
            this.buttonNext.Name = "Next";
            this.buttonNext.Text = "Next";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_cl);


            // 
            // buttonCansel
            // 
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CreatingAccount
            // 
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatingAccount";
            this.Text = "Creating account"; ;
        }

        #endregion
    }
}