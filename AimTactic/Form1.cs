using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimTactic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time = 60;
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = time.ToString();

            if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show($"Time is up! Score: {score}");
                Application.Restart();
            }
        }

        private void picAim_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            pnlFail.Enabled = true;
            Random random = new Random();

            score++;
            lblScoreValue.Text = score.ToString();
            
            int point_X = random.Next(50, 600);
            picAim.Location = new Point(point_X, picAim.Location.Y);

            int point_Y = random.Next(100, 350);
            picAim.Location = new Point(picAim.Location.X, point_Y);
        }

        int fail = 5;
        private void pnlFail_MouseDown(object sender, MouseEventArgs e)
        {
            fail--;
            lblFailValue.Text = fail.ToString();

            if (fail == 0)
            {
                timer1.Stop();
                MessageBox.Show($"You Lost! Score: {score}");
                Application.Restart();
            }
        }
    }
}
