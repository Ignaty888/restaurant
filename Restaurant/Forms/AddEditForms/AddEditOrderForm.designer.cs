namespace Restaurant.Forms.AddEditForms
{
    partial class AddEditOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSelectEmployee = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddDish = new System.Windows.Forms.Button();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.orderDishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.BackColor = System.Drawing.Color.White;
            this.textBoxEmployee.Location = new System.Drawing.Point(12, 35);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.ReadOnly = true;
            this.textBoxEmployee.Size = new System.Drawing.Size(469, 21);
            this.textBoxEmployee.TabIndex = 1;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(12, 566);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(258, 42);
            this.buttonAddEdit.TabIndex = 2;
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelectEmployee
            // 
            this.buttonSelectEmployee.Image = global::Restaurant.Properties.Resources.search;
            this.buttonSelectEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectEmployee.Location = new System.Drawing.Point(487, 30);
            this.buttonSelectEmployee.Name = "buttonSelectEmployee";
            this.buttonSelectEmployee.Size = new System.Drawing.Size(119, 31);
            this.buttonSelectEmployee.TabIndex = 3;
            this.buttonSelectEmployee.Text = "Выбрать";
            this.buttonSelectEmployee.UseVisualStyleBackColor = true;
            this.buttonSelectEmployee.Click += new System.EventHandler(this.buttonSelectEmployee_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishName,
            this.Quantity,
            this.dishPriceDataGridViewTextBoxColumn,
            this.Totalprice,
            this.DeleteColumn});
            this.dataGridView.DataSource = this.orderDishBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 128);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(594, 378);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Блюда в заказе";
            // 
            // buttonAddDish
            // 
            this.buttonAddDish.Image = global::Restaurant.Properties.Resources.add;
            this.buttonAddDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDish.Location = new System.Drawing.Point(367, 91);
            this.buttonAddDish.Name = "buttonAddDish";
            this.buttonAddDish.Size = new System.Drawing.Size(239, 31);
            this.buttonAddDish.TabIndex = 3;
            this.buttonAddDish.Text = "Добавить блюдо";
            this.buttonAddDish.UseVisualStyleBackColor = true;
            this.buttonAddDish.Click += new System.EventHandler(this.buttonAddDish_Click);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(9, 73);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(79, 15);
            this.labelOrderDate.TabIndex = 5;
            this.labelOrderDate.Text = "Дата заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Итоговая сумма:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(123, 525);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(147, 21);
            this.textBoxTotal.TabIndex = 7;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderDishBindingSource
            // 
            this.orderDishBindingSource.DataSource = typeof(Restaurant.Data.OrderDish);
            // 
            // DishName
            // 
            this.DishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DishName.DataPropertyName = "DishName";
            this.DishName.HeaderText = "Блюдо";
            this.DishName.Name = "DishName";
            this.DishName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // dishPriceDataGridViewTextBoxColumn
            // 
            this.dishPriceDataGridViewTextBoxColumn.DataPropertyName = "DishPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dishPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dishPriceDataGridViewTextBoxColumn.HeaderText = "Цена за ед.";
            this.dishPriceDataGridViewTextBoxColumn.Name = "dishPriceDataGridViewTextBoxColumn";
            this.dishPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Totalprice
            // 
            this.Totalprice.DataPropertyName = "Totalprice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Totalprice.DefaultCellStyle = dataGridViewCellStyle3;
            this.Totalprice.HeaderText = "Итого";
            this.Totalprice.Name = "Totalprice";
            this.Totalprice.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Удалить";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // AddEditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 620);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonAddDish);
            this.Controls.Add(this.buttonSelectEmployee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSelectEmployee;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource orderDishBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddDish;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalprice;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}