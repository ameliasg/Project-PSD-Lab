using ProjectPSD.Handlers;
using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controllers
{
    public class ReportController
    {
        TransactionHandler transactionHandler = new TransactionHandler();

        public List<TransactionHeader> getTransactions()
        {
            return transactionHandler.getUserTransaction();
        }
    }
}