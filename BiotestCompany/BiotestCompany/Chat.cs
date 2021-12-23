// File:    Order.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:00:31
// Purpose: Definition of Class Order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    public class Chat
    {
        private int chatID;
        private string name;
        private DateTime openingDT;
        private string description;
        private User creator;

        public Chat(string name, string description, User creator, Boolean isNew) //ADD CREATOR TO PARAMETERS!!!
        {
            this.chatID = GIVEME();
            this.name = name;
            this.openingDT = DateTime.Now;
            this.description = description;
            this.creator = creator;
            this.creator = creator;
            if (isNew)
            {
                this.createChat();
                Program.Chats.Add(this);
            }
        }
        public Chat(int chatID, string name, DateTime openingDT, string description, User creator, Boolean isNew) //ADD CREATOR TO PARAMETERS!!!
        {
            this.chatID = chatID;
            this.name = name;
            this.openingDT = openingDT;
            this.description = description;
            this.creator = creator;
            if (isNew)
            {
                this.createChat();
                Program.Chats.Add(this);
            }

        }
        public int GIVEME()
        {
            int result = this.openingDT.Year * 100000 + this.openingDT.Month * 1000
                        + this.openingDT.Day * 100 + this.openingDT.Hour * 10 + this.openingDT.Minute + this.openingDT.Second;
            return result;
        }
        public int getID()
        {
            return this.chatID;
        }
        public string getName()
        {
            return this.name;
        }
        public DateTime getOpeningDT()
        {
            return this.openingDT;
        }
        public string getDescription()
        {
            return this.description;
        }
        //public User getUser()
        //{
        //    return this.creator;
        //}
        public void setName(string newName)
        {
            this.name = newName;
        }
        public void setDescription(string newDescription)
        {
            this.description = newDescription;
        }

        public void createChat()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddChat @chatID,@name,@openingDT,@description,@creator"; // ןגם להוסיף מנג'ר
            c.Parameters.AddWithValue("@ID", this.chatID);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@openingDT", this.openingDT);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@manager", this.creator.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateUser()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateChat @ID, @name, @openingDT, @description"; // ןגם להוסיף מנג'ר
            c.Parameters.AddWithValue("@ID", this.chatID);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@openingDT", this.openingDT);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@manager", this.creator.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void deleteUser()
        {
            Program.Chats.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.DeleteChat @id";
            c.Parameters.AddWithValue("@id", this.chatID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}