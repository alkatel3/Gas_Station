namespace GasStation
{
    partial class ChooseWho
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
        override protected void InitializeComponent()
        {
            base.InitializeComponent();
            this.buttonOwnerOrFounder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            //buttonNext
            //
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            //
            //buttonCansel
            //
            this.buttonCansel.Click += new System.EventHandler(ChooseWho_Load);
            // 
            // buttonOwnerOrFounder
            // 
            this.buttonOwnerOrFounder.BackColor = System.Drawing.Color.Lime;
            this.buttonOwnerOrFounder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOwnerOrFounder.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOwnerOrFounder.Location = new System.Drawing.Point(0, 240);
            this.buttonOwnerOrFounder.Name = "buttonOwnerOrFounder";
            this.buttonOwnerOrFounder.Size = new System.Drawing.Size(800, 114);
            this.buttonOwnerOrFounder.TabIndex = 3;
            this.buttonOwnerOrFounder.Text = "Owner or founder";
            this.buttonOwnerOrFounder.UseVisualStyleBackColor = false;
            this.buttonOwnerOrFounder.Click += new System.EventHandler(this.buttonOwnerOrFounder_Click);
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "Provider";
            this.button1.Text = "Provider";
            this.button1.Click += new System.EventHandler(this.buttonProvider_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "Client";
            this.button2.Text = "Client";
            this.button2.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // ChooseWho
            // 
            this.Controls.Add(this.buttonOwnerOrFounder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCansel);
            this.Name = "ChooseWho";
            this.Text = "Gas Station";
            //this.Load += new System.EventHandler(this.ChooseWho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button buttonOwnerOrFounder;
    }
}

