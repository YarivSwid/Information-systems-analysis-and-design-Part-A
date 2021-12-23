using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;


/* todo list:
 * create CAST for DateTime
 * create input checks in constructor?
 * create random pass function
 * when rand pass assigned, send it to user (so we dont have to create getPassword)
 */

namespace BiotestCompany
{
    public class User
    {
        private int userID;
        private string password;
        private DateTime joinDate; // NEED to cast from date to DateTime
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private int serialID;
        private string email;
        private string role; //CHANGE BACK TO Role type
        private string profilePicture;

        public User(int userID, DateTime joinDate, string firstName, string lastName, DateTime birthday, int serialID, string email, string role, string profilePicture, Boolean isNew) //CHANGE BACK TO Role type
        { // create from GUI (no password in input)
            this.userID = userID;
            this.password = setAutomaticPassword(); // create the method
            this.joinDate = joinDate;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.serialID = serialID;
            this.email = email;
            this.role = role;
            this.profilePicture = profilePicture;
            if (isNew)
            {
                this.createUser();
                Program.Users.Add(this);
            }
        }
        public User(int userID, string password, DateTime joinDate, string firstName, string lastName, DateTime birthday, int serialID, string email, string role, string profilePicture, Boolean isNew) //CHANGE BACK TO Role type
        { // create from SQL
            this.userID = userID;
            this.password = password;
            this.joinDate = joinDate;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.serialID = serialID;
            this.email = email;
            this.role = role;
            this.profilePicture = profilePicture;
            if (isNew)
            {
                this.createUser();
                Program.Users.Add(this);
            }


        }
        public string setAutomaticPassword()
        {
            // when we create a rand password, we will send it to user
            return "doctorStrange ";
        }
        public int getID()
        {
            return this.userID;
        }

        // setters & getters:
        public void setPassword(string password)
        {// check if password valid
            // no get. but when we create a rand password, we will send it to user
            this.password = password;
        }
        public void setFirstName(string name)
        {
            this.firstName = name;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public void setLastName(string name)
        {
            this.lastName = name;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public void setBirthday(DateTime date)
        {
            this.birthday = date; // cast
        }
        public DateTime getBirthday()
        {
            return this.birthday;
        }
        public void setEmail(string email)
        {// check if input is valid
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }
        //public void setRole(Role role)
        //{
        //    this.role = role;
        //}
        //public Role getRole()
        //{
        //    return this.role;
        //}
        public void setProfilePicture(string str)
        {
            this.profilePicture = str;
        }
        public string getProfilePicture()
        {
            return this.profilePicture;
        }


        // input check methods
        public bool checkExistingUserID(int userID)
        {
            // CODE IT LATER
            return true;
        }
        public bool checkEmailValid(string email)
        {
            // CODE IT LATER
            return true;
        }


        public void createUser()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddUser @ID, @password, @joinDate ,@firstName, @lastName, @birthday, @serialID ,@email, @role, @profilePicture";
            c.Parameters.AddWithValue("@id", this.userID);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@joinDate", this.joinDate);
            c.Parameters.AddWithValue("@firstName", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@birthday", this.birthday);
            c.Parameters.AddWithValue("@serialID", this.serialID);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@role", this.role);
            c.Parameters.AddWithValue("@profilePicture", this.profilePicture);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateUser()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateUser @ID, @password, @joinDate ,@firstName, @lastName, @birthday, @serialID ,@email, @role, @profilePicture";
            c.Parameters.AddWithValue("@id", this.userID);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@joinDate", this.joinDate);
            c.Parameters.AddWithValue("@firstName", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@birthday", this.birthday);
            c.Parameters.AddWithValue("@serialID", this.serialID);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@role", this.role);
            c.Parameters.AddWithValue("@profilePicture", this.profilePicture);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void deleteUser()
        {
            Program.Users.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.DeleteUser @id";
            c.Parameters.AddWithValue("@id", this.userID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}