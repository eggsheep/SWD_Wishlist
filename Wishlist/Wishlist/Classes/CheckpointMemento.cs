﻿using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class CheckpointMemento : IMemento
    {
        public string State { get; set; }
        public string GetState()
        {
            throw new System.NotImplementedException();
        }

        public void SetState()
        {
            throw new System.NotImplementedException();
        }
    }
}