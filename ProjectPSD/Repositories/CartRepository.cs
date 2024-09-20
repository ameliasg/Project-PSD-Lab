using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ProjectPSD.Repositories
{
    public class CartRepository
    {
        MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();
        public int getNextID()
        {
            return db.Carts.Count() + 1;
        }
        public void addNewCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public List<Cart> getUserCartList(int id)
        {
            return (from c in db.Carts where c.UserID == id select c).ToList();
        }

        public void deleteAllItem(int id)
        {
            db.Carts.RemoveRange(db.Carts.Where(x => x.UserID == id));
            db.SaveChanges();
        }
    }
}