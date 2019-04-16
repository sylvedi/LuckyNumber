//Sylvanus Edi
//This is my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class Form1 : Form
    {
        int[] days31 = new int[31];
        int[] days29 = new int[29];
        int[] days30 = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =1920; i < 2020; i++)
            {
                year.Items.Add(i);
            }
            
            this.month.Items.AddRange(new object[12] { "January", "Febuary", "March", "April", "May", "June", "July", "Auguest", "September", "October", "November", "December" });

            this.color.Items.AddRange(new object[10] { "White","Black","Green","Blue","Gold","Silver","Yellow","Orange","Pink","Purple",});
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (month.SelectedIndex == 0 || month.SelectedIndex == 2 || month.SelectedIndex == 6 || month.SelectedIndex == 7
                 || month.SelectedIndex == 9 || month.SelectedIndex == 11)
            {
                for (int i = 0; i < days31.Length; i++)
                {
                    days31[i] = i + 1;
                }
                this.day.DataSource = days31;
            }

            if (month.SelectedIndex == 1)
            {
                for (int i = 0; i < days29.Length; i++)
                {
                    days29[i] = i + 1;
                }
                this.day.DataSource = days29;
            }
        }

        private void getLuckyNum_Click(object sender, EventArgs e)
        {
            int luckynumber = getNumber(

                (int)year.SelectedItem,
                (int)month.SelectedIndex +1,
                (int)day.SelectedItem);
                
            
            //calling the Result form
            ResultForm display = new ResultForm(luckynumber);
         
            
            //display the ResultForm
            display.ShowDialog();
        }

        public int getNumber(int year, int month, int day)
        {
            int luckynumber = ((year * month) + day);
           
            return luckynumber;

        }
    }
}
//feburary have 28 days
//jan, march, may3, july7, aug8,oct10, dec12 have 31
//april
