using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public static System.Collections.Generic.List<Chat> Chats;
        public static System.Collections.Generic.List<Message> Messages;
<<<<<<< HEAD
        public static System.Collections.Generic.List<CustomerBid> CustomerBids;
        //public static System.Collections.Generic.List<CustomerOrder> CustomerOrders;
        //public static System.Collections.Generic.List<Supplier> Supplier;
        public static System.Collections.Generic.List<BusinessMeeting> BusinessMeetings;
        public static System.Collections.Generic.List<Contact> Contacts;
        //public static System.Collections.Generic.List<SupplierBid> SupplierBids;
        //public static System.Collections.Generic.List<SupplierOrder> SupplierOrders;
        //public static System.Collections.Generic.List<Product> Products;
        public static System.Collections.Generic.List<ProductType> ProductTypes;
=======
        //public static System.Collections.Generic.List<CustomerBid> CustomerBid;
        //public static System.Collections.Generic.List<CustomerOrder> CustomerOrder;
        //public static System.Collections.Generic.List<Supplier> Supplier;
        //public static System.Collections.Generic.List<BusinessMeeting> BusinessMeeting;
        //public static System.Collections.Generic.List<Contact> Contact;
        //public static System.Collections.Generic.List<SupplierBid> SupplierBid;
        //public static System.Collections.Generic.List<SupplierOrder> SupplierOrder;
        //public static System.Collections.Generic.List<Product> Product;
        //public static System.Collections.Generic.List<ProductType> ProductType;
>>>>>>> df584c331c2f8e947f1c3b75035685eb0ba9ae5f

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


        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            //init_customers();
<<<<<<< HEAD
            init_users();
            init_chats();
=======
            //init_users();
            //init_chats();
>>>>>>> df584c331c2f8e947f1c3b75035685eb0ba9ae5f
            //init_messages();
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
<<<<<<< HEAD
            //  SqlCommand c = new SqlCommand();
            //  c.CommandText = "EXECUTE dbo.GetAllCustomers";
            //  SQL_CON SC = new SQL_CON();
            //  SqlDataReader rdr = SC.execute_query(c);

            //  Customers = new List<Customer>();

            ////  while (rdr.Read())
            //  {
            //      //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());// if need a enum
            //      //change the vector below
            //      Customer U = new Customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
            //      Users.Add(U);
            //  }
=======

>>>>>>> df584c331c2f8e947f1c3b75035685eb0ba9ae5f
        }
        public static void init_users()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllUsers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Users = new List<User>();

            while (rdr.Read())
            {
                //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
                User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
                Users.Add(U);
            }
        }
<<<<<<< HEAD

        public static User FindMyUser(int ID)
        {
            return Users.Find(U => U.getID() == ID);
        }

        public static void init_chats()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllChats";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Chats = new List<Chat>();

            while (rdr.Read())
            {
                //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
                //                 @chatID,@name,@openingDT,@description,@creator"; // ןגם להוסיף מנג'ר
                //public Chat(int chatID, string name, DateTime openingDT, string description, User creator, Boolean isNew) //ADD CREATOR TO PARAMETERS!!!
                User MyUser = FindMyUser(int.Parse(rdr.GetValue(4).ToString()));
                Chat C = new Chat(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), MyUser, false); //CHANGE Role TO Role type
                Chats.Add(C);
            }
        }

        //public static void init_customerbid()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllCustomerBids";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    CustomerBids = new List<CustomerBid>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_messages()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_customerorder()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_businessmeeting()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_contact()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_supplierbid()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_supplierorder()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_product()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_producttype()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_supplier()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
=======
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
>>>>>>> df584c331c2f8e947f1c3b75035685eb0ba9ae5f
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //initLists();//אתחול כל הרשימות
            init_users();
            init_chats();
            //while (Users.ElementAt(0) != null)
            //{
            //    Users.ElementAt(0).deleteUser();
            //}
            Application.Run(new MainForm());
            Console.WriteLine(Users.Count);
            Console.WriteLine(Chats.Count);
        }
    }
=======
            //    new User(12, "2342342", DateTime.Now, "yuval", "haefes", DateTime.Now, 5234712, "homomomo", "homo", "sdasdas",true);
            //    initLists();//אתחול כל הרשימות
            // Application.Run(new main_form());

            init_users();
            Console.WriteLine(Users.Count);

        }
    }

>>>>>>> df584c331c2f8e947f1c3b75035685eb0ba9ae5f
}