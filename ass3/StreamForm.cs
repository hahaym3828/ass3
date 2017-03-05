using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass3
{
    public partial class StreamForm : Form
    {
        public StreamForm(String Cost,String Title)
        {

            /* (This suppose to pass the grand total and title data into the label but idk why the datas are null)
             * 
            CostLabel.Text = Cost;
            TitleLabel.Text = Title;
            */
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
