using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComForm
{
    
    public partial class Form1 : Form
    {
        Connection com1 = new Connection();
        //
        Connection com2 = new Connection();

        public Form1()
        {
            InitializeComponent();
            cb_PortNames.Items.AddRange(SerialPort.GetPortNames());
            com1.MainForm = this;
            com1.ProgressBar = progressBar1;
            com2.ProgressBar = progressBar1;
            com1.b_ChooseFile = b_ChooseFile;
            com1.b_Connection = b_Connection;
            com1.b_OpenPort = Open_COM_1;
            b_con.Enabled = false;
            b_ChooseFile.Enabled = true;
            b_Connection.Enabled = false;
            richTextBox1.AppendText("Добро пожаловать!\nПеред началом работы выберите порты из списка и откройте их.\n\n");



            // Мой код пошел
            cb_PortNames2.Items.AddRange(SerialPort.GetPortNames());
            com2.b_OpenPort = Open_COM_2;
            //ток что
            com2.button1 = button1;
            //еще потом чутка
            com2.MainForm = this;

        }

        /// <summary>
        /// Пишет в лог, есть ли соединение
        /// </summary>
        private void b_con_Click(object sender, EventArgs e)
        {

            if (com1.IsConnected() && com2.IsConnected())
            {
                richTextBox1.AppendText("[" + DateTime.Now + "]: " + cb_PortNames.SelectedItem.ToString() + " и " + cb_PortNames2.SelectedItem.ToString() + ": Соединение установлено\n");

                
                b_ChooseFile.Visible = true;
                button1.Visible = true;

                if (com1.Port.PortName == "COM1")
                {
                    b_ChooseFile.Text = "Отправить на второй компьютер";
                    this.Text = "ПК №1";
                }

                if (com1.Port.PortName == "COM2")
                {
                    b_ChooseFile.Text = "Отправить на первый компьютер";
                    this.Text = "ПК №2";
                }

                if (com1.Port.PortName == "COM4")
                {
                    b_ChooseFile.Text = "Отправить на первый компьютер";
                    this.Text = "ПК №3";
                }

                if (com2.Port.PortName == "COM3")
                {
                    button1.Text = "Отправить на третий компьютер";
                }

                if (com2.Port.PortName == "COM5")
                {
                    button1.Text = "Отправить на третий компьютер";
                }

                if (com2.Port.PortName == "COM6")
                {
                    button1.Text = "Отправить на второй компьютер";
                }
            }
            else
            {
                richTextBox1.AppendText("[" + DateTime.Now + "]: " + cb_PortNames.SelectedItem.ToString() + " и " + cb_PortNames2.SelectedItem.ToString() + ": Соединение отсутствует\n");

                b_ChooseFile.Visible = false;
                button1.Visible = false;
            }

        }


        /// <summary>
        /// Открывает порт com1
        /// </summary>
        private void open_com_1(object sender, EventArgs e)
        {
            if (cb_PortNames.SelectedItem != null)
            {
                com1.Log = richTextBox1;

                com1.setPortName(cb_PortNames.SelectedItem.ToString());

                if (com1.OpenPort())
                {
                    //com1.Port.DtrEnable = true;

                    cb_PortNames.Enabled = false;

                    Open_COM_1.Enabled = false;

                    Close_COM_1.Enabled = true;

                    richTextBox1.AppendText("[" + DateTime.Now + "]: Порт " + com1.Port.PortName + " открыт\n");
                }

            }
            else
            {
                MessageBox.Show("Порт не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(com1.Port.IsOpen && com2.Port.IsOpen)
            {
                b_Connection.Enabled = true;
            }
            

        }

   

        private void b_ChooseFile_Click(object sender, EventArgs e)
        {
            Console.WriteLine(com1.Port.PortName);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (com1.IsConnected())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    com1.WriteData(openFileDialog.FileName, Connection.FrameType.FILEOK);
                    richTextBox1.ScrollToCaret();
                }
            }
            else
            {
                MessageBox.Show("Соединение отсутствует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            com1.ClosePort();
        }

        private void b_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа реализует взаимодействие 3-х ПК, соединенных через интерфейс RS-232C,\n" +
                            "с функцией передачи файлов.\n\n" +
                            "Программу разработали студенты МГТУ им. Н.Э.Баумана группы ИУ5-63:\n\n" +
                            "Богданов Д.А. (физический уровень)\n" +
                            "Попов М.А. (канальный уровень)\n" +
                            "Сёмкин Н.Е. (прикладной уровень)",
                            "О программе",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void b_Connection_Click(object sender, EventArgs e)
        {

            if ((com1.Port.IsOpen&& !com2.Port.IsOpen) || (!com1.Port.IsOpen&&com2.Port.IsOpen))
            {
                MessageBox.Show("Откройте второй порт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if((!com1.Port.DtrEnable && !com2.Port.DtrEnable) || !com1.Port.DtrEnable || !com2.Port.DtrEnable)
                {
                    com1.Port.DtrEnable = true;
                    com2.Port.DtrEnable = true;

                    b_con.Enabled = true;

                    richTextBox1.AppendText("[" + DateTime.Now + "]: Порт " + com1.Port.PortName + " и порт " + com2.Port.PortName + " готовы к передаче данных \n");

                    b_Connection.Text = "Разорвать соединение";

                    if (com1.IsConnected() && com2.IsConnected())
                    {
                        
                        b_ChooseFile.Visible = true;
                        button1.Visible = true;

                        if (com1.Port.PortName == "COM1")
                        {
                            b_ChooseFile.Text = "Отправить на второй компьютер";
                            this.Text = "ПК №1";
                        }

                        if (com1.Port.PortName == "COM2")
                        {
                            b_ChooseFile.Text = "Отправить на первый компьютер";
                            this.Text = "ПК №2";
                        }

                        if (com1.Port.PortName == "COM4")
                        {
                            b_ChooseFile.Text = "Отправить на первый компьютер";
                            this.Text = "ПК №3";
                        }

                        if (com2.Port.PortName == "COM3")
                        {
                            button1.Text = "Отправить на третий компьютер";
                        }

                        if (com2.Port.PortName == "COM5")
                        {
                            button1.Text = "Отправить на третий компьютер";
                        }

                        if (com2.Port.PortName == "COM6")
                        {
                            button1.Text = "Отправить на второй компьютер";
                        }
                    }



                }
                else
                {
                    com1.Port.DtrEnable = false;
                    com2.Port.DtrEnable = false;
                    b_Connection.Text = "Установить соединение";
                    richTextBox1.AppendText("[" + DateTime.Now + "]: Соединение было разорвано\n");
                    b_con.Enabled = false;


                    b_ChooseFile.Visible = false;
                    button1.Visible = false;
                    //b_ChooseFile.Enabled = true;
                    //button1.Enabled = true;
                }

            }

        }

           

        private void cb_PortNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Open_com_2(object sender, EventArgs e)
        {
            if (cb_PortNames2.SelectedItem != null)
            {
                com2.Log = richTextBox1;

                com2.setPortName(cb_PortNames2.SelectedItem.ToString());

                if (com2.OpenPort())
                {
                    //com2.Port.DtrEnable = true;

                    cb_PortNames2.Enabled = false;

                    Open_COM_2.Enabled = false;

                    Close_COM_2.Enabled = true;

                    richTextBox1.AppendText("[" + DateTime.Now + "]: Порт " + com2.Port.PortName + " открыт\n");
                }

            }
            else
            {
                MessageBox.Show("Порт не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (com1.Port.IsOpen && com2.Port.IsOpen)
            {
                b_Connection.Enabled = true;
            }

        }

  

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            com1.Port.Close();

            com1.Port.DtrEnable = false;

            richTextBox1.AppendText("[" + DateTime.Now + "]: Порт " + com1.Port.PortName + " закрыт\n");

            cb_PortNames.Enabled = true;

            Close_COM_1.Enabled = false;
            Open_COM_1.Enabled = true;

            b_Connection.Enabled = false;
            b_ChooseFile.Visible = false;

            b_Connection.Text = "Установить соединение";


        }

        private void Close_COM_2_Click(object sender, EventArgs e)
        {
            com2.Port.Close();

            com2.Port.DtrEnable = false;

            richTextBox1.AppendText("[" + DateTime.Now + "]: Порт " + com2.Port.PortName + " закрыт\n");

            cb_PortNames2.Enabled = true;

            Close_COM_2.Enabled = false;
            Open_COM_2.Enabled = true;

            b_Connection.Enabled = false;
            b_ChooseFile.Visible = false;

            b_Connection.Text = "Установить соединение";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (com2.IsConnected())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    com2.WriteData(openFileDialog.FileName, Connection.FrameType.FILEOK);
                    richTextBox1.ScrollToCaret();
                }
            }
            else
            {
                MessageBox.Show("Соединение отсутствует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
