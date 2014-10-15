using System;
using System.Collections;
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
    public partial class Search : Form
    {

        public SearchController mCallerSearch;
        public Search(SearchController sc)
        {
            mCallerSearch = sc;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SportsCenterEntities 
            //SportsCenterEntities context = new SportsCenterEntities();
            //// dataGridView1.DataSource = context.Customers.ToList();

            //var query = from x in context.SportsFacilityDetails
  
            //        select x;
            
            ////SportsFacilityDetail c = query.First<SportsFacilityDetail>();


            //ArrayList EquipmentDetails = new ArrayList();
            //foreach (SportsFacilityDetail c in query.ToList())
            //{

            //    EquipmentDetails.Add(new EquipmentDetails(c.EqipmentName, c.EquipmentID));
            // //   comboBox2.Items.Add(new Item(c.EqipmentName, c.EquipmentID));

            //}

            comboBox2.DisplayMember = "EqipmentName";
            comboBox2.ValueMember = "EquipmentID";

            comboBox2.DataSource = mCallerSearch.populateSearchScreen();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mCallerSearch.checkAvailability(comboBox2.SelectedValue.ToString(), comboBox1.SelectedIndex))
            {
                // if it returns true,
                // then updates the UI
                lblAvailabilityStatus.Text = "Available";
                lblAvailabilityStatus.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                //else update the Ui
                lblAvailabilityStatus.Text = "N/A";
                lblAvailabilityStatus.BackColor = System.Drawing.Color.Red;
            }
            dataGridView1.DataSource = mCallerSearch.fillByEquipment(comboBox2.SelectedValue.ToString(),comboBox1.SelectedIndex);
            dataGridView2.DataSource = mCallerSearch.fillBySlot(comboBox2.SelectedValue.ToString(), comboBox1.SelectedIndex);
           
           // SportsCenterEntities context = new SportsCenterEntities();
          
           // DateTime today = DateTime.Now;
           // DateTime tomorrow = today.AddDays(1);
           //int selectId=Convert.ToInt32(comboBox2.SelectedValue.ToString());
           //int maximumCount=context.SportsFacilityDetails.Where(f => f.EquipmentID == selectId).Select(f => f.EquipmentCount).FirstOrDefault();
            
           // var query = from x in context.SlotAvailabilities
           //             where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId
           //             select new { x.Date, Equipment = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EqipmentName)).FirstOrDefault(),
           //                          Slot1 =  maximumCount-x.Slot1,
           //                          Slot2 =  maximumCount-x.Slot2,
           //                          Slot3 =  maximumCount-x.Slot3,
           //                          Slot4 =  maximumCount-x.Slot4,
           //                          Slot5 =  maximumCount-x.Slot5,
           //                          Slot6 =  maximumCount-x.Slot6,
           //                          Slot7 =  maximumCount-x.Slot7,
           //                          Slot8 =  maximumCount-x.Slot8,
           //                          Slot9 =  maximumCount-x.Slot9,
           //                          Slot10 =  maximumCount-x.Slot10,
           //                          Slot11 =  maximumCount-x.Slot11,
           //                          Slot12 =  maximumCount-x.Slot12
           //             };
                      //  select x.Date;
            /*
               Slot1 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot1), 
                            Slot2 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot2),
                            Slot3 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot3),
                                     Slot4 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot4),
                                     Slot5 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot5),
                                     Slot6 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot6),
                                     Slot7= (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f=>f.EquipmentCount).FirstOrDefault()-x.Slot7),
                                     Slot8 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot8),
                                     Slot9 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot9),
                                      Slot10=(context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f=>f.EquipmentCount).FirstOrDefault()-x.Slot10),
                                     Slot11 = (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount).FirstOrDefault() - x.Slot11),
                                    
             */

           // dataGridView1.DataSource = query.ToList();
           
            //dataGridView1.DataSource = context.SlotAvailabilities.ToList();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
