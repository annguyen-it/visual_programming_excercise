
namespace Ex1
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
            this.grbMark = new System.Windows.Forms.GroupBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.txtTotalMark = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.lblTotalMark = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmVàoDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbMark.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMark
            // 
            this.grbMark.Controls.Add(this.lblMark);
            this.grbMark.Controls.Add(this.lblCredit);
            this.grbMark.Controls.Add(this.btnAdd);
            this.grbMark.Controls.Add(this.lblSubject);
            this.grbMark.Controls.Add(this.txtMark);
            this.grbMark.Controls.Add(this.txtCredit);
            this.grbMark.Controls.Add(this.cbSubject);
            this.grbMark.Location = new System.Drawing.Point(12, 41);
            this.grbMark.Name = "grbMark";
            this.grbMark.Size = new System.Drawing.Size(351, 364);
            this.grbMark.TabIndex = 0;
            this.grbMark.TabStop = false;
            this.grbMark.Text = "Thông tin điểm sinh viên";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(6, 110);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(40, 17);
            this.lblMark.TabIndex = 9;
            this.lblMark.Text = "Điểm";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(6, 75);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(66, 17);
            this.lblCredit.TabIndex = 8;
            this.lblCredit.Text = "Số tín chỉ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 48);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm vào DS";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 41);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(91, 17);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Tên môn học";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(121, 107);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(59, 22);
            this.txtMark.TabIndex = 2;
            // 
            // txtCredit
            // 
            this.txtCredit.Enabled = false;
            this.txtCredit.Location = new System.Drawing.Point(121, 75);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(59, 22);
            this.txtCredit.TabIndex = 1;
            // 
            // cbSubject
            // 
            this.cbSubject.DisplayMember = "Name";
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(121, 38);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(224, 24);
            this.cbSubject.TabIndex = 0;
            this.cbSubject.ValueMember = "Name";
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Enabled = false;
            this.txtTotalCredit.Location = new System.Drawing.Point(503, 278);
            this.txtTotalCredit.Multiline = true;
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.Size = new System.Drawing.Size(49, 22);
            this.txtTotalCredit.TabIndex = 3;
            // 
            // txtTotalMark
            // 
            this.txtTotalMark.Enabled = false;
            this.txtTotalMark.Location = new System.Drawing.Point(688, 278);
            this.txtTotalMark.Name = "txtTotalMark";
            this.txtTotalMark.Size = new System.Drawing.Size(100, 22);
            this.txtTotalMark.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(503, 319);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 22);
            this.textBox5.TabIndex = 5;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(378, 41);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(160, 17);
            this.lblList.TabIndex = 10;
            this.lblList.Text = "Danh sách các môn học";
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Location = new System.Drawing.Point(378, 280);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(101, 17);
            this.lblTotalCredit.TabIndex = 11;
            this.lblTotalCredit.Text = "Tổng số tín chỉ";
            // 
            // lblTotalMark
            // 
            this.lblTotalMark.AutoSize = true;
            this.lblTotalMark.Location = new System.Drawing.Point(607, 283);
            this.lblTotalMark.Name = "lblTotalMark";
            this.lblTotalMark.Size = new System.Drawing.Size(75, 17);
            this.lblTotalMark.TabIndex = 12;
            this.lblTotalMark.Text = "Tổng điểm";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(378, 322);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(108, 17);
            this.lblAverage.TabIndex = 13;
            this.lblAverage.Text = "Điểm trung bình";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(426, 369);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 36);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Tính";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(624, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 36);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 16;
            this.lstList.Location = new System.Drawing.Point(381, 70);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(407, 180);
            this.lstList.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmVàoDanhSáchToolStripMenuItem,
            this.tínhToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thêmVàoDanhSáchToolStripMenuItem
            // 
            this.thêmVàoDanhSáchToolStripMenuItem.Name = "thêmVàoDanhSáchToolStripMenuItem";
            this.thêmVàoDanhSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.thêmVàoDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.thêmVàoDanhSáchToolStripMenuItem.Text = "Thêm vào danh sách";
            this.thêmVàoDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tínhToolStripMenuItem
            // 
            this.tínhToolStripMenuItem.Name = "tínhToolStripMenuItem";
            this.tínhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.tínhToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.tínhToolStripMenuItem.Text = "Tính";
            this.tínhToolStripMenuItem.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalMark);
            this.Controls.Add(this.lblTotalCredit);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtTotalMark);
            this.Controls.Add(this.txtTotalCredit);
            this.Controls.Add(this.grbMark);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMark.ResumeLayout(false);
            this.grbMark.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtTotalMark;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTotalCredit;
        private System.Windows.Forms.Label lblTotalMark;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmVàoDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

