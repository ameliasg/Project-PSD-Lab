using ProjectPSD.Factories;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handlers
{
    public class TransactionHandler
    {
        TransactionFactory transactionFactory = new TransactionFactory();
        TransactionRepository transactionRepository = new TransactionRepository();
        public void addTransaction(List<Cart> cartList,int uID)
        {
            DateTime date = DateTime.Now;
            string status = "unhandled";
            int id = transactionRepository.getTHNextID();
            TransactionHeader th = transactionFactory.newTH(id, uID, date, status);
            transactionRepository.addNewTH(th);
            foreach (Cart cart in cartList)
            {
                int muID = cart.MakeupID;
                int qty = cart.Quantity;
                TransactionDetail td = transactionFactory.newTD(id,muID, qty);
                transactionRepository.addNewTD(td);
            }
        }

        public List<TransactionHeader> getUserTransaction(int id)
        {
            return transactionRepository.getUserTransaction(id);
        }
        public List<TransactionHeader> getUserTransaction()
        {
            return transactionRepository.getUserTransaction();
        }

        public List<TransactionDetail> getDetail(int id)
        {
            return transactionRepository.getDetail(id);
        }

        internal List<TransactionHeader> getHandledTransaction()
        {
            return transactionRepository.getHandledTransaction();
        }

        internal List<TransactionHeader> getUnhandledTransaction()
        {
            return transactionRepository.getUnhandledTransaction();
        }

        internal void handle(int id)
        {
            transactionRepository.handle(id);
        }
    }
}