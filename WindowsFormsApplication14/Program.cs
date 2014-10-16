using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public class MyController
    {
        public MyController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParentForm(this));
        }
        public void search()
        {
            SearchController search = new SearchController();
            
           // Search searchScreen = new Search();
           // searchScreen.Show();
        }

        public void Book()
        {
            BookingController search = new BookingController();

            // Search searchScreen = new Search();
            // searchScreen.Show();
        }

        public void Cancel()
        {
            CancelController cancel = new CancelController();
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyController mc = new MyController();
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
        }
    }
}
