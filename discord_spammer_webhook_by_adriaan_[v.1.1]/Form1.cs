using System;
using System.Windows.Forms;

namespace discord_spammer_webhook_by_adriaan__v._1._1_
{
    public partial class Form1 : Form
    {
        static string webhook = "";
        static string message = "";
        static string name = "adriaan_spammer";

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            webhook = textBox1.Text;
            message = textBox2.Text;
            if (textBox1.Text == "" || textBox2.Text == "")

                MessageBox.Show("Wypełnij wszystkie pola", "Błąd");

            else

            {

                while (true)
                {
                    spammer();
                    button2.Hide();
                }

            }
        }
        static async void spammer()
        {
            try
            {
                _ =  Http.Post(webhook, new NameValueCollection()
                {
                {
                    "username",
                    name

                },
                {
                    "content",
                    message
                },


            });
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
