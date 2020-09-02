using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kocsikázás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ora1_Tick(object sender, EventArgs e)
        {
            csikMozgas(gyorsasag);
            ellensegek(gyorsasag + 5);
        }

        void csikMozgas(int sebesseg)
        {
            if (csik1.Top >= 410)
            {
                csik1.Top = -50;
            }
            else csik1.Top += sebesseg;

            if (csik2.Top >= 410)
            {
                csik2.Top = -50;
            }
            else csik2.Top += sebesseg;

            if (csik3.Top >= 410)
            {
                csik3.Top = -50;
            }
            else csik3.Top += sebesseg;

            if (csik4.Top >= 410)
            {
                csik4.Top = -50;
            }
            else csik4.Top += sebesseg;

            if (csik5.Top >= 410)
            {
                csik5.Top = -50;
            }
            else csik5.Top += sebesseg;

            if (csik6.Top >= 410)
            {
                csik6.Top = -50;
            }
            else csik6.Top += sebesseg;

            if (csik7.Top >= 410)
            {
                csik7.Top = -50;
            }
            else csik7.Top += sebesseg;

            if (csik8.Top >= 410)
            {
                csik8.Top = -50;
            }
            else csik8.Top += sebesseg;

            if (csik9.Top >= 410)
            {
                csik9.Top = -50;
            }
            else csik9.Top += sebesseg;

            if (csik10.Top >= 410)
            {
                csik10.Top = -50;
            }
            else csik10.Top += sebesseg;

            if (csik11.Top >= 410)
            {
                csik11.Top = -50;
            }
            else csik11.Top += sebesseg;

            if (csik12.Top >= 410)
            {
                csik12.Top = -50;
            }
            else csik12.Top += sebesseg;


        }

        Random vel = new Random();
        int x;
        int sav;

        void ellensegek(int sebesseg)
        {
            sav = vel.Next(1, 3);
            if (ellenseg1.Top >= 410)
            {
                x = vel.Next(0, 150);
                ellenseg1.Location = new Point(x, -50);
            }
            else ellenseg1.Top += sebesseg;
        }

        int gyorsasag = 10;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (kocsi.Left > 5)
                {
                    kocsi.Left += -10;
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (kocsi.Right < 350 - kocsi.Width)
                {
                    kocsi.Left += 10;
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (gyorsasag < 21)
                {
                    gyorsasag++;
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (gyorsasag > 0)
                {
                    gyorsasag--;
                }
            }

        }
    }
}
