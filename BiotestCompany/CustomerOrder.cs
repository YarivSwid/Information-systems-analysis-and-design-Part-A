﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class CustomerOrder
    {
        private int customerOrderID;
        private int custOrderNumber;
        private double custOrderValue;
        private CustomerBid bid;
        private List<Product> products;

        public CustomerOrder(int orderID, int orderNumber, double orderValue, CustomerBid bid, List<Product> products, Boolean isNew)
        {
            this.customerOrderID = orderID;
            this.custOrderNumber = orderNumber;
            this.custOrderValue = orderValue;
            this.bid = bid;
            this.products = products;
            if (isNew)
            {
                this.createCustomerOrder();
                Program.CustomerOrders.Add(this);
            }
        }

        public void createCustomerOrder()
        {

        }

        public int getOrderID()
        {
            return this.customerOrderID;
        }
    }
}