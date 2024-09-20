using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factories
{
    public class TransactionFactory
    {
        public TransactionHeader newTH(int id,int uID,DateTime date,string status)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = id;
            th.TransactionDate = date;
            th.UserID = uID;
            th.status = status;
            return th;
        }

        public TransactionDetail newTD(int tID,int muID,int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = tID;
            td.MakeupID = muID;
            td.Quantity = quantity;
            return td;
        }
    }
}