namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.btnRS = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnZ1 = new System.Windows.Forms.Button();
            this.btnZ2 = new System.Windows.Forms.Button();
            this.btnZ3 = new System.Windows.Forms.Button();
            this.btnZ4 = new System.Windows.Forms.Button();
            this.btnW4 = new System.Windows.Forms.Button();
            this.btnW3 = new System.Windows.Forms.Button();
            this.btnW2 = new System.Windows.Forms.Button();
            this.btnW1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRS
            // 
            this.btnRS.Location = new System.Drawing.Point(12, 287);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(121, 46);
            this.btnRS.TabIndex = 0;
            this.btnRS.Text = "Сброс";
            this.btnRS.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущее состояние:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(309, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 46);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnZ1
            // 
            this.btnZ1.BackColor = System.Drawing.Color.Maroon;
            this.btnZ1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZ1.FlatAppearance.BorderSize = 4;
            this.btnZ1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnZ1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZ1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZ1.Location = new System.Drawing.Point(12, 41);
            this.btnZ1.Name = "btnZ1";
            this.btnZ1.Size = new System.Drawing.Size(100, 50);
            this.btnZ1.TabIndex = 5;
            this.btnZ1.Text = "Z1";
            this.btnZ1.UseVisualStyleBackColor = false;
            this.btnZ1.Click += new System.EventHandler(this.btnZ1_Click);
            // 
            // btnZ2
            // 
            this.btnZ2.BackColor = System.Drawing.Color.Maroon;
            this.btnZ2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZ2.FlatAppearance.BorderSize = 4;
            this.btnZ2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnZ2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnZ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZ2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZ2.Location = new System.Drawing.Point(118, 41);
            this.btnZ2.Name = "btnZ2";
            this.btnZ2.Size = new System.Drawing.Size(100, 50);
            this.btnZ2.TabIndex = 6;
            this.btnZ2.Text = "Z2";
            this.btnZ2.UseVisualStyleBackColor = false;
            this.btnZ2.Click += new System.EventHandler(this.btnZ2_Click);
            // 
            // btnZ3
            // 
            this.btnZ3.BackColor = System.Drawing.Color.Maroon;
            this.btnZ3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZ3.FlatAppearance.BorderSize = 4;
            this.btnZ3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnZ3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnZ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZ3.Location = new System.Drawing.Point(224, 41);
            this.btnZ3.Name = "btnZ3";
            this.btnZ3.Size = new System.Drawing.Size(100, 50);
            this.btnZ3.TabIndex = 7;
            this.btnZ3.Text = "Z3";
            this.btnZ3.UseVisualStyleBackColor = false;
            this.btnZ3.Click += new System.EventHandler(this.btnZ3_Click);
            // 
            // btnZ4
            // 
            this.btnZ4.BackColor = System.Drawing.Color.Maroon;
            this.btnZ4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZ4.FlatAppearance.BorderSize = 4;
            this.btnZ4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnZ4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnZ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZ4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZ4.Location = new System.Drawing.Point(330, 41);
            this.btnZ4.Name = "btnZ4";
            this.btnZ4.Size = new System.Drawing.Size(100, 50);
            this.btnZ4.TabIndex = 8;
            this.btnZ4.Text = "Z4";
            this.btnZ4.UseVisualStyleBackColor = false;
            this.btnZ4.Click += new System.EventHandler(this.btnZ4_Click);
            // 
            // btnW4
            // 
            this.btnW4.BackColor = System.Drawing.Color.Green;
            this.btnW4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnW4.FlatAppearance.BorderSize = 4;
            this.btnW4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnW4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnW4.Location = new System.Drawing.Point(330, 132);
            this.btnW4.Name = "btnW4";
            this.btnW4.Size = new System.Drawing.Size(100, 50);
            this.btnW4.TabIndex = 12;
            this.btnW4.Text = "W4";
            this.btnW4.UseVisualStyleBackColor = false;
            // 
            // btnW3
            // 
            this.btnW3.BackColor = System.Drawing.Color.Green;
            this.btnW3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnW3.FlatAppearance.BorderSize = 4;
            this.btnW3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnW3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnW3.Location = new System.Drawing.Point(224, 132);
            this.btnW3.Name = "btnW3";
            this.btnW3.Size = new System.Drawing.Size(100, 50);
            this.btnW3.TabIndex = 11;
            this.btnW3.Text = "W3";
            this.btnW3.UseVisualStyleBackColor = false;
            // 
            // btnW2
            // 
            this.btnW2.BackColor = System.Drawing.Color.Green;
            this.btnW2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnW2.FlatAppearance.BorderSize = 4;
            this.btnW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnW2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnW2.Location = new System.Drawing.Point(118, 132);
            this.btnW2.Name = "btnW2";
            this.btnW2.Size = new System.Drawing.Size(100, 50);
            this.btnW2.TabIndex = 10;
            this.btnW2.Text = "W2";
            this.btnW2.UseVisualStyleBackColor = false;
            // 
            // btnW1
            // 
            this.btnW1.BackColor = System.Drawing.Color.Green;
            this.btnW1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnW1.FlatAppearance.BorderSize = 4;
            this.btnW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnW1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnW1.Location = new System.Drawing.Point(12, 132);
            this.btnW1.Name = "btnW1";
            this.btnW1.Size = new System.Drawing.Size(100, 50);
            this.btnW1.TabIndex = 9;
            this.btnW1.Text = "W1";
            this.btnW1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Входные сигналы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(115, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выходные сигналы";
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(153, 307);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(135, 22);
            this.tbState.TabIndex = 15;
            this.tbState.Text = "\r\n";
            this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(444, 347);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnW4);
            this.Controls.Add(this.btnW3);
            this.Controls.Add(this.btnW2);
            this.Controls.Add(this.btnW1);
            this.Controls.Add(this.btnZ4);
            this.Controls.Add(this.btnZ3);
            this.Controls.Add(this.btnZ2);
            this.Controls.Add(this.btnZ1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRS);
            this.Name = "Form1";
            this.Text = "Колесников Вариант 11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnZ1;
        private System.Windows.Forms.Button btnZ2;
        private System.Windows.Forms.Button btnZ3;
        private System.Windows.Forms.Button btnZ4;
        private System.Windows.Forms.Button btnW4;
        private System.Windows.Forms.Button btnW3;
        private System.Windows.Forms.Button btnW2;
        private System.Windows.Forms.Button btnW1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbState;
    }
}

