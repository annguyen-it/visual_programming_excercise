
namespace Bai11
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.cboxEmail = new System.Windows.Forms.CheckBox();
            this.cboxFax = new System.Windows.Forms.CheckBox();
            this.cboxPhone = new System.Windows.Forms.CheckBox();
            this.lbxBuy = new System.Windows.Forms.ListBox();
            this.lbxItem = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxPayment.SuspendLayout();
            this.gbxContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(438, 42);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 17);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(87, 101);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(165, 17);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Danh sách các mặt hàng";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Location = new System.Drawing.Point(438, 101);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(97, 17);
            this.lblBuy.TabIndex = 3;
            this.lblBuy.Text = "Hàng đặt mua";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(516, 39);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.rdoCheque);
            this.gbxPayment.Controls.Add(this.rdoCash);
            this.gbxPayment.Location = new System.Drawing.Point(93, 318);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(200, 120);
            this.gbxPayment.TabIndex = 6;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Phương thức thanh toán";
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(28, 61);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(53, 21);
            this.rdoCheque.TabIndex = 1;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Séc";
            this.rdoCheque.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(28, 33);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(84, 21);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Tiền mặt";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Location = new System.Drawing.Point(121, 407);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(109, 21);
            this.rdoVisa.TabIndex = 7;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.Text = "Thẻ tín dụng";
            this.rdoVisa.UseVisualStyleBackColor = true;
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.cboxEmail);
            this.gbxContact.Controls.Add(this.cboxFax);
            this.gbxContact.Controls.Add(this.cboxPhone);
            this.gbxContact.Location = new System.Drawing.Point(463, 324);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(200, 120);
            this.gbxContact.TabIndex = 8;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Hình thức liên lạc";
            // 
            // cboxEmail
            // 
            this.cboxEmail.AutoSize = true;
            this.cboxEmail.Location = new System.Drawing.Point(28, 79);
            this.cboxEmail.Name = "cboxEmail";
            this.cboxEmail.Size = new System.Drawing.Size(64, 21);
            this.cboxEmail.TabIndex = 2;
            this.cboxEmail.Text = "Email";
            this.cboxEmail.UseVisualStyleBackColor = true;
            // 
            // cboxFax
            // 
            this.cboxFax.AutoSize = true;
            this.cboxFax.Location = new System.Drawing.Point(28, 51);
            this.cboxFax.Name = "cboxFax";
            this.cboxFax.Size = new System.Drawing.Size(52, 21);
            this.cboxFax.TabIndex = 1;
            this.cboxFax.Text = "Fax";
            this.cboxFax.UseVisualStyleBackColor = true;
            // 
            // cboxPhone
            // 
            this.cboxPhone.AutoSize = true;
            this.cboxPhone.Location = new System.Drawing.Point(28, 23);
            this.cboxPhone.Name = "cboxPhone";
            this.cboxPhone.Size = new System.Drawing.Size(94, 21);
            this.cboxPhone.TabIndex = 0;
            this.cboxPhone.Text = "Điện thoại";
            this.cboxPhone.UseVisualStyleBackColor = true;
            // 
            // lbxBuy
            // 
            this.lbxBuy.FormattingEnabled = true;
            this.lbxBuy.ItemHeight = 16;
            this.lbxBuy.Location = new System.Drawing.Point(463, 134);
            this.lbxBuy.Name = "lbxBuy";
            this.lbxBuy.Size = new System.Drawing.Size(240, 116);
            this.lbxBuy.TabIndex = 9;
            // 
            // lbxItem
            // 
            this.lbxItem.FormattingEnabled = true;
            this.lbxItem.ItemHeight = 16;
            this.lbxItem.Location = new System.Drawing.Point(93, 134);
            this.lbxItem.Name = "lbxItem";
            this.lbxItem.Size = new System.Drawing.Size(259, 116);
            this.lbxItem.TabIndex = 10;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(295, 487);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(418, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbxItem);
            this.Controls.Add(this.lbxBuy);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.rdoVisa);
            this.Controls.Add(this.gbxPayment);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.gbxContact.ResumeLayout(false);
            this.gbxContact.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoVisa;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.CheckBox cboxEmail;
        private System.Windows.Forms.CheckBox cboxFax;
        private System.Windows.Forms.CheckBox cboxPhone;
        private System.Windows.Forms.ListBox lbxBuy;
        private System.Windows.Forms.ListBox lbxItem;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
    }
}

