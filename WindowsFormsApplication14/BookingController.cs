using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication14
{
   public class BookingController
    {
       SportsCenterEntities context;
       public BookingController()
       {
           BookingUI book = new BookingUI(this);
           book.Show();
       }

       public bool checkDidAlreadyBooked(String selectedIcNumber, string selectedEquipmentId, int selectedSlotId)
       {
           bool bookedStatus = false;

           DateTime today = DateTime.Now;
           DateTime tomorrow = today.AddDays(1);
           int selectId = Convert.ToInt32(selectedEquipmentId);
           int result;
           try
           {
               var query = from x in context.BookingDetailsTables
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot ==(selectedSlotId)
                           select x;
             
               result = query.FirstOrDefault().BookingID;
               bookedStatus = true;
           }
           catch (Exception e1)
           {
               bookedStatus = false;
           }



           return bookedStatus;
       }
       public bool updateBookingDetailsTable(String selectedIcNumber, string selectedEquipmentId, int selectedSlotId)
       {
           bool insertStatus = false;
           DateTime today = DateTime.Now;
           DateTime tomorrow = today.AddDays(1);
           int selectId = Convert.ToInt32(selectedEquipmentId);
           try
           {

               BookingDetailsTable c = new BookingDetailsTable();
              c.Date=tomorrow;
              c.EquipmentID = selectId;
               c.ICNumber=selectedIcNumber;
               c.Slot = selectedSlotId;
            
               context.BookingDetailsTables.Add(c);
               context.SaveChanges();
               insertStatus = true;
           }
           catch (Exception e1)
           {
               insertStatus = false;
           }



           return insertStatus;
       }
       public bool BookSlot(String selectedIcNumber, string selectedEquipmentId, int selectedSlotId)
       {
           bool bookedStatus = false;
           int selectId = Convert.ToInt32(selectedEquipmentId);
           DateTime today = DateTime.Now;
           DateTime tomorrow = today.AddDays(1);

           context = new SportsCenterEntities();
           if (selectedSlotId == 0)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot1 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot1 = c.Slot1 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e1)
               {
                   bookedStatus = false;
               }

           }
           else if (selectedSlotId == 1)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot2 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               { 
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot2 = c.Slot2 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e2) {
                   bookedStatus = false;
               }
              
           }
           else if (selectedSlotId == 2)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot3 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot3 = c.Slot3 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e3) { bookedStatus = false; }
           }
           else if (selectedSlotId == 3)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot4 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot4 = c.Slot4 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e4) { bookedStatus = false; }
           }
           else if (selectedSlotId == 4)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot5 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot5 = c.Slot5 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e5) { bookedStatus = false; }
           }
           else if (selectedSlotId == 5)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot6 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot6 = c.Slot6 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e6) { bookedStatus = false; }
           }
           else if (selectedSlotId == 6)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot7 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot7 = c.Slot7 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e61) { bookedStatus = false; }
               }
           else if (selectedSlotId == 7)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot8 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot8 = c.Slot8 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e7) { bookedStatus = false; }
           }
           else if (selectedSlotId == 8)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot9 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot9 = c.Slot9 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e8) { bookedStatus = false; }
            }
           else if (selectedSlotId == 9)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot10 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot10 = c.Slot10 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e9) { bookedStatus = false; }
           }
           else if (selectedSlotId == 10)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot11 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot11 = c.Slot11 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e10) { bookedStatus = false; }
               }
           else if (selectedSlotId == 11)
           {
               var query = from x in context.SlotAvailabilities
                           where x.Date.Day == tomorrow.Day && x.EquipmentID == selectId && x.Slot12 < (context.SportsFacilityDetails.Where(f => f.EquipmentID == x.EquipmentID).Select(f => f.EquipmentCount)).FirstOrDefault()
                           select x;
               try
               {
                   SlotAvailability c = query.FirstOrDefault<SlotAvailability>();
                   c.Slot12 = c.Slot12 + 1;
                   context.SaveChanges();
                   bookedStatus = true;
               }
               catch (Exception e11) { bookedStatus = false; }
           }

           return bookedStatus;
       }


    }
}
