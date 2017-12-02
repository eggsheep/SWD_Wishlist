﻿namespace Wishlist.Interface
{
    public interface IMemento
    {
        string State { get; set; }
        string GetState();
        void SetState();
    }
}