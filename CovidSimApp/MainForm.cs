using CovidSimApp.Model2D;
using CovidSimApp.SimpleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidSimApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleModelButton_Click(object sender, EventArgs e)
        {
            var form = new SimpleModelForm();
            form.Show();
        }

        private void buttonModel2D_Click(object sender, EventArgs e)
        {
            var form = new Model2DForm();
            form.Show();
        }
    }
}
