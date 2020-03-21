using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TafelsOefenen
{
    public partial class Defauft : System.Web.UI.Page
    {
        int punten = 0;
        private void Page_Load()
        {
            if (!IsPostBack)
            {
                ViewState["data"] = punten;
            }
        }
        protected void btnVraagMe_Click(object sender, EventArgs e)
        {
            lblRandomGetal.Text = Convert.ToString(Random());
            lblSelectedItem.Text = Convert.ToString(DropDownList1.SelectedItem);
        }

        public int Random()
        {
            int x;          
            Random ran = new Random();
            x = ran.Next(1, 10);
            return x;
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lblRandomGetal.Text);
            int b = int.Parse(lblSelectedItem.Text);
            int Uitkomt = a * b;
            int Invoer = int.Parse(txtUikomt.Text);


            if (Uitkomt == Invoer)
            {
                lblGoedFout.Text = "Goed geantwoord!! Je hebt een 1 punt verdient!";
                txtUikomt.Text = "";
                punten = (int)ViewState["data"];
                lblPunten.Text = (++punten).ToString();
                ViewState["data"] = punten;

                    
            }

            else
            {
                lblGoedFout.Text = "Niet goed geantwoord helaas. Probeer opnieuw";
            }
        }
    }
}