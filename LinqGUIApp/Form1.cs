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
        new Product(){Name = "가방", Price = 12000},
        new Product(){Name = "보드", Price = 100 },
        new Product(){Name = "옷", Price = 23000},
        new Product(){Name = "간식", Price = 4300}
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              where item.Price >= 1500
                                              orderby item.Price descending
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              where item.Price >= 1500
                                              orderby item.Name ascending
                                              select item;
        }
    }
}
