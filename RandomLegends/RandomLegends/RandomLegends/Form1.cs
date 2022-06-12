using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLegends
{
    public partial class RandomLegends : Form
    {
        public RandomLegends()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int k = (int)numericUpDown1.Value; //легенды
            string[] b = {"","Бладхаунд","Гибралтар","Лайфлайн","Патфайндер","Рейф","Бангалор","Каустик","Мираж","Октейн","Ваттсон","Крипто","Ревенант","Лоба","Рампарт","Хорайзон","Фьюз","Валькирия","Сиир","Эш","Мэгги",} ;
            int v = (int)numericUpDown2.Value; //игроки
            int p,m,n;

            

            Random rnd = new Random();

            if (v==0)
            {
                label1.Text += "Что? 0?"+"\n" +"Никто не будет играть?";
            }

            if (v == 1)
            {
                p = rnd.Next(1, k-1);

                label1.Text += b[p] + "\n";
            }
            if (v == 2)
            {
                
                p = rnd.Next(1, k - 1);
                m = rnd.Next(1, k - 1);
                if (b[p]==b[m])
                {
                    do
                    {
                        m = rnd.Next(1, k - 1);
                    } while (b[p] == b[m]);
                }

                label1.Text += b[p] + "\n";
                label1.Text += b[m] + "\n";
            }
            if (v == 3)
            {
                p = rnd.Next(1, k - 1);
                m = rnd.Next(1, k - 1);
                n = rnd.Next(1, k - 1);

                if (b[p] == b[m])
                {
                    do
                    {
                        m = rnd.Next(1, k - 1);
                    } while (b[p] == b[m]);
                }

                if (b[p] == b[n] | b[m] == b[n])
                {
                    do
                    {
                        n = rnd.Next(1, k - 1);
                    } while (b[m] == b[n] | b[p] == b[n]);
                }
                label1.Text += b[p] + "\n";
                label1.Text += b[m] + "\n";
                label1.Text += b[n] + "\n";
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RandomLegends_Load(object sender, EventArgs e)
        {

        }
    }
}
