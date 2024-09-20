using ProjectPSD.Handlers;
using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ProjectPSD.Controllers
{
    public class TransactionController
    {
        TransactionHandler transactionHandler = new TransactionHandler();

        public List<TransactionHeader> getUserTransaction(int id)
        {
            if (id == 1) return transactionHandler.getUserTransaction();
            else return transactionHandler.getUserTransaction(id);
        }
        public List<TransactionHeader> getUserTransaction(bool handled)
        {
            if (handled) return transactionHandler.getHandledTransaction();
            else return transactionHandler.getUnhandledTransaction();
        }
        public List<TransactionDetail> getDetail(int id)
        {
            return transactionHandler.getDetail(id);
        }

        internal void handle(int id)
        {
            transactionHandler.handle(id);
        }
    }
}