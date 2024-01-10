using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wed
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(tb1.Text);
            double height = double.Parse(tb2.Text);



            double bmi = weight / (height *height/ 10000);
            show.Text = "ค่า BMI ของคุณคือ: " + bmi.ToString("0.00");


            if (bmi < 18.5)
            {
                Image1.ImageUrl = " https://www.tnnthailand.com/static/details/dig2nlXWXJ-600.jpeg";
            }
            else if (bmi <= 22.9)
            {
                Image1.ImageUrl = "https://static.trueplookpanya.com/tppy/member/m_545000_547500/546742/cms/images/1-2018/%E0%B8%94%E0%B8%B2%E0%B8%A3%E0%B8%B2%E0%B8%AB%E0%B8%B8%E0%B9%88%E0%B8%99%E0%B8%94%E0%B8%B5%20%E0%B8%A1%E0%B8%B5%E0%B8%8B%E0%B8%B4%E0%B8%81%E0%B9%81%E0%B8%9E%E0%B8%84-17.jpg";
            }
            else if (bmi <= 24.9)
            {
                Image1.ImageUrl = "https://www.tvpoolonline.com/wp-content/uploads/2016/04/cb6af0b0c013129302d256521a81bc5a.jpg";
            }
            else if (bmi <= 29.9)
            {
                Image1.ImageUrl = "https://sadanduseless.b-cdn.net/wp-content/uploads/2022/01/fat-cat4.jpg";
                
                
            }
        
            else
            {

                Image1.ImageUrl = "https://ram-hosp.co.th/upload/ck/1674114955.jpg";
            }

        }
    }
}