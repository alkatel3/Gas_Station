
namespace GasStation
{
    partial class ClientMenu
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
            this.label1.Size = new System.Drawing.Size(677, 59);
            this.label1.Text = "             Do you have gas account?";
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
            //buttonNext
            //
            this.buttonNext.Click += new System.EventHandler(buttonNext_Click);
            //
            //buttonBack
            //
            this.buttonBack.Click += new System.EventHandler(buttonBack_Click);
            //
            //buttonNext
            //
            this.buttonCansel.Click += new System.EventHandler(buttonCansel_Click);
            // 
            // ClientMenu
            // 
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "ClientMenu";
            this.Text = "Client menu";
        }

        #endregion
    }
}