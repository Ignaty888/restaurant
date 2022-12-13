namespace Restaurant.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингридиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.доходПоСотрудникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.блюдаToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.отчётыToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыБлюдToolStripMenuItem,
            this.ингридиентыToolStripMenuItem,
            this.единицыИзмеренияToolStripMenuItem,
            this.должностиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // типыБлюдToolStripMenuItem
            // 
            this.типыБлюдToolStripMenuItem.Name = "типыБлюдToolStripMenuItem";
            this.типыБлюдToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.типыБлюдToolStripMenuItem.Text = "Типы блюд";
            this.типыБлюдToolStripMenuItem.Click += new System.EventHandler(this.типыБлюдToolStripMenuItem_Click);
            // 
            // ингридиентыToolStripMenuItem
            // 
            this.ингридиентыToolStripMenuItem.Name = "ингридиентыToolStripMenuItem";
            this.ингридиентыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ингридиентыToolStripMenuItem.Text = "Ингредиенты";
            this.ингридиентыToolStripMenuItem.Click += new System.EventHandler(this.ингридиентыToolStripMenuItem_Click);
            // 
            // единицыИзмеренияToolStripMenuItem
            // 
            this.единицыИзмеренияToolStripMenuItem.Name = "единицыИзмеренияToolStripMenuItem";
            this.единицыИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.единицыИзмеренияToolStripMenuItem.Text = "Единицы измерения";
            this.единицыИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.единицыИзмеренияToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            this.блюдаToolStripMenuItem.Click += new System.EventHandler(this.блюдаToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.отчётыToolStripMenuItem.Text = "Заказы";
            this.отчётыToolStripMenuItem.Click += new System.EventHandler(this.отчётыToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem1
            // 
            this.отчётыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доходПоСотрудникамToolStripMenuItem});
            this.отчётыToolStripMenuItem1.Name = "отчётыToolStripMenuItem1";
            this.отчётыToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem1.Text = "Отчёты";
            // 
            // доходПоСотрудникамToolStripMenuItem
            // 
            this.доходПоСотрудникамToolStripMenuItem.Name = "доходПоСотрудникамToolStripMenuItem";
            this.доходПоСотрудникамToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.доходПоСотрудникамToolStripMenuItem.Text = "Доход по сотрудникам";
            this.доходПоСотрудникамToolStripMenuItem.Click += new System.EventHandler(this.доходПоСотрудникамToolStripMenuItem_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateOrder.Image = global::Restaurant.Properties.Resources.iconfinder_Food_fork_kitchen_knife_meanns_restaurant_1886929;
            this.buttonCreateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateOrder.Location = new System.Drawing.Point(12, 236);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(362, 43);
            this.buttonCreateOrder.TabIndex = 0;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Restaurant.Properties.Resources._22577e6611d10ba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(386, 291);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ресторан";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингридиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem единицыИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem доходПоСотрудникамToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateOrder;
    }
}

