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
    public partial class ResultForm : Form
    {
        public ResultForm(int luckyNum)
        {
            InitializeComponent();
            lbl_LuckyNumber.Text = "" + luckyNum;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
