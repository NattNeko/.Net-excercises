﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wielowatkowosc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                for(int i=0; i<100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.DarkSeaGreen, 1), new Rectangle(width, height, 10, 10));

                    Thread.Sleep(100);
                }

            })
            { IsBackground = true };
            thread.Start();
        }

        Random rd;

        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Crimson, 1), new Rectangle(width, height, 5, 15));

                    Thread.Sleep(100);
                }

            })
            { IsBackground = true };
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.RoyalBlue, 1), new Rectangle(width, height, 20, 20));

                    Thread.Sleep(100);
                }

            })
            { IsBackground = true };
            thread.Start();
        }
    }
}
