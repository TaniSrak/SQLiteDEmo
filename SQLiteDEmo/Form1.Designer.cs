namespace SQLiteDEmo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbInputNewCategory = new System.Windows.Forms.TextBox();
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbGuery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(68, 102);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(739, 198);
            this.tbOutput.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(881, 116);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(267, 102);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCategory.Location = new System.Drawing.Point(881, 364);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(320, 111);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Добавить категорию";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tbInputNewCategory
            // 
            this.tbInputNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInputNewCategory.Location = new System.Drawing.Point(68, 364);
            this.tbInputNewCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbInputNewCategory.Multiline = true;
            this.tbInputNewCategory.Name = "tbInputNewCategory";
            this.tbInputNewCategory.Size = new System.Drawing.Size(739, 176);
            this.tbInputNewCategory.TabIndex = 0;
            // 
            // dgCategory
            // 
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Location = new System.Drawing.Point(68, 591);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.RowHeadersWidth = 72;
            this.dgCategory.RowTemplate.Height = 31;
            this.dgCategory.Size = new System.Drawing.Size(739, 332);
            this.dgCategory.TabIndex = 2;
            this.dgCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(892, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(892, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbGuery
            // 
            this.tbGuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGuery.Location = new System.Drawing.Point(892, 755);
            this.tbGuery.Margin = new System.Windows.Forms.Padding(6);
            this.tbGuery.Multiline = true;
            this.tbGuery.Name = "tbGuery";
            this.tbGuery.Size = new System.Drawing.Size(722, 168);
            this.tbGuery.TabIndex = 5;
            this.tbGuery.TextChanged += new System.EventHandler(this.tbGuery_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 995);
            this.Controls.Add(this.tbGuery);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbInputNewCategory);
            this.Controls.Add(this.tbOutput);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tbInputNewCategory;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbGuery;
    }
}

