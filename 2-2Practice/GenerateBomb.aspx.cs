using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        void bombxy(ref int x, ref int y,int bomb) {
            x = bomb / 10;
            y = bomb % 10;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] bomb = new int[10] { 0,7,13,28, 44, 62, 74, 75, 87,90 };
            int x=0, y=0,z=0;
            string[,] bomb2 = new string[10, 10];
            int[,] bomb3 = new int[10, 10];
            Response.Write("<table border=4>");
            for (int i = 0; i < bomb.Length; i++) {
                bombxy(ref x, ref y, bomb[i]);
                bomb2[x, y] = "*";
                if ((x - 1) >= 0)
                {
                    if ((y - 1) >= 0)
                    {
                        bomb3[x - 1, y - 1] +=1;
                        z = bomb3[x - 1, y - 1] ;
                        bomb2[x-1, y-1] =z.ToString();
                    }
                    if ((y + 1) <= 9)
                    {
                        bomb3[x - 1, y + 1] += 1;
                        z = bomb3[x - 1, y + 1] ;
                        bomb2[x - 1, y + 1] = z.ToString();
                    }
                    bomb3[x - 1, y] += 1;
                    z = bomb3[x - 1, y ] ;
                    bomb2[x - 1, y] = z.ToString();
                }
                if ((x + 1) <= 9){
                    if ((y - 1) >= 0)
                    {
                        bomb3[x + 1, y - 1] += 1;
                        z = bomb3[x + 1, y - 1] ;
                        bomb2[x + 1, y - 1] = z.ToString();
                    }
                    if ((y + 1) <= 9)
                    {
                        bomb3[x + 1, y + 1] += 1;
                        z = bomb3[x + 1, y + 1] ;
                        bomb2[x + 1, y +1] = z.ToString();
                    }
                    bomb3[x + 1, y] += 1;
                    z = bomb3[x + 1, y ] ;
                    bomb2[x + 1, y] = z.ToString();
                }
                if ((y - 1) >= 0)
                {
                    bomb3[x, y - 1] +=1;
                    z = bomb3[x , y - 1] ;
                    bomb2[x , y - 1] = z.ToString();
                }
                if ((y + 1) <= 9)
                {
                    bomb3[x, y + 1] += 1;
                    z = bomb3[x , y + 1] ;
                    bomb2[x, y + 1] = z.ToString();
                }
            }
            for (int i = 0; i < bomb.Length; i++) {
                bombxy(ref x, ref y, bomb[i]);
                bomb2[x, y] = "*";
            }
            for (x = 0; x < 10; x++) {
                Response.Write("<tr>");
                for (y = 0; y < 10; y++) {
                    Response.Write("<td>"+bomb2[x, y]);
                }
                Response.Write("</tr>");
                Response.Write("<br/>");
            }
            Response.Write("</table>");
        }
    }
}
