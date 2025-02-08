using System.Globalization;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sec, min, hor;


        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            if (sec < 59)
            {
                sec++;
                labCronometro.Text = hor.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
            }
            else if (min < 59)
            {
                min++;
                sec = 0;
                labCronometro.Text = hor.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
            }
            else
            {
                hor++;
                sec = 0;
                min = 0;
                labCronometro.Text = hor.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
            }
        }

        private void butIniciar_Click(object sender, EventArgs e)
        {
            tmrCronometro.Enabled = true;
        }

        private void butPausar_Click(object sender, EventArgs e)
        {
            tmrCronometro.Enabled = false;
        }

        private void butReiniciar_Click(object sender, EventArgs e)
        {
            sec = 0;
            min = 0;
            hor = 0;
            labCronometro.Text = "00:00:00";
        }

        private void labCronometro_Click(object sender, EventArgs e)
        {

        }
    }
}
