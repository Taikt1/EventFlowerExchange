﻿using SWP391.EventFlowerExchange.Domain.Entities;
using SWP391.EventFlowerExchange.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.EventFlowerExchange.Application
{
    public interface IProductService
    {
        public Task<List<GetProduct?>> GetEnableProductListFromAPIAsync();

        public Task<List<GetProduct?>> GetDisableProductListFromAPIAsync();

        public Task<List<GetProduct?>> GetInProgressProductListFromAPIAsync();

        public Task<List<GetProduct?>> GetRejectedProductListFromAPIAsync();

        public Task<bool> CreateNewProductFromAPIAsync(CreateProduct product, Account account);

        public Task<bool> RemoveProductFromAPIAsync(GetProduct product);

        public Task<GetProduct?> SearchProductByIdFromAPIAsync(GetProduct product);

        public Task<List<GetProduct?>> SearchProductByNameFromAPIAsync(string name);

        public Task<List<GetProduct?>> GetLatestProductsFromAPIAsync();

        public Task<List<GetProduct?>> GetOldestProductsFromAPIAsync();

        public Task<List<GetProduct?>> GetBannedProductListBySellerEmailFromAPIAsync(Account value);

        //BỔ SUNG HÀM 

        public Task<List<GetProduct?>> GetEnableProductListBySellerEmailFromAPIAsync(Account value);

        public Task<List<GetProduct?>> GetDisableProductListBySellerEmailFromAPIAsync(Account value);

        public Task<List<GetProduct?>> GetExpiredProductListBySellerEmailFromAPIAsync(Account value);

        public Task<bool> UpdateProductFromAPIAsync(GetProduct product);

        public Task<ProductStatistics> GetAllOrdersAndRatingBySellerFromAPIEmailAsync(Account account);


    }
}
