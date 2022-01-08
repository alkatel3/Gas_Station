
namespace GasStation
{
    partial class Provider
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Text = "                                                           Choose Station";
            // 
            // label2
            // 
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Text = "Name                                          Can buy fuel                                     Can give you price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "How many fuel do you want to sell (L)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 325);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(800, 40);
            this.textBox3.TabIndex = 16;
            //
            //buttonNext
            //
            this.buttonNext.Click += new System.EventHandler(Next);
            //
            //buttonBack
            //
            this.buttonBack.Click += new System.EventHandler(buttonBack_Click);
            //
            //buttonCansel
            //
            this.buttonCansel.Click += new System.EventHandler(buttonCansel_Click);
            //
            // ChooseGasStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(BaseForm.listBox2);
            this.Name = "ChooseGasStation";
            this.Text = "ChooseGasStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;

        #endregion
    }
}