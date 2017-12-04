﻿using System.Collections.Generic;
using Wishlist.Interface;

namespace Wishlist
{
    public class WishlistMemento : IWishlistMemento
    {
        public WishlistMemento(IWishlist wishlist)
        {
            OwnerAddress = wishlist.OwnerAddress;
            OwnerName = wishlist.OwnerName;
            if(wishlist.ListOfWishes != null)
            ListOfWishes = new List<IWish>(wishlist.ListOfWishes);
        }
        
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public List<IWish> ListOfWishes { get; set; }
    }
}