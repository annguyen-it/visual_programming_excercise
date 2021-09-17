
namespace Ex4
{
    partial class frmCalculator
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.grbOperator = new System.Windows.Forms.GroupBox();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.rdoMultiply = new System.Windows.Forms.RadioButton();
            this.rdoMinus = new System.Windows.Forms.RadioButton();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.grbCompare = new System.Windows.Forms.GroupBox();
            this.chkMin = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.grbOperator.SuspendLayout();
            this.grbCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtResult);
            this.grbInput.Controls.Add(this.txtB);
            this.grbInput.Controls.Add(this.txtA);
            this.grbInput.Controls.Add(this.lblResult);
            this.grbInput.Controls.Add(this.lblB);
            this.grbInput.Controls.Add(this.lblA);
            this.grbInput.Location = new System.Drawing.Point(217, 27);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(380, 132);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(158, 100);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(158, 63);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 4;
            this.txtB.TextChanged += new System.EventHandler(this.TriggerResult);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(158, 21);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.TriggerResult);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(69, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Kết quả";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(69, 63);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(58, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Nhập b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(69, 21);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(58, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Nhập a:";
            // 
            // grbOperator
            // 
            this.grbOperator.Controls.Add(this.rdoDivide);
            this.grbOperator.Controls.Add(this.rdoMultiply);
            this.grbOperator.Controls.Add(this.rdoMinus);
            this.grbOperator.Controls.Add(this.rdoAdd);
            this.grbOperator.Location = new System.Drawing.Point(136, 201);
            this.grbOperator.Name = "grbOperator";
            this.grbOperator.Size = new System.Drawing.Size(200, 136);
            this.grbOperator.TabIndex = 1;
            this.grbOperator.TabStop = false;
            this.grbOperator.Text = "Phép tính";
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Location = new System.Drawing.Point(33, 103);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(57, 21);
            this.rdoDivide.TabIndex = 3;
            this.rdoDivide.TabStop = true;
            this.rdoDivide.Text = "Chia";
            this.rdoDivide.UseVisualStyleBackColor = true;
            this.rdoDivide.CheckedChanged += new System.EventHandler(this.TriggerResult);
            // 
            // rdoMultiply
            // 
            this.rdoMultiply.AutoSize = true;
            this.rdoMultiply.Location = new System.Drawing.Point(32, 76);
            this.rdoMultiply.Name = "rdoMultiply";
            this.rdoMultiply.Size = new System.Drawing.Size(63, 21);
            this.rdoMultiply.TabIndex = 2;
            this.rdoMultiply.TabStop = true;
            this.rdoMultiply.Text = "Nhân";
            this.rdoMultiply.UseVisualStyleBackColor = true;
            this.rdoMultiply.CheckedChanged += new System.EventHandler(this.TriggerResult);
            // 
            // rdoMinus
            // 
            this.rdoMinus.AutoSize = true;
            this.rdoMinus.Location = new System.Drawing.Point(33, 49);
            this.rdoMinus.Name = "rdoMinus";
            this.rdoMinus.Size = new System.Drawing.Size(51, 21);
            this.rdoMinus.TabIndex = 1;
            this.rdoMinus.TabStop = true;
            this.rdoMinus.Text = "Trừ";
            this.rdoMinus.UseVisualStyleBackColor = true;
            this.rdoMinus.CheckedChanged += new System.EventHandler(this.TriggerResult);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(33, 22);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(62, 21);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Cộng";
            this.rdoAdd.UseVisualStyleBackColor = true;
            this.rdoAdd.CheckedChanged += new System.EventHandler(this.TriggerResult);
            // 
            // grbCompare
            // 
            this.grbCompare.Controls.Add(this.chkMin);
            this.grbCompare.Controls.Add(this.chkMax);
            this.grbCompare.Location = new System.Drawing.Point(494, 201);
            this.grbCompare.Name = "grbCompare";
            this.grbCompare.Size = new System.Drawing.Size(200, 136);
            this.grbCompare.TabIndex = 2;
            this.grbCompare.TabStop = false;
            this.grbCompare.Text = "So sánh";
            // 
            // chkMin
            // 
            this.chkMin.AutoSize = true;
            this.chkMin.Location = new System.Drawing.Point(23, 76);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(18, 17);
            this.chkMin.TabIndex = 1;
            this.chkMin.UseVisualStyleBackColor = true;
            this.chkMin.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(23, 23);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(18, 17);
            this.chkMax.TabIndex = 0;
            this.chkMax.UseVisualStyleBackColor = true;
            this.chkMax.CheckedChanged += new System.EventHandler(this.chkMax_CheckedChanged);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(289, 398);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.Text = "Làm lại";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(452, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.grbCompare);
            this.Controls.Add(this.grbOperator);
            this.Controls.Add(this.grbInput);
            this.Name = "frmCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbOperator.ResumeLayout(false);
            this.grbOperator.PerformLayout();
            this.grbCompare.ResumeLayout(false);
            this.grbCompare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox grbOperator;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoMinus;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.GroupBox grbCompare;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnExit;
    }
}

