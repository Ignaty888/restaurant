namespace Restaurant.Forms.AddEditForms
{
    partial class AddEditPostForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPostName = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSalePercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование должности";
            // 
            // textBoxPostName
            // 
            this.textBoxPostName.Location = new System.Drawing.Point(36, 35);
            this.textBoxPostName.Name = "textBoxPostName";
            this.textBoxPostName.Size = new System.Drawing.Size(332, 21);
            this.textBoxPostName.TabIndex = 1;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(36, 164);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(142, 34);
            this.buttonAddEdit.TabIndex = 2;
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Оклад";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(36, 76);
            this.textBoxSalary.MaxLength = 10;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(159, 21);
            this.textBoxSalary.TabIndex = 1;
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Процент от продаж";
            // 
            // textBoxSalePercent
            // 
            this.textBoxSalePercent.Location = new System.Drawing.Point(36, 117);
            this.textBoxSalePercent.MaxLength = 3;
            this.textBoxSalePercent.Name = "textBoxSalePercent";
            this.textBoxSalePercent.Size = new System.Drawing.Size(159, 21);
            this.textBoxSalePercent.TabIndex = 1;
            this.textBoxSalePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddEditPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxSalePercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPostName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditPostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPostName;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSalePercent;
    }
}