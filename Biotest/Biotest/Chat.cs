// File:    Order.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:00:31
// Purpose: Definition of Class Order

using System;

namespace WindowsFormsApp2
{
    public class Chat
    {
        private int chatID;
        private string name;
        private DateTime openingDT;
        private string description;
        //private User creator;

        public Chat(string name, string description) //ADD CREATOR TO PARAMETERS!!!
        {
            //assign chatID
            this.name = name;
            this.openingDT = DateTime.Now;
            this.description = description;
            //this.creator = XXXXX

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
    }
}