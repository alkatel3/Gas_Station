
namespace GasStation
{
    partial class OwenrOrFounderMenu
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Size = new System.Drawing.Size(656, 59);
            this.label1.Text = "             Do you have gas station?";
            // 
            // buttonYes
            // 
            this.button1.Location = new System.Drawing.Point(0, 59);
            this.button1.Name = "buttonYes";
            this.button1.Text = "Yes";
            this.button1.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.button2.Location = new System.Drawing.Point(0, 179);
            this.button2.Name = "buttonNo";
            this.button2.Text = "No";
            this.button2.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // OwenrOrFounderMenu
            // 
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "OwenrOrFounderMenu";
            this.Text = "Owner or founder menu";
        }

        #endregion
    }
}