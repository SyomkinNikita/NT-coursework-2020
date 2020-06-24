namespace ComForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.b_con = new System.Windows.Forms.Button();
            this.cb_PortNames = new System.Windows.Forms.ComboBox();
            this.Open_COM_1 = new System.Windows.Forms.Button();
            this.b_ChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b_About = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.b_Connection = new System.Windows.Forms.Button();
            this.cb_PortNames2 = new System.Windows.Forms.ComboBox();
            this.Open_COM_2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Close_COM_1 = new System.Windows.Forms.Button();
            this.Close_COM_2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 467);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // b_con
            // 
            this.b_con.Enabled = false;
            this.b_con.Location = new System.Drawing.Point(503, 237);
            this.b_con.Margin = new System.Windows.Forms.Padding(4);
            this.b_con.Name = "b_con";
            this.b_con.Size = new System.Drawing.Size(428, 28);
            this.b_con.TabIndex = 4;
            this.b_con.Text = "Проверить соединение";
            this.b_con.UseVisualStyleBackColor = true;
            this.b_con.Click += new System.EventHandler(this.b_con_Click);
            // 
            // cb_PortNames
            // 
            this.cb_PortNames.FormattingEnabled = true;
            this.cb_PortNames.Location = new System.Drawing.Point(503, 37);
            this.cb_PortNames.Margin = new System.Windows.Forms.Padding(4);
            this.cb_PortNames.Name = "cb_PortNames";
            this.cb_PortNames.Size = new System.Drawing.Size(187, 24);
            this.cb_PortNames.TabIndex = 6;
            this.cb_PortNames.SelectedIndexChanged += new System.EventHandler(this.cb_PortNames_SelectedIndexChanged);
            // 
            // Open_COM_1
            // 
            this.Open_COM_1.Location = new System.Drawing.Point(503, 80);
            this.Open_COM_1.Margin = new System.Windows.Forms.Padding(4);
            this.Open_COM_1.Name = "Open_COM_1";
            this.Open_COM_1.Size = new System.Drawing.Size(188, 28);
            this.Open_COM_1.TabIndex = 7;
            this.Open_COM_1.Text = "Открыть порт";
            this.Open_COM_1.UseVisualStyleBackColor = true;
            this.Open_COM_1.Click += new System.EventHandler(this.open_com_1);
            // 
            // b_ChooseFile
            // 
            this.b_ChooseFile.Location = new System.Drawing.Point(648, 372);
            this.b_ChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.b_ChooseFile.Name = "b_ChooseFile";
            this.b_ChooseFile.Size = new System.Drawing.Size(283, 28);
            this.b_ChooseFile.TabIndex = 8;
            this.b_ChooseFile.Text = "Отправить файл";
            this.b_ChooseFile.UseVisualStyleBackColor = true;
            this.b_ChooseFile.Visible = false;
            this.b_ChooseFile.Click += new System.EventHandler(this.b_ChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "COM 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b_About
            // 
            this.b_About.Location = new System.Drawing.Point(743, 454);
            this.b_About.Margin = new System.Windows.Forms.Padding(4);
            this.b_About.Name = "b_About";
            this.b_About.Size = new System.Drawing.Size(188, 28);
            this.b_About.TabIndex = 11;
            this.b_About.Text = "О программе";
            this.b_About.UseVisualStyleBackColor = true;
            this.b_About.Click += new System.EventHandler(this.b_About_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(743, 302);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 28);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // b_Connection
            // 
            this.b_Connection.Location = new System.Drawing.Point(503, 191);
            this.b_Connection.Margin = new System.Windows.Forms.Padding(4);
            this.b_Connection.Name = "b_Connection";
            this.b_Connection.Size = new System.Drawing.Size(428, 28);
            this.b_Connection.TabIndex = 13;
            this.b_Connection.Text = "Установить соединение";
            this.b_Connection.UseVisualStyleBackColor = true;
            this.b_Connection.Click += new System.EventHandler(this.b_Connection_Click);
            // 
            // cb_PortNames2
            // 
            this.cb_PortNames2.FormattingEnabled = true;
            this.cb_PortNames2.Location = new System.Drawing.Point(744, 37);
            this.cb_PortNames2.Margin = new System.Windows.Forms.Padding(4);
            this.cb_PortNames2.Name = "cb_PortNames2";
            this.cb_PortNames2.Size = new System.Drawing.Size(187, 24);
            this.cb_PortNames2.TabIndex = 14;
            // 
            // Open_COM_2
            // 
            this.Open_COM_2.Location = new System.Drawing.Point(743, 80);
            this.Open_COM_2.Margin = new System.Windows.Forms.Padding(4);
            this.Open_COM_2.Name = "Open_COM_2";
            this.Open_COM_2.Size = new System.Drawing.Size(188, 28);
            this.Open_COM_2.TabIndex = 15;
            this.Open_COM_2.Text = "Открыть порт";
            this.Open_COM_2.UseVisualStyleBackColor = true;
            this.Open_COM_2.Click += new System.EventHandler(this.Open_com_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "COM 2";
            // 
            // Close_COM_1
            // 
            this.Close_COM_1.Enabled = false;
            this.Close_COM_1.Location = new System.Drawing.Point(503, 132);
            this.Close_COM_1.Margin = new System.Windows.Forms.Padding(4);
            this.Close_COM_1.Name = "Close_COM_1";
            this.Close_COM_1.Size = new System.Drawing.Size(188, 28);
            this.Close_COM_1.TabIndex = 17;
            this.Close_COM_1.Text = "Закрыть порт";
            this.Close_COM_1.UseVisualStyleBackColor = true;
            this.Close_COM_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close_COM_2
            // 
            this.Close_COM_2.Enabled = false;
            this.Close_COM_2.Location = new System.Drawing.Point(743, 132);
            this.Close_COM_2.Margin = new System.Windows.Forms.Padding(4);
            this.Close_COM_2.Name = "Close_COM_2";
            this.Close_COM_2.Size = new System.Drawing.Size(188, 28);
            this.Close_COM_2.TabIndex = 18;
            this.Close_COM_2.Text = "Закрыть порт";
            this.Close_COM_2.UseVisualStyleBackColor = true;
            this.Close_COM_2.Click += new System.EventHandler(this.Close_COM_2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отправить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close_COM_2);
            this.Controls.Add(this.Close_COM_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Open_COM_2);
            this.Controls.Add(this.cb_PortNames2);
            this.Controls.Add(this.b_Connection);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.b_About);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_ChooseFile);
            this.Controls.Add(this.Open_COM_1);
            this.Controls.Add(this.cb_PortNames);
            this.Controls.Add(this.b_con);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "COMport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button b_con;
        private System.Windows.Forms.ComboBox cb_PortNames;
        private System.Windows.Forms.Button Open_COM_1;
        private System.Windows.Forms.Button b_ChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_About;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button b_Connection;
        private System.Windows.Forms.ComboBox cb_PortNames2;
        private System.Windows.Forms.Button Open_COM_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close_COM_1;
        private System.Windows.Forms.Button Close_COM_2;
        private System.Windows.Forms.Button button1;
    }
}

