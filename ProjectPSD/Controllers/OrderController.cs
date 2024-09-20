using ProjectPSD.Handlers;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controllers
{
    public class OrderController
    {
        TransactionHandler transactionHandler = new TransactionHandler();
        MakeupHandler makeupHandler = new MakeupHandler();
        CartHandler cartHandler = new CartHandler();
        public List<Makeup> getMakeupList()
        {
            return makeupHandler.getMakeupList();
        }

        public List<Cart> getCartList(int id)
        {
            return cartHandler.getUserCartList(id);
        }

        public void addToCart(int id, int muID, int qty)
        {
            cartHandler.addToCart(id,muID,qty);
        }

        public void deleteAllItem(int id)
        {
            cartHandler.deleteAllItem(id);
        }

        public void checkOut(int id)
        {
            List<Cart> cartList = getCartList(id);
            transactionHandler.addTransaction(cartList,id);
            cartHandler.deleteAllItem(id);
        }

        internal string validateOrderButton(int qty)
        {
            if (qty < 1)
            {
                return "qty must be bigger than 0";
            }
            else return "";
        }
    }
}