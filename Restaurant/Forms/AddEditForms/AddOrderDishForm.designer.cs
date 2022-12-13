namespace Restaurant.Forms.AddEditForms
{
    partial class AddOrderDishForm
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
            this.textBoxSelectedDish = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFindDish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSelectedDish
            // 
            this.textBoxSelectedDish.BackColor = System.Drawing.Color.White;
            this.textBoxSelectedDish.Location = new System.Drawing.Point(36, 74);
            this.textBoxSelectedDish.Name = "textBoxSelectedDish";
            this.textBoxSelectedDish.ReadOnly = true;
            this.textBoxSelectedDish.Size = new System.Drawing.Size(503, 21);
            this.textBoxSelectedDish.TabIndex = 1;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(36, 181);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(248, 45);
            this.buttonAddEdit.TabIndex = 2;
            this.buttonAddEdit.Text = "Добавить в заказ";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFindDish
            // 
            this.buttonFindDish.Image = global::Restaurant.Properties.Resources.search;
            this.buttonFindDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFindDish.Location = new System.Drawing.Point(36, 10);
            this.buttonFindDish.Name = "buttonFindDish";
            this.buttonFindDish.Size = new System.Drawing.Size(248, 38);
            this.buttonFindDish.TabIndex = 3;
            this.buttonFindDish.Text = "Поиск блюда";
            this.buttonFindDish.UseVisualStyleBackColor = true;
            this.buttonFindDish.Click += new System.EventHandler(this.buttonFindDish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество порций";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(36, 119);
            this.textBoxQuantity.MaxLength = 2;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(118, 21);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "1";
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбранное блюдо";
            // 
            // AddOrderDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 238);
            this.Controls.Add(this.buttonFindDish);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSelectedDish);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrderDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор блюда в заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSelectedDish;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFindDish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label1;
    }
}