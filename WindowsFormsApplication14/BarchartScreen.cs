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
    public partial class BarchartScreen : Form
    {
        public BarchartScreen()
        {
            InitializeComponent();
        }

        private void BarchartScreen_Load(object sender, EventArgs e)
        {
            Avialibilities ds = new Avialibilities();
            AvialibilitiesTableAdapters.SlotAvailabilityTableAdapter ta = new AvialibilitiesTableAdapters.SlotAvailabilityTableAdapter();

            ta.Fill(ds.SlotAvailability);
            CrystalReport1 GVreports = new CrystalReport1();


            GVreports.SetDataSource(ds);

            crystalReportViewer1.ReportSource = GVreports;
           
        }
    }
}
