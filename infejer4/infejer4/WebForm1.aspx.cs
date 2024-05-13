using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace infejer4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nom= Request.Params["nom"].ToString();
            string ap = Request.Params["ap"].ToString();
            Response.Write("Nombre  " + nom);
            Response.Write("Apellido   "  + ap);
        }
    }
};