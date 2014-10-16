using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace create_member
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsCenterDataSet_MemberIcNumber_And_MemberID.MemberDetails' table. You can move, or remove it, as needed.
            this.memberDetailsTableAdapter.Fill(this.sportsCenterDataSet_MemberIcNumber_And_MemberID.MemberDetails);

        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
