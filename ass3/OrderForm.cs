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
    public partial class OrderForm : Form
    {   
        String[] User = new String[2];
        public OrderForm(String Title,String Category,String Cost)
        {
           

            InitializeComponent();
            TitleBox.Text = Title;
            CategoryBox.Text = Category;
            CostBox.Text = Cost;
            if (TitleBox.Text == "Season of the Witch")
            {
                MoviePB.Image = Properties.Resources.Season_of_the_Witch;
            }
            if (TitleBox.Text == "The Green Hornet")
            {
                MoviePB.Image = Properties.Resources.The_Green_Hornet;
            }
            if (TitleBox.Text == "The Dilemma")
            {
                MoviePB.Image = Properties.Resources.The_Dilemma;
            }
            if (TitleBox.Text == "Death Race 2")
            {
                MoviePB.Image = Properties.Resources.Death_Race_2;
            }
            if (TitleBox.Text == "Company Men")
            {
                MoviePB.Image = Properties.Resources.Company_Men;
            }
            if (TitleBox.Text == "No Strings Attahced")
            {
                MoviePB.Image = Properties.Resources.No_Strings_Attached;
            }
            if (TitleBox.Text == "The Way Back")
            {
                MoviePB.Image = Properties.Resources.The_Way_Back;
            }
            if (TitleBox.Text == "The Mechanic")
            {
                MoviePB.Image = Properties.Resources.The_Mechanic;
            }
            if (TitleBox.Text == "The Rite")
            {
                MoviePB.Image = Properties.Resources.The_Rite;
            }
            if (TitleBox.Text == "Sanctum")
            {
                MoviePB.Image = Properties.Resources.Sanctum;
            }
            if (TitleBox.Text == "The Other Woman")
            {
                MoviePB.Image = Properties.Resources.The_Other_Woman;
            }
            if (TitleBox.Text == "The Roommate")
            {
                MoviePB.Image = Properties.Resources.The_Roommate;
            }
            if (TitleBox.Text == "Waiting For Forever")
            {
                MoviePB.Image = Properties.Resources.Waiting_For_Forever;
            }
            if (TitleBox.Text == "Cedar Rapids")
            {
                MoviePB.Image = Properties.Resources.Cedar_Rapids;
            }
            if (TitleBox.Text == "Gnomeo and Juliet")
            {
                MoviePB.Image = Properties.Resources.Gnomeo_And_Juliet;
            }
            if (TitleBox.Text == "Just Go With it")
            {
                MoviePB.Image = Properties.Resources.Just_Go_With_it;
            }
            if (TitleBox.Text == "The Eagle")
            {
                MoviePB.Image = Properties.Resources.The_Eagle;
            }
            if (TitleBox.Text == "I Am Number Four")
            {
                MoviePB.Image = Properties.Resources.I_Am_Number_Four;
            }
            if (TitleBox.Text == "Footloose")
            {
                MoviePB.Image = Properties.Resources.Footloose;
            }
            if (TitleBox.Text == "Real Steel")
            {
                MoviePB.Image = Properties.Resources.Real_Steel;
            }
            CalculatePrice();

        }

        private void CalculatePrice()
        {
            SubTotalBox.Text = (double.Parse(CostBox.Text) + double.Parse(DVDBox.Text)).ToString();
            TaxBox.Text = (double.Parse(SubTotalBox.Text) * 0.13).ToString();
            GTBox.Text = (double.Parse(SubTotalBox.Text) + (double.Parse(TaxBox.Text))).ToString();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void OrderForm_Load(object sender, EventArgs e)
        {
          
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DVDCheckBox.Checked)
            {
                DVDBox.Text = "10";
                DVDBox.Visible  = true;
                DVDLabel.Visible = true;
                CalculatePrice();
            }else
            {
                DVDBox.Text = "0";
                DVDBox.Visible = false;
                DVDLabel.Visible = false;
                CalculatePrice();
            }
        }
    private void StreamButton_Click(object sender, EventArgs e)
        {
            User[0] = GTBox.Text;
            User[1] = TitleBox.Text;
            
            StreamForm S = new StreamForm(User[0],User[1]);
            S.Show();
            this.Hide();
        }
        private void DVDBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
           
            SelectionForm s = new SelectionForm();
            s.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GTBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
