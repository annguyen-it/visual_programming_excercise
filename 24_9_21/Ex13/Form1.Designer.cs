
namespace Ex13
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(56, 34);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(524, 187);
            this.txtColor.TabIndex = 0;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.lblBlueValue);
            this.grbColor.Controls.Add(this.lblBlue);
            this.grbColor.Controls.Add(this.lblGreenValue);
            this.grbColor.Controls.Add(this.lblGreen);
            this.grbColor.Controls.Add(this.lblRedValue);
            this.grbColor.Controls.Add(this.lblRed);
            this.grbColor.Controls.Add(this.hsbBlue);
            this.grbColor.Controls.Add(this.hsbGreen);
            this.grbColor.Controls.Add(this.hsbRed);
            this.grbColor.Location = new System.Drawing.Point(56, 263);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(524, 139);
            this.grbColor.TabIndex = 1;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Chọn màu nền cho TextBox";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblBlueValue.Location = new System.Drawing.Point(460, 97);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(16, 17);
            this.lblBlueValue.TabIndex = 8;
            this.lblBlueValue.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblBlue.Location = new System.Drawing.Point(18, 97);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(36, 17);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGreenValue.Location = new System.Drawing.Point(460, 64);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(16, 17);
            this.lblGreenValue.TabIndex = 6;
            this.lblGreenValue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGreen.Location = new System.Drawing.Point(18, 64);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(48, 17);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Green";
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.ForeColor = System.Drawing.Color.Red;
            this.lblRedValue.Location = new System.Drawing.Point(460, 31);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(16, 17);
            this.lblRedValue.TabIndex = 4;
            this.lblRedValue.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(18, 31);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(34, 17);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red";
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(85, 97);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(346, 21);
            this.hsbBlue.TabIndex = 2;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbBlue_Scroll);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(85, 64);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(346, 21);
            this.hsbGreen.TabIndex = 1;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbGreen_Scroll);
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(85, 31);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(346, 21);
            this.hsbRed.TabIndex = 0;
            this.hsbRed.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 435);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.txtColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbRed;
    }
}

