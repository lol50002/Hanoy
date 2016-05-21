using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        bool stats = false;
        bool pop = false;

        private void disk1_MouseMove(object sender, MouseEventArgs e)
        {
            if (stats == true)
                disk1.Location = new Point(Cursor.Position.X- this.Location.X, Cursor.Position.Y- this.Location.Y);  
            if ((peresechenierectangle(disk1,pictureBox5)&&!(peresechenierectangle(disk2,pictureBox5)&&peresechenierectangle(disk3,pictureBox5)&&peresechenierectangle(disk4,pictureBox5))))
            {
                disk1.Location = new Point(450, 450);
            }

        }

        private void disk1_MouseDown(object sender, MouseEventArgs e)
        {
            stats = true;
        }

        private void disk1_MouseUp(object sender, MouseEventArgs e)
        {
            stats = false;
        }


        private bool peresechenierectangle(PictureBox a, PictureBox b)
        {
            Rectangle yota = a.Bounds;
            Rectangle yota2 = b.Bounds;
            if (yota.IntersectsWith(yota2))
                pop = true;
            return pop;

        }

        public Form1()
        {
            InitializeComponent();
        } 


        private void Form1_Load(object sender, EventArgs e)
        {     









        }

        private void knopkapls_Click(object sender, EventArgs e)
        {
            disk4.Location = new Point(890, 341);
            disk3.Location = new Point(880, 376);
            disk2.Location = new Point(870, 411);
            disk1.Location = new Point(850, 446);
            MessageBox.Show("Ты сдался. Но не переживай. Все получится .Вот схема для постановки 4 дисков, точнее вот сайт https://ru.wikipedia.org/wiki/%D0%A5%D0%B0%D0%BD%D0%BE%D0%B9%D1%81%D0%BA%D0%B0%D1%8F_%D0%B1%D0%B0%D1%88%D0%BD%D1%8F зайди и посмотри!");
        }


    }
}
