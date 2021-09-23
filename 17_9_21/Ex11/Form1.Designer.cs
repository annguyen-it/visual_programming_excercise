
namespace Ex11
{
    partial class OrderForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.lstBuy = new System.Windows.Forms.ListBox();
            this.grbPayment = new System.Windows.Forms.GroupBox();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkFax = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbPayment.SuspendLayout();
            this.grbContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(388, 33);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 17);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(30, 86);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(165, 17);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Danh sách các mặt hàng";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Location = new System.Drawing.Point(388, 86);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(97, 17);
            this.lblBuy.TabIndex = 3;
            this.lblBuy.Text = "Hàng đặt mua";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(466, 30);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 22);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lstItem
            // 
            this.lstItem.ItemHeight = 16;
            this.lstItem.Location = new System.Drawing.Point(33, 117);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(276, 164);
            this.lstItem.TabIndex = 6;
            this.lstItem.DoubleClick += new System.EventHandler(this.lstItem_DoubleClick);
            // 
            // lstBuy
            // 
            this.lstBuy.ItemHeight = 16;
            this.lstBuy.Location = new System.Drawing.Point(391, 117);
            this.lstBuy.Name = "lstBuy";
            this.lstBuy.Size = new System.Drawing.Size(276, 164);
            this.lstBuy.TabIndex = 7;
            this.lstBuy.DoubleClick += new System.EventHandler(this.lstBuy_DoubleClick);
            // 
            // grbPayment
            // 
            this.grbPayment.Controls.Add(this.rdoCard);
            this.grbPayment.Controls.Add(this.rdoCheque);
            this.grbPayment.Controls.Add(this.rdoCash);
            this.grbPayment.Location = new System.Drawing.Point(33, 320);
            this.grbPayment.Name = "grbPayment";
            this.grbPayment.Size = new System.Drawing.Size(200, 113);
            this.grbPayment.TabIndex = 8;
            this.grbPayment.TabStop = false;
            this.grbPayment.Text = "Phương thức thanh toán";
            // 
            // rdoCard
            // 
            this.rdoCard.AutoSize = true;
            this.rdoCard.Location = new System.Drawing.Point(21, 80);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(109, 21);
            this.rdoCard.TabIndex = 2;
            this.rdoCard.TabStop = true;
            this.rdoCard.Text = "Thẻ tín dụng";
            this.rdoCard.UseVisualStyleBackColor = true;
            this.rdoCard.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(21, 53);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(53, 21);
            this.rdoCheque.TabIndex = 1;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Séc";
            this.rdoCheque.UseVisualStyleBackColor = true;
            this.rdoCheque.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(21, 26);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(84, 21);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Tiền mặt";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // grbContact
            // 
            this.grbContact.Controls.Add(this.chkEmail);
            this.grbContact.Controls.Add(this.chkFax);
            this.grbContact.Controls.Add(this.chkPhone);
            this.grbContact.Location = new System.Drawing.Point(391, 320);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(200, 113);
            this.grbContact.TabIndex = 0;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Hình thức liên lạc";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(29, 81);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(64, 21);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkFax
            // 
            this.chkFax.AutoSize = true;
            this.chkFax.Location = new System.Drawing.Point(29, 53);
            this.chkFax.Name = "chkFax";
            this.chkFax.Size = new System.Drawing.Size(52, 21);
            this.chkFax.TabIndex = 1;
            this.chkFax.Text = "Fax";
            this.chkFax.UseVisualStyleBackColor = true;
            this.chkFax.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkPhone
            // 
            this.chkPhone.AutoSize = true;
            this.chkPhone.Location = new System.Drawing.Point(29, 26);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.Size = new System.Drawing.Size(94, 21);
            this.chkPhone.TabIndex = 0;
            this.chkPhone.Text = "Điện thoại";
            this.chkPhone.UseVisualStyleBackColor = true;
            this.chkPhone.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(234, 470);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 30);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(389, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 519);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grbContact);
            this.Controls.Add(this.lstBuy);
            this.Controls.Add(this.grbPayment);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPayment.ResumeLayout(false);
            this.grbPayment.PerformLayout();
            this.grbContact.ResumeLayout(false);
            this.grbContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.ListBox lstBuy;
        private System.Windows.Forms.GroupBox grbPayment;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.GroupBox grbContact;
        private System.Windows.Forms.RadioButton rdoCard;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkFax;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
    }
}

