using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BiotestCompany;

namespace BiotestCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///  //רשימות
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<User> Users;
        // public static System.Collections.Generic.List<Chat> Chats;
        public static System.Collections.Generic.List<Message> Messages;
        //public static System.Collections.Generic.List<CustomerBid> CustomerBid;
        //public static System.Collections.Generic.List<CustomerOrder> CustomerOrder;
        //public static System.Collections.Generic.List<Supplier> Supplier;
        //public static System.Collections.Generic.List<BusinessMeeting> BusinessMeeting;
        //public static System.Collections.Generic.List<Contact> Contact;
        //public static System.Collections.Generic.List<SupplierBid> SupplierBid;
        //public static System.Collections.Generic.List<SupplierOrder> SupplierOrder;
        //public static System.Collections.Generic.List<Product> Product;
        //public static System.Collections.Generic.List<ProductType> ProductType;


        // add the rest of lists

        [STAThread]
        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        //public static Worker seekWorker(string id)
        //{
          //  foreach (Worker w in Workers)
            //{
              //  if (w.getID() == id)
                //    return w;
            //}
            //return null;
        //}
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new User(12, "2342342", DateTime.Now, "yuval", "haefes", DateTime.Now, 5712, "homomomo", "homo", "sdasdas");
            Application.Run(new Form1());
        }
        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_customers();
            init_users();
            init_chats();
            init_messages();
            //init_customerbid();
            //init_customerorder();
            //init_supplier();
            //init_businessmeeting();
            //init_contact();
            //init_supplierbid();
            //init_supplierorder();
            //init_product();
            //init_producttype();

        }
        public static void init_customers()
        {
            //SqlCommand c = new SqlCommand();
            //c.CommandText = "EXECUTE dbo.Get_all_Workers";
            //SQL_CON SC = new SQL_CON();
            //SqlDataReader rdr = SC.execute_query(c);

            //Workers = new List<Worker>();

            //while (rdr.Read())
            //{
            //    Title T = (Title)Enum.Parse(typeof(Title), rdr.GetValue(2).ToString());
            //    Worker w = new Worker(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), T, false);
            //    Workers.Add(w);
            //}
        }
        public static void init_users()
        {
        }
        public static void init_chats()
        {
        }
        public static void init_customerbid()
        {
        }
        public static void init_messages()
        {
        }
        public static void init_customerorder()
        {
        }
        public static void init_businessmeeting()
        {
        }
        public static void init_contact()
        {
        }
        public static void init_supplierbid()
        {
        }
        public static void init_supplierorder()
        {
        }
        public static void init_product()
        {
        }
        public static void init_producttype()
        {
        }
        public static void init_supplier()
        {
        }
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    initLists();//אתחול כל הרשימות
        //    Application.Run(new main_form());
        //}
    }

}