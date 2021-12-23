using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;


namespace BiotestCompany
{
    public class BusinessMeeting
    {
        private int meetingID;
        private DateTime meetingDT;
        private string notes;
        private User creator; // references to createdBy in BUSINESSMEETINGS table
        private List<Customer> customerParticipants;
        private List<User> userParticipants;

        public BusinessMeeting(int meetingID, DateTime meetingDT, string notes, User creator, Boolean isNew)
        {
            this.meetingID = meetingID;
            this.meetingDT = meetingDT;
            this.notes = notes;
            this.creator = creator;
            if (isNew)
            {
                this.createBusinessMeeting();
                Program.BusinessMeetings.Add(this);
            }
            this.customerParticipants = new List<Customer>();
            this.userParticipants = new List<User>();
        }

        public Boolean addParticipants(Customer cust, User user)
        { // returns false if no cust or user given
            if (cust != null)
            {
                customerParticipants.Add(cust);
                return true;
            }
            else if (user != null)
            {
                userParticipants.Add(user);
                return true;
            }
            else
                return false;
        }

        // getters:

        public int getMeetingID()
        {
            return this.meetingID;
        }
        public DateTime getMeetingDT()
        {
            return this.meetingDT;
        }
        public string getNotes()
        {
            return this.notes;
        }
        public User getCreator()
        {
            return this.creator;
        }

        // setters:

        public void setMeetingDT(DateTime DT)
        {
            this.meetingDT = DT;
        }
        public void setNotes(string notes)
        {
            this.notes = notes;
        }
        // set creator?

        public void createBusinessMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddBusinessMeeting @meetingID,@meetingDT,@notes,@creator"; // CREATE THIS SP
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            c.Parameters.AddWithValue("@meetingDT", this.meetingDT);
            c.Parameters.AddWithValue("@notes", this.notes);
            c.Parameters.AddWithValue("@creator", this.creator);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateBusinessMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateBusinessMeeting @meetingID,@meetingDT,@notes,@creator"; // CREATE THIS SP
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            c.Parameters.AddWithValue("@meetingDT", this.meetingDT);
            c.Parameters.AddWithValue("@notes", this.notes);
            c.Parameters.AddWithValue("@creator", this.creator);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void generateForm() // CREATE
        {

        }
    }
}
