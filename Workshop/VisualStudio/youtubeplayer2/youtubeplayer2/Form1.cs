using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubeplayer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntPlay_Click(object sender, EventArgs e)
        {

            string yourString = textVDOLink.Text;
            int text_len = yourString.Length;
            int position1 = yourString.IndexOf("=")+1;
            string vdo_query = yourString.Substring(position1,text_len-position1);


            string html = "<html> <head>";
            html += " <meta content='IE=Edge' http-equiv='X-UA-Compatible'></meta> ";
            html += " <iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen > </iframe> ";
            html += " </head>  </html> ";

            //textVDOLink.Text = string.Format(html, vdo_query); 

            this.webVDO.DocumentText = string.Format(html,vdo_query);

        }


    }
}
