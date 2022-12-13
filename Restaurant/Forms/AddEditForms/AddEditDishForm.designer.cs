namespace Restaurant.Forms.AddEditForms
{
    partial class AddEditDishForm
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
            this.textBoxDishName = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDetailed = new System.Windows.Forms.TextBox();
            this.buttonLoadPhoto = new System.Windows.Forms.Button();
            this.comboBoxTypeDish = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование блюда";
            // 
            // textBoxDishName
            // 
            this.textBoxDishName.Location = new System.Drawing.Point(12, 33);
            this.textBoxDishName.Name = "textBoxDishName";
            this.textBoxDishName.Size = new System.Drawing.Size(538, 21);
            this.textBoxDishName.TabIndex = 1;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(12, 446);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(260, 34);
            this.buttonAddEdit.TabIndex = 2;
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цена за порцию";
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(290, 404);
            this.textBoxprice.MaxLength = 10;
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(159, 21);
            this.textBoxprice.TabIndex = 1;
            this.textBoxprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 123);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(260, 260);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Описание";
            // 
            // textBoxDetailed
            // 
            this.textBoxDetailed.Location = new System.Drawing.Point(290, 123);
            this.textBoxDetailed.MaxLength = 2500;
            this.textBoxDetailed.Multiline = true;
            this.textBoxDetailed.Name = "textBoxDetailed";
            this.textBoxDetailed.Size = new System.Drawing.Size(260, 260);
            this.textBoxDetailed.TabIndex = 1;
            // 
            // buttonLoadPhoto
            // 
            this.buttonLoadPhoto.Location = new System.Drawing.Point(12, 389);
            this.buttonLoadPhoto.Name = "buttonLoadPhoto";
            this.buttonLoadPhoto.Size = new System.Drawing.Size(260, 36);
            this.buttonLoadPhoto.TabIndex = 4;
            this.buttonLoadPhoto.Text = "Загрузить фото";
            this.buttonLoadPhoto.UseVisualStyleBackColor = true;
            this.buttonLoadPhoto.Click += new System.EventHandler(this.buttonLoadPhoto_Click);
            // 
            // comboBoxTypeDish
            // 
            this.comboBoxTypeDish.DisplayMember = "TypeDishName";
            this.comboBoxTypeDish.FormattingEnabled = true;
            this.comboBoxTypeDish.Location = new System.Drawing.Point(12, 74);
            this.comboBoxTypeDish.Name = "comboBoxTypeDish";
            this.comboBoxTypeDish.Size = new System.Drawing.Size(538, 23);
            this.comboBoxTypeDish.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тип блюда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Фото";
            // 
            // AddEditDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 492);
            this.Controls.Add(this.comboBoxTypeDish);
            this.Controls.Add(this.buttonLoadPhoto);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxDetailed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDishName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDishName;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDetailed;
        private System.Windows.Forms.Button buttonLoadPhoto;
        private System.Windows.Forms.ComboBox comboBoxTypeDish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}