using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repositories
{
    public class TransactionRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();

        public int getTHNextID()
        {
            return db.TransactionHeaders.Count() + 1;
        }

        public int getTDNextID()
        {
            return db.TransactionDetails.Count() + 1;
        }

        public void addNewTH(TransactionHeader th)
        {
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }
        public void addNewTD(TransactionDetail td)
        {
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }

        public List<TransactionHeader> getUserTransaction(int id)
        {
            return (from t in db.TransactionHeaders where t.UserID == id select t).ToList();
        }

        public List<TransactionDetail> getDetail(int id)
        {
            return (from t in db.TransactionDetails where t.TransactionID == id select t).ToList();
        }

        public List<TransactionHeader> getUserTransaction()
        {
            return (from th in db.TransactionHeaders select th).ToList();
        }

        internal List<TransactionHeader> getHandledTransaction()
        {
            return (from th in db.TransactionHeaders where th.status.Equals("handled")select th).ToList();
        }

        internal List<TransactionHeader> getUnhandledTransaction()
        {
            return (from th in db.TransactionHeaders where th.status.Equals("unhandled") select th).ToList();
        }

        internal void handle(int id)
        {
            TransactionHeader th = db.TransactionHeaders.Find(id);
            th.status = "handled";
            db.SaveChanges();
        }
    }
}