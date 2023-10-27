using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _0003_перевірка_про_закінчення
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = "notepad.exe";

            childProcess.EnableRaisingEvents = true;
            childProcess.Exited += new EventHandler(childProcess_Exited);

            try
            {
                childProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void childProcess_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("Дочірній процес завершено!");
        }
    }
}