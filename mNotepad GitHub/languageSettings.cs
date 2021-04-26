using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mNotepad_GitHub
{
    public partial class languageSettings : Form
    {
        public languageSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            mainForm mf = new mainForm();
            mf.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                comboBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" & comboBox1.Text != "Seç")
            {
                using (StreamWriter stw = new StreamWriter(@".\bin\settings\languageSettings.txt"))
                {
                    stw.Write(comboBox1.Text);

                    MessageBox.Show("Ayarlar Kaydedildi! Değişikliklerin geçerli olması için programın yeniden başlatılması gerek!");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Dil Seçiniz!");
            }
        }
    }
}
