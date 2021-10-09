
namespace Ex2
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
            this.grbCustomer = new System.Windows.Forms.GroupBox();
            this.rdoHalfDay = new System.Windows.Forms.RadioButton();
            this.rdoFullDay = new System.Windows.Forms.RadioButton();
            this.lblNumerous = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbNumerous = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.lblDrinkMoney = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDrinkMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCustomer
            // 
            this.grbCustomer.Controls.Add(this.label2);
            this.grbCustomer.Controls.Add(this.label1);
            this.grbCustomer.Controls.Add(this.txtDrinkMoney);
            this.grbCustomer.Controls.Add(this.txtPrice);
            this.grbCustomer.Controls.Add(this.lblDrinkMoney);
            this.grbCustomer.Controls.Add(this.btnAddNew);
            this.grbCustomer.Controls.Add(this.btnAdd);
            this.grbCustomer.Controls.Add(this.cbNumerous);
            this.grbCustomer.Controls.Add(this.cbDrink);
            this.grbCustomer.Controls.Add(this.txtName);
            this.grbCustomer.Controls.Add(this.rdoHalfDay);
            this.grbCustomer.Controls.Add(this.rdoFullDay);
            this.grbCustomer.Controls.Add(this.lblNumerous);
            this.grbCustomer.Controls.Add(this.lblDrink);
            this.grbCustomer.Controls.Add(this.lblPrice);
            this.grbCustomer.Controls.Add(this.lblName);
            this.grbCustomer.Location = new System.Drawing.Point(12, 31);
            this.grbCustomer.Name = "grbCustomer";
            this.grbCustomer.Size = new System.Drawing.Size(516, 339);
            this.grbCustomer.TabIndex = 0;
            this.grbCustomer.TabStop = false;
            this.grbCustomer.Text = "Nhập thông tin khách hàng đặt tour";
            // 
            // rdoHalfDay
            // 
            this.rdoHalfDay.AutoSize = true;
            this.rdoHalfDay.Location = new System.Drawing.Point(192, 76);
            this.rdoHalfDay.Name = "rdoHalfDay";
            this.rdoHalfDay.Size = new System.Drawing.Size(90, 21);
            this.rdoHalfDay.TabIndex = 5;
            this.rdoHalfDay.TabStop = true;
            this.rdoHalfDay.Text = "Nửa ngày";
            this.rdoHalfDay.UseVisualStyleBackColor = true;
            this.rdoHalfDay.CheckedChanged += new System.EventHandler(this.rdoHalfDay_CheckedChanged);
            // 
            // rdoFullDay
            // 
            this.rdoFullDay.AutoSize = true;
            this.rdoFullDay.Location = new System.Drawing.Point(26, 76);
            this.rdoFullDay.Name = "rdoFullDay";
            this.rdoFullDay.Size = new System.Drawing.Size(81, 21);
            this.rdoFullDay.TabIndex = 4;
            this.rdoFullDay.TabStop = true;
            this.rdoFullDay.Text = "Cả ngày";
            this.rdoFullDay.UseVisualStyleBackColor = true;
            this.rdoFullDay.CheckedChanged += new System.EventHandler(this.rdoFullDay_CheckedChanged);
            // 
            // lblNumerous
            // 
            this.lblNumerous.AutoSize = true;
            this.lblNumerous.Location = new System.Drawing.Point(198, 177);
            this.lblNumerous.Name = "lblNumerous";
            this.lblNumerous.Size = new System.Drawing.Size(64, 17);
            this.lblNumerous.TabIndex = 3;
            this.lblNumerous.Text = "Số lượng";
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Location = new System.Drawing.Point(23, 177);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(97, 17);
            this.lblDrink.TabIndex = 2;
            this.lblDrink.Text = "Chọn đồ uống";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 118);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(97, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Giá du thuyền";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCustomer);
            this.groupBox2.Location = new System.Drawing.Point(549, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 339);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 6;
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(26, 210);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(131, 24);
            this.cbDrink.TabIndex = 7;
            this.cbDrink.SelectedIndexChanged += new System.EventHandler(this.cbDrink_SelectedIndexChanged);
            // 
            // cbNumerous
            // 
            this.cbNumerous.FormattingEnabled = true;
            this.cbNumerous.Location = new System.Drawing.Point(201, 210);
            this.cbNumerous.Name = "cbNumerous";
            this.cbNumerous.Size = new System.Drawing.Size(121, 24);
            this.cbNumerous.TabIndex = 8;
            this.cbNumerous.SelectedIndexChanged += new System.EventHandler(this.cbNumerous_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm vào DS";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(273, 266);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(117, 37);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(884, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 41);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 16;
            this.lstCustomer.Location = new System.Drawing.Point(6, 21);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(542, 308);
            this.lstCustomer.TabIndex = 12;
            // 
            // lblDrinkMoney
            // 
            this.lblDrinkMoney.AutoSize = true;
            this.lblDrinkMoney.Location = new System.Drawing.Point(366, 177);
            this.lblDrinkMoney.Name = "lblDrinkMoney";
            this.lblDrinkMoney.Size = new System.Drawing.Size(36, 17);
            this.lblDrinkMoney.TabIndex = 12;
            this.lblDrinkMoney.Text = "Tiền";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(126, 118);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(94, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // txtDrinkMoney
            // 
            this.txtDrinkMoney.Enabled = false;
            this.txtDrinkMoney.Location = new System.Drawing.Point(369, 210);
            this.txtDrinkMoney.Name = "txtDrinkMoney";
            this.txtDrinkMoney.Size = new System.Drawing.Size(100, 22);
            this.txtDrinkMoney.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "$";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCustomer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCustomer.ResumeLayout(false);
            this.grbCustomer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomer;
        private System.Windows.Forms.RadioButton rdoHalfDay;
        private System.Windows.Forms.RadioButton rdoFullDay;
        private System.Windows.Forms.Label lblNumerous;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbNumerous;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDrinkMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrinkMoney;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

