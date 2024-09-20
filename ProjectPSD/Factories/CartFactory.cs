using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factories
{
    public class CartFactory
    {
        CartRepository cartRepository = new CartRepository();
        public Cart newCart(int id,int muID,int qty)
        {
            Cart cart = new Cart();
            cart.CartID = cartRepository.getNextID();
            cart.UserID = id;
            cart.MakeupID = muID;
            cart.Quantity = qty;
            return cart;
        }
    }
}