namespace DobroRussoAudio
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Aud = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OUCode = new System.Windows.Forms.Label();
            this.OUNameLabel = new System.Windows.Forms.Label();
            this.CityRegionLabel = new System.Windows.Forms.Label();
            this.SaveSettingButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListenTestRecordLabel = new System.Windows.Forms.Label();
            this.TestMicLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "ГИА-9. СОБЕСЕДОВАНИЕ ПО РУССКОМУ ЯЗЫКУ\r\nДоброверсия  0.2(30May19)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1182, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перед началом работы специалисту по работе с ПК необходимо задать параметры собес" +
    "едования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1182, 102);
            this.label3.TabIndex = 2;
            this.label3.Text = "Настройка парметров собеседования";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.Aud);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.OUCode);
            this.panel1.Controls.Add(this.OUNameLabel);
            this.panel1.Controls.Add(this.CityRegionLabel);
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 168);
            this.panel1.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(870, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(299, 32);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // Aud
            // 
            this.Aud.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Aud.Location = new System.Drawing.Point(563, 105);
            this.Aud.Name = "Aud";
            this.Aud.Size = new System.Drawing.Size(301, 50);
            this.Aud.TabIndex = 6;
            this.Aud.Text = "Номер аудитории:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(262, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 32);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(262, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(907, 32);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(262, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(907, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // OUCode
            // 
            this.OUCode.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OUCode.Location = new System.Drawing.Point(12, 109);
            this.OUCode.Name = "OUCode";
            this.OUCode.Size = new System.Drawing.Size(244, 50);
            this.OUCode.TabIndex = 2;
            this.OUCode.Text = "Код ОУ :";
            // 
            // OUNameLabel
            // 
            this.OUNameLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OUNameLabel.Location = new System.Drawing.Point(12, 57);
            this.OUNameLabel.Name = "OUNameLabel";
            this.OUNameLabel.Size = new System.Drawing.Size(244, 52);
            this.OUNameLabel.TabIndex = 1;
            this.OUNameLabel.Text = "Название ОУ :";
            // 
            // CityRegionLabel
            // 
            this.CityRegionLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityRegionLabel.Location = new System.Drawing.Point(12, 4);
            this.CityRegionLabel.Name = "CityRegionLabel";
            this.CityRegionLabel.Size = new System.Drawing.Size(244, 53);
            this.CityRegionLabel.TabIndex = 0;
            this.CityRegionLabel.Text = "Город / Район :";
            // 
            // SaveSettingButton
            // 
            this.SaveSettingButton.Enabled = false;
            this.SaveSettingButton.Location = new System.Drawing.Point(812, 407);
            this.SaveSettingButton.Name = "SaveSettingButton";
            this.SaveSettingButton.Size = new System.Drawing.Size(358, 72);
            this.SaveSettingButton.TabIndex = 4;
            this.SaveSettingButton.Text = "Сохранить параметры";
            this.SaveSettingButton.UseVisualStyleBackColor = true;
            this.SaveSettingButton.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ListenTestRecordLabel);
            this.panel2.Controls.Add(this.TestMicLabel);
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 267);
            this.panel2.TabIndex = 5;
            // 
            // ListenTestRecordLabel
            // 
            this.ListenTestRecordLabel.AutoSize = true;
            this.ListenTestRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListenTestRecordLabel.Location = new System.Drawing.Point(18, 103);
            this.ListenTestRecordLabel.Name = "ListenTestRecordLabel";
            this.ListenTestRecordLabel.Size = new System.Drawing.Size(292, 32);
            this.ListenTestRecordLabel.TabIndex = 1;
            this.ListenTestRecordLabel.Text = "Прослушайте запись";
            this.ListenTestRecordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TestMicLabel
            // 
            this.TestMicLabel.AutoSize = true;
            this.TestMicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestMicLabel.Location = new System.Drawing.Point(18, 42);
            this.TestMicLabel.Name = "TestMicLabel";
            this.TestMicLabel.Size = new System.Drawing.Size(302, 32);
            this.TestMicLabel.TabIndex = 0;
            this.TestMicLabel.Text = "Проверьте микрофон";
            this.TestMicLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SaveSettingButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "Форма регистрации";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OUCode;
        private System.Windows.Forms.Label OUNameLabel;
        private System.Windows.Forms.Label CityRegionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Aud;
        private System.Windows.Forms.Button SaveSettingButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ListenTestRecordLabel;
        private System.Windows.Forms.Label TestMicLabel;
    }
}

