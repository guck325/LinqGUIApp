using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIApp
{
    static private List<Product> products = new List<Product>()
    {
        new Product(){Name = "맥북", Price = 1200},
        new Product(){Name = "헤드셋", Price = 2000},
        new Product(){Name = "집", Price = 4000},
        new Product(){Name = "베이스", Price = 5000},
        new Product(){Name = "a", Price = 12000},
        new Product(){Name = "b", Price = 100 },
        new Product(){Name = "c", Price = 23000},
        new Product(){Name = "d", Price = 4300},
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
