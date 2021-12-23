using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    public class Customer
    {
        private int custID;
        private string orgName;
        private District district;
        private string deliveryAddress;
        private string buildingNumber;
        private int roomNumber;

        public Customer(int custID, string orgName, District district, string deliveryAddress, string buildingNumber, int roomNumber, Boolean isNew)
        {
            this.custID = custID;
            this.orgName = orgName;
            this.district = district;
            this.deliveryAddress = deliveryAddress;
            this.buildingNumber = buildingNumber;
            this.roomNumber = roomNumber;
            if (isNew)
            {
                this.createCustomer();
                Program.Customers.Add(this);
            }
        }

        // setters & getters:

        public void setOrgName(string name)
        {
            this.orgName = name;
        }
        public string getOrgName()
        {
            return this.orgName;
        }
        public District getDistrict()
        { // do we need to create set? i dont think so
            return this.district;
        }
        public void setDeliveryAddress(string address)
        {
            this.deliveryAddress = address;
        }
        public string getDeliveryAddress()
        {
            return this.deliveryAddress;
        }
        public void setBuildingNumber(string str)
        {
            this.deliveryAddress = str;
        }
        public string getBuildingNumber()
        {
            return this.buildingNumber;
        }
        public void setRoomNumber(int num)
        {
            this.roomNumber = num;
        }
        public int getRoomNumber()
        {
            return this.roomNumber;
        }

        //int custID, string orgName, District district, string deliveryAddress, string buildingNumber, int roomNumber
        public void createCustomer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddCustomer @custID, @orgName, @district ,@deliveryAddress, @buildingNumber, @roomNumber"; // CREATE SP
            c.Parameters.AddWithValue("@custID", this.custID);
            c.Parameters.AddWithValue("@orgName", this.orgName);
            c.Parameters.AddWithValue("@district", this.district);
            c.Parameters.AddWithValue("@deliveryAddress", this.deliveryAddress);
            c.Parameters.AddWithValue("@buildingNumber", this.buildingNumber);
            c.Parameters.AddWithValue("@roomNumber", this.roomNumber);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateUser()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateCustomer @custID, @orgName, @district ,@deliveryAddress, @buildingNumber, @roomNumber"; // CREATE SP
            c.Parameters.AddWithValue("@custID", this.custID);
            c.Parameters.AddWithValue("@orgName", this.orgName);
            c.Parameters.AddWithValue("@district", this.district);
            c.Parameters.AddWithValue("@deliveryAddress", this.deliveryAddress);
            c.Parameters.AddWithValue("@buildingNumber", this.buildingNumber);
            c.Parameters.AddWithValue("@roomNumber", this.roomNumber);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}