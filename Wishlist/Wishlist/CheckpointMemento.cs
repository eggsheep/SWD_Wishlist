﻿using System.Collections.Generic;
using Wishlist.Interface;

namespace Wishlist
{
    public class CheckpointMemento : IMemento
    {
        public CheckpointMemento(IWishlist wishlist)
        {
            OwnerAddress = wishlist.OwnerAddress;
            OwnerName = wishlist.OwnerName;
            ListOfWishes = new List<IWish>(wishlist.ListOfWishes);
        }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public List<IWish> ListOfWishes { get; set; }
    }
}