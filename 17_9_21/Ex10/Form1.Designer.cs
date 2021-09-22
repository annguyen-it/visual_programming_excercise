
namespace Ex10
{
    partial class QuizForm
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
        private void InitializeComponent()
        {
            this.grbCountry = new System.Windows.Forms.GroupBox();
            this.grbCapital = new System.Windows.Forms.GroupBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grbCountry
            // 
            this.grbCountry.Location = new System.Drawing.Point(31, 26);
            this.grbCountry.Name = "grbCountry";
            this.grbCountry.Size = new System.Drawing.Size(200, 100);
            this.grbCountry.TabIndex = 0;
            this.grbCountry.TabStop = false;
            this.grbCountry.Text = "Country";
            // 
            // grbCapital
            // 
            this.grbCapital.Location = new System.Drawing.Point(299, 26);
            this.grbCapital.Name = "grbCapital";
            this.grbCapital.Size = new System.Drawing.Size(200, 100);
            this.grbCapital.TabIndex = 0;
            this.grbCapital.TabStop = false;
            this.grbCapital.Text = "Capital";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(28, 146);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 17);
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 196);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.grbCapital);
            this.Controls.Add(this.grbCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCountry;
        private System.Windows.Forms.GroupBox grbCapital;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnExit;
    }
}

