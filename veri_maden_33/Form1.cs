using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_maden_33
{
    public partial class Form1 : Form
    {

        Graphics drawArea;

        public Form1()
        {
            InitializeComponent();

            drawArea = drawingArea.CreateGraphics();
        }

        public static int[,] dizi = { { 0 , 1 , 3 , 3 , 1 },
                                      { 1 , 0 , 1 , 2 , 2 },
                                      { 3 , 1 , 0 , 1 , 2 },
                                      { 3 , 2 , 1 , 0 , 1 },
                                      { 1 , 2 , 2 , 1 , 0 }};

        public static  string[] eleman;


        private void btn_hesap_Click(object sender, EventArgs e)
        {
            int[,] dizi =           { { 0 , 1 , 3 , 3 , 1 },
                                      { 1 , 0 , 1 , 2 , 2 },
                                      { 3 , 1 , 0 , 1 , 2 },
                                      { 3 , 2 , 1 , 0 , 1 },
                                      { 1 , 2 , 2 , 1 , 0 }};

            drawingArea.Refresh();

            int k = Convert.ToInt32(nud_k.Value);


            for (int i = 0; i < dizi.Length/5; i++)
            {
                for (int j = 0; j < dizi.Length/5; j++)
                {
                    if (dizi[i,j]<=k)
                    {

                        ciz(i, j);
                        //kumele(i, j);
                    }
                }
            }
            
        }
        public void ciz(int i,int j)
        {
            Pen Blackpen = new Pen(Color.Black);

                    drawArea.DrawLine(Blackpen,
                        ((Label)this.Controls["label" + (i).ToString()]).Location.X,
                        ((Label)this.Controls["label" + (i).ToString()]).Location.Y,
                        ((Label)this.Controls["label" + (j).ToString()]).Location.X,
                        ((Label)this.Controls["label" + (j).ToString()]).Location.Y);


        }
        public void kumele(int i, int j)
        {
            eleman[i] = (i.ToString() + "," + j.ToString());
            MessageBox.Show(((Label)this.Controls["label" + (i).ToString()]).Text + "," + ((Label)this.Controls["label" + (j).ToString()]).Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_tablo.Items.Add("      A   B   C   D   E ");
            lb_tablo.Items.Add(" A !  0 , 1 , 3 , 3 , 1 ");
            lb_tablo.Items.Add(" B !  1 , 0 , 1 , 2 , 2 ");
            lb_tablo.Items.Add(" C !  3 , 1 , 0 , 1 , 2 ");
            lb_tablo.Items.Add(" D !  3 , 2 , 1 , 0 , 1 ");
            lb_tablo.Items.Add(" E !  1 , 2 , 2 , 1 , 0 ");
        }
       
    }
}
