using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;
using System.Data;




namespace wed
{
    public partial class WebForm2 : System.Web.UI.Page

    {

        DataTable  dt;
        void GetJSONFormUrl()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://covid19.ddc.moph.go.th/api/Deaths/round-1to2-line-list");

                dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
               
                
                //lbJSON.Text = json;
                GridView1.DataSource = dt;
                GridView1.DataBind();
                // Now parse with JSON.Net
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            GetJSONFormUrl();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GetJSONFormUrl();
        }
    }
    }