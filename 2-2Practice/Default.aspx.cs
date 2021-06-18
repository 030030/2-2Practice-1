using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int i_N = 700;
            if ((i_N % 4) == 0 || (i_N % 400) == 0 && (i_N % 100 )!= 0)
                {
                Response.Write("Y");
            }
            else
            {
                Response.Write("N");
            }
        }
    }
}
