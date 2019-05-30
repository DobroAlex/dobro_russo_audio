using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DobroRussoAudio
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!textBox3.Text.All(char.IsDigit))
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели код ОУ, содержащий не только цифры. Мы считаем, что код ОУ долже быть численным. Вы уверенны, что хотите продолжить?", 
                    "Подозритлеьный ввод кода ОУ", 
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    textBox3.Text = String.Empty;
                }
                else
                {
                    return;
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!textBox4.Text.All(char.IsDigit))
            {
                DialogResult dialogResult = MessageBox.Show("Вы ввели номер аудитории, содержащий не только цифры. Мы считаем, что номер аудитоии долже быть численным. Вы уверенны, что хотите продолжить?",
                    "Подозритлеьный ввод номера аудитории",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    textBox4.Text = String.Empty;
                }
                else
                {
                    return;
                }
            }
        }
        
        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сохранены.");
        }
        private  bool IsRegistationFormVaild() //TODO: фиксить, сейчас пропускает все элементы и всегда возвращает true что приводит
            // к включению кнопки "Сохранить параметры" даже если они битые
        {
            foreach (Control control in Controls)
            {
                TextBox tb = control as TextBox;
                if (!(tb is TextBox))
                {
                    continue;
                }
                if (string.IsNullOrWhiteSpace(tb.Text) || string.IsNullOrEmpty(tb.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            SaveSettingButton.Enabled = IsRegistationFormVaild();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            SaveSettingButton.Enabled = IsRegistationFormVaild();

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            SaveSettingButton.Enabled = IsRegistationFormVaild();

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            SaveSettingButton.Enabled = IsRegistationFormVaild();

        }
    }
}
