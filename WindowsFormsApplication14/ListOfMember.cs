using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class ListOfMember : Form
    {
        public ListOfMember()
        {
            InitializeComponent();
        }

        private void ListOfMember_Load(object sender, EventArgs e)
        {
            ListOfMemberDataSet1 ds = new ListOfMemberDataSet1();
            ListOfMemberDataSet1TableAdapters.MemberDetailsTableAdapter ta = new ListOfMemberDataSet1TableAdapters.MemberDetailsTableAdapter();

            ta.Fill(ds.MemberDetails);
            ListOfMemberReports memberlistReports = new ListOfMemberReports();
            memberlistReports.SetDataSource(ds);

            crystalReportViewer1.ReportSource = memberlistReports;

        }
    }
}
