using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    class Customer
    {
        private int custID;
        private string orgName;
        private District district;
        private string deliveryAddress;
        private string buildingNumber;
        private int roomNumber;

        public Customer(int custID, string orgName, District district, string deliveryAddress, string buildingNumber, int roomNumber)
        {
            this.custID = custID;
            this.orgName = orgName;
            this.district = district;
            this.deliveryAddress = deliveryAddress;
            this.buildingNumber = buildingNumber;
            this.roomNumber = roomNumber;
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
    }
}