using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //lbFormSize.Text = "";
            //Form frm1 = new Form1();

            //frm1.Width = 500;
            //frm1.Height = 500;

            ////this.Width = 500;
            ////this.Height = 500;


            //lbFormSize.Text = "หน้าจอกว้าง : " + this.Size.Width + "ความยาว :" + this.Size.Height ;
        }

        


        int i = 0;
        int j = 0;
        void Randompb()
        {
            Random rnd = new Random();


            i = rnd.Next(1, 7);
            j = rnd.Next(1, 7);

            //label1.Text = i.ToString();
            //label1.Text = label1.Text + " " + j.ToString();

            switch (i)
            {
                case 1:
                    pb1.Image = Casino.Properties.Resources.d1;
                    break;
                case 2:
                    pb1.Image = Casino.Properties.Resources.d2;
                    break;
                case 3:
                    pb1.Image = Casino.Properties.Resources.d3;
                    break;
                case 4:
                    pb1.Image = Casino.Properties.Resources.d4;
                    break;
                case 5:
                    pb1.Image = Casino.Properties.Resources.d5;
                    break;
                case 6:
                    pb1.Image = Casino.Properties.Resources.d6;
                    break;


            }
            switch (j)
            {
                case 1:
                    pb2.Image = Casino.Properties.Resources.d1;
                    break;
                case 2:
                    pb2.Image = Casino.Properties.Resources.d2;
                    break;
                case 3:
                    pb2.Image = Casino.Properties.Resources.d3;
                    break;
                case 4:
                    pb2.Image = Casino.Properties.Resources.d4;
                    break;
                case 5:
                    pb2.Image = Casino.Properties.Resources.d5;
                    break;
                case 6:
                    pb2.Image = Casino.Properties.Resources.d6;
                    break;


            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            timer1.Start();




            //pb1.Image = Casino.Properties.Resources.d2;
            //pb2.Image = Casino.Properties.Resources.d3;
        }



        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            count = count + 1;
            Randompb();
            if (count <= 30)
            {

                timer1.Stop();

                lb1.Text = $"{i + j}";

            }




        }


    }
}
