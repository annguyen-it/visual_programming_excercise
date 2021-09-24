
namespace Ex12
{
    partial class Form1
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(70, 51);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(309, 51);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b:";
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(122, 49);
            this.nudA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(120, 22);
            this.nudA.TabIndex = 2;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(361, 49);
            this.nudB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 22);
            this.nudB.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(73, 113);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(408, 160);
            this.txtResult.TabIndex = 4;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(144, 303);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(98, 23);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "Giải PTBN";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(301, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 357);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnExit;
    }
}

