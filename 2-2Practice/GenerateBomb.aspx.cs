﻿using System;
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
            int x=0, y=0;
            int[,] bomb2 = new int[10, 10];
            for (x = 0; x < bomb.Length; x++) {
                bombxy(ref x, ref y, bomb[x]);
                bomb2[x, y] = -1;

            }
            for (x = 0; x < 10; x++) {
                for (y = 0; y < 10; y++) {
                    Response.Write("<br/>");
                }
            }
        }
    }
}