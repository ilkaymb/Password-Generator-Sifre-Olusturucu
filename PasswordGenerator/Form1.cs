using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            Generate_fun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            title.Text = "Şifre Oluşturucu";
            length.Text = "Uzunluk";
            contents.Text = "İçerik";
            generate_button.Text = "Oluştur";
            copy_button.Text = "Kopyala";
            letter_checkbox.Text = "Harf";
            number_checkbox.Text = "Sayı";
            symbols_checkbox.Text = "Sembol";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            title.Text = "Password Generator";
            length.Text = "Length";
            contents.Text = "Contents";
            generate_button.Text = "Generate";
            copy_button.Text = "Copy";
            letter_checkbox.Text = "Letter";
            number_checkbox.Text = "Number";
            symbols_checkbox.Text = "Symbol";
        }
        public void password_fun(int start, int limit)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            bool trigger = false;

            int _number;
            char _letter;
            char[] symbol = new char[14] { ',', '_', ';', '.', '!', '@', '+', '-', '*', '/', '%', '$', ':', '?' };

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (trigger || (limit == 0 && start == 0))
                {
                    _number = random.Next(0, 2);
                    if (_number == 0)
                        _number = 1;
                    else
                        _number = 3;

                    if (!trigger)
                        trigger = !trigger;
                }
                else
                    _number = random.Next(start, limit);

                switch (_number)
                {
                    case 1://number;
                        _number = random.Next(0, 10);
                        sb.Append(_number.ToString());
                        break;
                    case 2://letter
                        _letter = (char)random.Next('a', 'z');
                        sb.Append(_letter.ToString());
                        break;
                    case 3://symbol
                        int symbol_number = random.Next(0, 14);
                        sb.Append(symbol[symbol_number].ToString());
                        break;
                }
            }
            maskedTextBox1.Text = sb.ToString();


        }
        public void Generate_fun()
        {
            Random random = new Random();

            switch (condition_checker())
            {
                case 1:
                    password_fun(1, 4);
                    break;
                case 2:
                    password_fun(0, 0);
                    break;
                case 3:
                    password_fun(1, 3);
                    break;
                case 4:
                    password_fun(1, 2);
                    break;
                case 5:
                    password_fun(2, 4);
                    break;
                case 6:
                    password_fun(3, 4);
                    break;
                case 7:
                    password_fun(2, 3);
                    break;
                case 0:
                    MessageBox.Show("Lütfen içeriği boş bırakmayın");
                    break;
            }



            int sayi = random.Next(0, 51);//1.deger dahil ikinci degeri dahil degil.
        }

        public int condition_checker()
        {
            if (number_checkbox.Checked == true && letter_checkbox.Checked == true && symbols_checkbox.Checked == true)
            {
                return 1;
            }
            else if (number_checkbox.Checked == true && letter_checkbox.Checked != true && symbols_checkbox.Checked == true)
            {
                return 2;
            }
            else if (number_checkbox.Checked == true && letter_checkbox.Checked == true && symbols_checkbox.Checked != true)
            {
                return 3;
            }
            else if (number_checkbox.Checked == true && letter_checkbox.Checked != true && symbols_checkbox.Checked != true)
            {
                return 4;
            }
            else if (number_checkbox.Checked != true && letter_checkbox.Checked == true && symbols_checkbox.Checked == true)
            {
                return 5;
            }
            else if (number_checkbox.Checked != true && letter_checkbox.Checked != true && symbols_checkbox.Checked == true)
            {
                return 6;
            }
            else if (number_checkbox.Checked != true && letter_checkbox.Checked == true && symbols_checkbox.Checked != true)
            {
                return 7;
            }

            return 0;
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(maskedTextBox1.Text);
        }
        
    }
}
