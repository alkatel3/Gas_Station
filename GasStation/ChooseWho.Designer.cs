
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
        virtual protected void InitializeComponent()
        {
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonOwnerOrFounder = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonProvider = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNext.Location = new System.Drawing.Point(650, 366);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(150, 73);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCasnsel
            // 
            this.buttonCansel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCansel.Location = new System.Drawing.Point(338, 366);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(150, 73);
            this.buttonCansel.TabIndex = 2;
            this.buttonCansel.Text = "Cansel";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
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
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.Lime;
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClient.Location = new System.Drawing.Point(0, 120);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(800, 120);
            this.buttonClient.TabIndex = 4;
            this.buttonClient.Text = "Сlient";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonProvider
            // 
            this.buttonProvider.BackColor = System.Drawing.Color.Lime;
            this.buttonProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProvider.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProvider.Location = new System.Drawing.Point(0, 0);
            this.buttonProvider.Name = "buttonProvider";
            this.buttonProvider.Size = new System.Drawing.Size(800, 120);
            this.buttonProvider.TabIndex = 5;
            this.buttonProvider.Text = "Provider";
            this.buttonProvider.UseVisualStyleBackColor = false;
            this.buttonProvider.Click += new System.EventHandler(this.buttonProvider_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SlateGray;
            this.buttonBack.Location = new System.Drawing.Point(494, 365);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 73);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // ChooseWho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOwnerOrFounder);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonProvider);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonNext);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "ChooseWho";
            this.Text = "Gas Station";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button buttonNext;
        protected System.Windows.Forms.Button buttonCansel;
        protected System.Windows.Forms.Button buttonOwnerOrFounder;
        protected System.Windows.Forms.Button buttonClient;
        protected System.Windows.Forms.Button buttonProvider;
        protected System.Windows.Forms.Button buttonBack;
    }
}

