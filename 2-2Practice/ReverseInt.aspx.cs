using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class ReverseInt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 1254;
            string n_str = N.ToString();
            var r = n_str.Reverse().ToArray();
            n_str = new string(r);
            int n_int = int.Parse(n_str);
            Response.Write(n_int);
        }
    }
}
