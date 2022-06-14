﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPTCHATest
{
    public partial class Win : Form
    {
        // Содержимое капчи
        private string text = string.Empty;

        public Win()
        {
            InitializeComponent();
        }

        private Bitmap CreateImage(int width, int height)
        {
            Random random = new Random();

            Bitmap result = new Bitmap(width, height);

            // Случайная позиция текста
            int Xpos = random.Next(0, width - 80);
            int Ypos = random.Next(24, height - 24);

            // Цвета для тектса
            Brush[] colors =
            {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green
            };

            // Чтобы рисовать в картинке
            Graphics g = Graphics.FromImage(result);

            // Фон картинки
            g.Clear(Color.Gray);

            text = string.Empty;

            if (checkBoxLetters.Checked)
            {
                string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
                    for (int i = 0; i < 5; i++)
                        text += ALF[random.Next(ALF.Length)];
            }
            else
            {
                text = random.Next(10000, 99999).ToString();
            }

            // Рисует текст
            g.DrawString(
                text,
                new Font("Arial", 24),
                colors[random.Next(colors.Length)],
                new PointF(Xpos, Ypos));

            // Рисуем диагонали
            g.DrawLine(
                Pens.Black,
                new Point(0, 0),
                new Point(width - 1, height - 1));
            g.DrawLine(
                Pens.Black,
                new Point(0, height - 1),
                new Point(width - 1, 0));

            // Усложняем чтение картинки точками
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    if (random.Next() % 10 == 0)
                        result.SetPixel(x, y, Color.White);

            return result;
        }

        private void ButtonGeneration_Click(object sender, EventArgs e)
        {
            pictureBox.Image = CreateImage(pictureBox.Width, pictureBox.Height);
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (textBox.Text == text)
                MessageBox.Show("Всё верно!");
            else
                MessageBox.Show("Неправильно!");
        }
    }
}
