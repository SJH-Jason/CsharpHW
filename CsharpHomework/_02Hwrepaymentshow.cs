using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  CsharpHomework
{
    public partial class _02Hwrepaymentshow : Form
    {
        public _02Hwrepaymentshow(string data1, string data2, string data3, string data4, string data5)
        {
            InitializeComponent();

            labshow1.Text = data1;
            labshow2.Text = data2;
            labshow3.Text = data3;
            labshow4.Text = data4;
            labshow5.Text = data5;
        }
    }
   
}
