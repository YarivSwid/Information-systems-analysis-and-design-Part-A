using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    public class Contact
    {
        private string contactName;
        private int phoneNumber;
        private string contactEmail;

        public Contact(string contactName, int phoneNumber, string contactEmail, Boolean isNew)
        {
            this.contactName = contactName;
            this.phoneNumber = phoneNumber;
            this.contactEmail = contactEmail;
            if (isNew)
            {
                this.createContact();
                Program.Contacts.Add(this);
            }
        }

        // getters & setters:

        public string getContactName()
        {
            return this.contactName;
        }
        public int getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string getContactEmail()
        {
            return this.contactEmail;
        }
        public void setContactName(string contactName)
        {
            this.contactName = contactName;
        }
        public void setPhoneNumber(int num)
        {
            this.phoneNumber = num;
        }
        public void setContactEmail(string email)
        {
            this.contactEmail = email;
        }

        public void createContact()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddContact @contactName,@phoneNumber"; // CREATE SP
            c.Parameters.AddWithValue("@contactName", this.contactName);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateContact()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateContact @contactName,@phoneNumber"; // CREATE SP
            c.Parameters.AddWithValue("@contactName", this.contactName);
            c.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
