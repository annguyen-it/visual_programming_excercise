
namespace Ex8
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
            this.clbFood = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbFood
            // 
            this.clbFood.FormattingEnabled = true;
            this.clbFood.Location = new System.Drawing.Point(60, 84);
            this.clbFood.MultiColumn = true;
            this.clbFood.Name = "clbFood";
            this.clbFood.Size = new System.Drawing.Size(510, 174);
            this.clbFood.TabIndex = 0;
            this.clbFood.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbFood_ItemCheck);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(255, 305);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Hoàn thành";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(57, 45);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(96, 17);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Chọn món ăn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 375);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.clbFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbFood;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblFood;
    }
}

