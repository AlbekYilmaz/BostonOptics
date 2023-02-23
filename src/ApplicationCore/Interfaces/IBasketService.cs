﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        Task<Basket> GetOrCreateBasketAsync(string buyerId);
        Task<Basket> AddItemBasketAsync(string buyerId, int productId, int quantity);
        Task EmptyBasketAsync(string buyerId);
        Task DeleteBasketItemAsync(string buyerId, int productId);
        Task<Basket> SetQuantitiesAsync(string buyerId, Dictionary<int, int> quantities);
        Task TransferBasketAsync(string sourceBuyerId, string destinationBuyerId);

    }
}
