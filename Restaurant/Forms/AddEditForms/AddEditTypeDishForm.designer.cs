namespace Restaurant.Forms.AddEditForms
{
    partial class AddEditTypeDishForm
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
            this.textBoxTypeDish = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDetailed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип блюда";
            // 
            // textBoxTypeDish
            // 
            this.textBoxTypeDish.Location = new System.Drawing.Point(36, 35);
            this.textBoxTypeDish.MaxLength = 250;
            this.textBoxTypeDish.Name = "textBoxTypeDish";
            this.textBoxTypeDish.Size = new System.Drawing.Size(332, 21);
            this.textBoxTypeDish.TabIndex = 1;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(36, 318);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(142, 34);
            this.buttonAddEdit.TabIndex = 3;
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание";
            // 
            // textBoxDetailed
            // 
            this.textBoxDetailed.Location = new System.Drawing.Point(36, 76);
            this.textBoxDetailed.MaxLength = 2500;
            this.textBoxDetailed.Multiline = true;
            this.textBoxDetailed.Name = "textBoxDetailed";
            this.textBoxDetailed.Size = new System.Drawing.Size(332, 226);
            this.textBoxDetailed.TabIndex = 2;
            // 
            // AddEditTypeDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxDetailed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTypeDish);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditTypeDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditPostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTypeDish;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDetailed;
    }
}