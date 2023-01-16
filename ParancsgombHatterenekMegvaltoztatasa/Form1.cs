using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParancsgombHatterenekMegvaltoztatasa
{
    public partial class Form1 : Form
    {
        int sorokSzama = 3;
        int oszlopokSzama = 6;
        int pictureBoxSize = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.SetBounds(j * pictureBoxSize, i * pictureBoxSize, pictureBoxSize, pictureBoxSize);
                    pb.Text = (i * oszlopokSzama + j).ToString();
                    pb.BackColor = Color.LightGray;
                    pb.Click += (o, ev) =>
                    {
                        PictureBox pic = (PictureBox)o;
                        pic.BackgroundImage = Properties.Resources._3b921c51dc99d9fb2be192af3ec14f72;
                        pic.BackgroundImageLayout = ImageLayout.Zoom;
                    };
                    panel_gomb.Controls.Add(pb);
                }
            }
        }
    }
}
