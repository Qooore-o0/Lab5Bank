namespace Bank
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearText1 = new System.Windows.Forms.Label();
            this.countText1 = new System.Windows.Forms.Label();
            this.infoText1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nextSlide1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mainPanel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mainPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Location = new System.Drawing.Point(115, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 224);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.BackColor = System.Drawing.Color.Transparent;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.Location = new System.Drawing.Point(26, 28);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(140, 26);
            this.name1.TabIndex = 4;
            this.name1.Text = "Стабильный";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.yearText1);
            this.panel1.Controls.Add(this.countText1);
            this.panel1.Controls.Add(this.infoText1);
            this.panel1.Controls.Add(this.name1);
            this.panel1.Location = new System.Drawing.Point(131, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 224);
            this.panel1.TabIndex = 5;
            // 
            // yearText1
            // 
            this.yearText1.AutoSize = true;
            this.yearText1.BackColor = System.Drawing.Color.Transparent;
            this.yearText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yearText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.yearText1.Location = new System.Drawing.Point(74, 188);
            this.yearText1.Name = "yearText1";
            this.yearText1.Size = new System.Drawing.Size(79, 20);
            this.yearText1.TabIndex = 6;
            this.yearText1.Text = "годовых";
            // 
            // countText1
            // 
            this.countText1.AutoSize = true;
            this.countText1.BackColor = System.Drawing.Color.Transparent;
            this.countText1.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold);
            this.countText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.countText1.Location = new System.Drawing.Point(20, 172);
            this.countText1.Name = "countText1";
            this.countText1.Size = new System.Drawing.Size(61, 41);
            this.countText1.TabIndex = 7;
            this.countText1.Text = "8%";
            // 
            // infoText1
            // 
            this.infoText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.infoText1.AutoSize = true;
            this.infoText1.BackColor = System.Drawing.Color.Transparent;
            this.infoText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoText1.Location = new System.Drawing.Point(36, 64);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(121, 90);
            this.infoText1.TabIndex = 5;
            this.infoText1.Text = "Без пополнения\r\nБез снятия\r\nБез капитализации\r\n\r\nМинимальный срок\r\nот 3 месяцев";
            this.infoText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(352, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 224);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(74, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "годовых";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(20, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "5%";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 90);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пополняемый\r\nЕсть возможность снятия\r\nС капитализацией\r\n\r\nМинимальный срок\r\nот 6 " +
    "месяцев";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оптимальный";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox2.Location = new System.Drawing.Point(336, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 224);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(573, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 224);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(74, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "годовых";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(20, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "6%";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(40, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 90);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пополняемый\r\nБез снятия\r\nБез капитализации\r\n\r\nМинимальный срок\r\nот 3 месяцев";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(40, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Стандарт";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox3.Location = new System.Drawing.Point(557, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(192, 224);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // nextSlide1
            // 
            this.nextSlide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nextSlide1.FlatAppearance.BorderSize = 0;
            this.nextSlide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSlide1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextSlide1.ForeColor = System.Drawing.Color.White;
            this.nextSlide1.Location = new System.Drawing.Point(336, 290);
            this.nextSlide1.Name = "nextSlide1";
            this.nextSlide1.Size = new System.Drawing.Size(208, 34);
            this.nextSlide1.TabIndex = 10;
            this.nextSlide1.Text = "Рассчитать доход";
            this.nextSlide1.UseVisualStyleBackColor = false;
            this.nextSlide1.Click += new System.EventHandler(this.nextSlide1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox4.Location = new System.Drawing.Point(336, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(208, 34);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // mainPanel1
            // 
            this.mainPanel1.Controls.Add(this.panel2);
            this.mainPanel1.Controls.Add(this.panel1);
            this.mainPanel1.Controls.Add(this.nextSlide1);
            this.mainPanel1.Controls.Add(this.pictureBox4);
            this.mainPanel1.Controls.Add(this.panel3);
            this.mainPanel1.Controls.Add(this.pictureBox1);
            this.mainPanel1.Controls.Add(this.pictureBox3);
            this.mainPanel1.Controls.Add(this.pictureBox2);
            this.mainPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(828, 379);
            this.mainPanel1.TabIndex = 12;
            this.mainPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 379);
            this.Controls.Add(this.mainPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mainPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countText1;
        private System.Windows.Forms.Label yearText1;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button nextSlide1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel mainPanel1;
    }
}

