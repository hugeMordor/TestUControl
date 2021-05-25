using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLib1
{
    public partial class Form1 : Form
    {
        
        //int N = 3;
        //double[] C = { 2, 2, -1, 2};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.InitGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.SetBaseRectangle(0, 0, 300, 300);
            userControl11.SetBackColor(Color.Red);
            userControl11.AddCell(10, 10, Color.Black, 1);
            userControl11.AddGraph(Color.Black, 2);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.DelCell();
            userControl11.DeleteGraph();

        }
    }
}
