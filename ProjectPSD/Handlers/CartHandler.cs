using ProjectPSD.Factories;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handlers
{
    public class CartHandler
    {
        CartFactory cartFactory = new CartFactory();
        CartRepository cartRepository = new CartRepository();

        public void deleteAllItem(int id)
        {
            cartRepository.deleteAllItem(id);
        }

        public void addToCart(int id, int muID, int qty)
        {

            Cart newCart = cartFactory.newCart(id, muID, qty); // salah
            cartRepository.addNewCart(newCart);
        }
        public List<Cart> getUserCartList(int id)
        {
            return cartRepository.getUserCartList(id);
        }   
    }
}