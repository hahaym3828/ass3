using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author:Ming Ying
 * Student ID:20025821
 * Date:2017.3.5
 * Description : This Application is the GUI for user to watching the online 
 * Stream movie in the website Called Moive Bonanza.
 *
 * 
 * 
 */
namespace ass3
{
    public partial class SelectionForm : Form
    {
        String[] UserSelection = new String[3];
        public SelectionForm()
        {
            

            Thread s = new Thread(new ThreadStart(StartForm));
            s.Start();
            Thread.Sleep(5000);
            s.Abort();

            InitializeComponent();


        }
        public void StartForm()
        {
            Application.Run(new SplashForm());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            if(TitleBox.Text == "Season of the Witch")
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

        }

        private void MovieBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MovieBox.Text == "Season of the Witch" || MovieBox.Text == "I Am Number Four" )
            {
                CategoryBox.Text = "Sci-Fi";
            }
            if (MovieBox.Text == "The Green Hornet" || MovieBox.Text == "Death Race 2" || MovieBox.Text == "The Mechanic" || MovieBox.Text == "Sanctum" || MovieBox.Text == "The Other Woman" || MovieBox.Text == "The Eagle")
            {
                CategoryBox.Text = "Action";
            }
            if (MovieBox.Text == "The Dilemma" || MovieBox.Text == "No Strings Attahced" || MovieBox.Text == "Cedar Rapids" || MovieBox.Text == "Just Go With it")
            {
                CategoryBox.Text = "Comedy";
            }
            if (MovieBox.Text == "Company Men" || MovieBox.Text == "The Way Back" || MovieBox.Text == "Waiting For Forever" )
            {
                CategoryBox.Text = "Drama";
            }
            if (MovieBox.Text == "The Rite" )
            {
                CategoryBox.Text = "Horror";
            }
            if (MovieBox.Text == "The Roommate" )
            {
                CategoryBox.Text = "Thriller";
            }
            if (MovieBox.Text == "Gnomeo and Juliet" )
            {
                CategoryBox.Text = "Family";
            }
            if (MovieBox.Text == "Footloose" || MovieBox.Text == "Real Steel")
            {
                CategoryBox.Text = "New Releases";

            }
           
        }

        private void CategoryBox_TextChanged(object sender, EventArgs e)
        {
            TitleBox.Text = MovieBox.Text;
            if (CategoryBox.Text == "Comedy"|| CategoryBox.Text == "Drama" || CategoryBox.Text == "Thriller")
            {
                CostBox.Text = "1.99";
            }
           
            if (CategoryBox.Text == "Action"|| CategoryBox.Text == "Sci-Fi" || CategoryBox.Text == "Horror")
            {
                CostBox.Text = "2.99";
            }
            
            if (CategoryBox.Text == "Family")
            {
                CostBox.Text = "0.99";
            }
            if (CategoryBox.Text == "New Releases")
            {
                CostBox.Text = "4.99";
            }
          
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MovieBox.Text == "") {
                MessageBox.Show("Please select the movie you want to watch");


            }
            else
            {
                UserSelection[0] = TitleBox.Text;
                UserSelection[1] = CategoryBox.Text;
                UserSelection[2] = CostBox.Text;
                OrderForm Order = new OrderForm(UserSelection[0], UserSelection[1], UserSelection[2]);
                Order.Show();
                this.Hide();
            }
        }
    }
}
