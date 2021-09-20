
namespace Ex9
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
            this.components = new System.ComponentModel.Container();
            this.txtText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbFontFamily = new System.Windows.Forms.GroupBox();
            this.rdoArial = new System.Windows.Forms.RadioButton();
            this.rdoTahoma = new System.Windows.Forms.RadioButton();
            this.rdoTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.rdoVnTime = new System.Windows.Forms.RadioButton();
            this.grbTextDecoration = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.grbTextColor = new System.Windows.Forms.GroupBox();
            this.rdoPurple = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbFontFamily.SuspendLayout();
            this.grbTextDecoration.SuspendLayout();
            this.grbTextColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(199, 30);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(358, 36);
            this.txtText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbFontFamily
            // 
            this.grbFontFamily.Controls.Add(this.rdoArial);
            this.grbFontFamily.Controls.Add(this.rdoTahoma);
            this.grbFontFamily.Controls.Add(this.rdoTimesNewRoman);
            this.grbFontFamily.Controls.Add(this.rdoVnTime);
            this.grbFontFamily.Location = new System.Drawing.Point(34, 90);
            this.grbFontFamily.Name = "grbFontFamily";
            this.grbFontFamily.Size = new System.Drawing.Size(197, 142);
            this.grbFontFamily.TabIndex = 2;
            this.grbFontFamily.TabStop = false;
            this.grbFontFamily.Text = "Kiểu font";
            // 
            // rdoArial
            // 
            this.rdoArial.AutoSize = true;
            this.rdoArial.Location = new System.Drawing.Point(19, 106);
            this.rdoArial.Name = "rdoArial";
            this.rdoArial.Size = new System.Drawing.Size(57, 21);
            this.rdoArial.TabIndex = 3;
            this.rdoArial.TabStop = true;
            this.rdoArial.Text = "Arial";
            this.rdoArial.UseVisualStyleBackColor = true;
            this.rdoArial.CheckedChanged += new System.EventHandler(this.FontFamily_CheckedChanged);
            // 
            // rdoTahoma
            // 
            this.rdoTahoma.AutoSize = true;
            this.rdoTahoma.Location = new System.Drawing.Point(19, 79);
            this.rdoTahoma.Name = "rdoTahoma";
            this.rdoTahoma.Size = new System.Drawing.Size(81, 21);
            this.rdoTahoma.TabIndex = 2;
            this.rdoTahoma.TabStop = true;
            this.rdoTahoma.Text = "Tahoma";
            this.rdoTahoma.UseVisualStyleBackColor = true;
            this.rdoTahoma.CheckedChanged += new System.EventHandler(this.FontFamily_CheckedChanged);
            // 
            // rdoTimesNewRoman
            // 
            this.rdoTimesNewRoman.AutoSize = true;
            this.rdoTimesNewRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTimesNewRoman.Location = new System.Drawing.Point(19, 52);
            this.rdoTimesNewRoman.Name = "rdoTimesNewRoman";
            this.rdoTimesNewRoman.Size = new System.Drawing.Size(147, 21);
            this.rdoTimesNewRoman.TabIndex = 1;
            this.rdoTimesNewRoman.TabStop = true;
            this.rdoTimesNewRoman.Text = "Times New Roman";
            this.rdoTimesNewRoman.UseVisualStyleBackColor = true;
            this.rdoTimesNewRoman.CheckedChanged += new System.EventHandler(this.FontFamily_CheckedChanged);
            // 
            // rdoVnTime
            // 
            this.rdoVnTime.AutoSize = true;
            this.rdoVnTime.Location = new System.Drawing.Point(19, 25);
            this.rdoVnTime.Name = "rdoVnTime";
            this.rdoVnTime.Size = new System.Drawing.Size(77, 21);
            this.rdoVnTime.TabIndex = 0;
            this.rdoVnTime.TabStop = true;
            this.rdoVnTime.Text = "VnTime";
            this.rdoVnTime.UseVisualStyleBackColor = true;
            this.rdoVnTime.CheckedChanged += new System.EventHandler(this.FontFamily_CheckedChanged);
            // 
            // grbTextDecoration
            // 
            this.grbTextDecoration.Controls.Add(this.chkUnderline);
            this.grbTextDecoration.Controls.Add(this.chkStrikeout);
            this.grbTextDecoration.Controls.Add(this.chkItalic);
            this.grbTextDecoration.Controls.Add(this.chkBold);
            this.grbTextDecoration.Location = new System.Drawing.Point(304, 90);
            this.grbTextDecoration.Name = "grbTextDecoration";
            this.grbTextDecoration.Size = new System.Drawing.Size(200, 142);
            this.grbTextDecoration.TabIndex = 3;
            this.grbTextDecoration.TabStop = false;
            this.grbTextDecoration.Text = "Hiệu ứng";
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(19, 106);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(91, 21);
            this.chkUnderline.TabIndex = 3;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.FontDecoration_CheckedChange);
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStrikeout.Location = new System.Drawing.Point(19, 79);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(86, 21);
            this.chkStrikeout.TabIndex = 2;
            this.chkStrikeout.Text = "Strikeout";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            this.chkStrikeout.CheckedChanged += new System.EventHandler(this.FontDecoration_CheckedChange);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(19, 52);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(58, 21);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.FontDecoration_CheckedChange);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(19, 25);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(62, 21);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.FontDecoration_CheckedChange);
            // 
            // grbTextColor
            // 
            this.grbTextColor.Controls.Add(this.rdoPurple);
            this.grbTextColor.Controls.Add(this.rdoGreen);
            this.grbTextColor.Controls.Add(this.rdoRed);
            this.grbTextColor.Controls.Add(this.rdoBlue);
            this.grbTextColor.Location = new System.Drawing.Point(570, 90);
            this.grbTextColor.Name = "grbTextColor";
            this.grbTextColor.Size = new System.Drawing.Size(200, 142);
            this.grbTextColor.TabIndex = 4;
            this.grbTextColor.TabStop = false;
            this.grbTextColor.Text = "Màu chữ";
            // 
            // rdoPurple
            // 
            this.rdoPurple.AutoSize = true;
            this.rdoPurple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoPurple.Location = new System.Drawing.Point(19, 105);
            this.rdoPurple.Name = "rdoPurple";
            this.rdoPurple.Size = new System.Drawing.Size(52, 21);
            this.rdoPurple.TabIndex = 3;
            this.rdoPurple.TabStop = true;
            this.rdoPurple.Text = "Tím";
            this.rdoPurple.UseVisualStyleBackColor = true;
            this.rdoPurple.CheckedChanged += new System.EventHandler(this.FontColor_CheckedChange);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdoGreen.Location = new System.Drawing.Point(19, 79);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(71, 21);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Lá cây";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.FontColor_CheckedChange);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.ForeColor = System.Drawing.Color.Red;
            this.rdoRed.Location = new System.Drawing.Point(19, 52);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(47, 21);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Đỏ";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.FontColor_CheckedChange);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdoBlue.Location = new System.Drawing.Point(19, 24);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(62, 21);
            this.rdoBlue.TabIndex = 0;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Xanh";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.FontColor_CheckedChange);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(263, 277);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 4;
            this.btnRedo.Text = "Làm lại";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(441, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbTextColor);
            this.Controls.Add(this.grbTextDecoration);
            this.Controls.Add(this.grbFontFamily);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbFontFamily.ResumeLayout(false);
            this.grbFontFamily.PerformLayout();
            this.grbTextDecoration.ResumeLayout(false);
            this.grbTextDecoration.PerformLayout();
            this.grbTextColor.ResumeLayout(false);
            this.grbTextColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbFontFamily;
        private System.Windows.Forms.RadioButton rdoArial;
        private System.Windows.Forms.RadioButton rdoTahoma;
        private System.Windows.Forms.RadioButton rdoTimesNewRoman;
        private System.Windows.Forms.RadioButton rdoVnTime;
        private System.Windows.Forms.GroupBox grbTextDecoration;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.GroupBox grbTextColor;
        private System.Windows.Forms.RadioButton rdoPurple;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnExit;
    }
}

