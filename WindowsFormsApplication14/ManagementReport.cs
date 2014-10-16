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
    public partial class ManagementReport : Form
    {
        public ManagementReport()
        {
            InitializeComponent();
        }

        private void ManagementReport_Load(object sender, EventArgs e)
        {
            MRDataSet1 ds = new MRDataSet1();
            MRDataSet1TableAdapters.SlotAvailabilityTableAdapter ta = new MRDataSet1TableAdapters.SlotAvailabilityTableAdapter();

            ta.Fill(ds.SlotAvailability);

            MRCrystalReport1 managmentreport = new MRCrystalReport1();
            managmentreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = managmentreport;
        }
    }
}
