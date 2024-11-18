﻿using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Utilities;
using SWP391.EventFlowerExchange.Domain.Entities;
using SWP391.EventFlowerExchange.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.EventFlowerExchange.Infrastructure
{
    public interface INotificationRepository
    {
        public Task<List<Notification>> ViewAllNotificationAsync();
        public Task<List<Notification>> ViewAllNotificationByUserIdAsync(Account account);
        public Task<Notification> ViewNotificationByIdAsync(Notification notification);
        public Task<IdentityResult> CreateNotificationAsync(CreateNotification notification);
        public Task<int> CountNotificationsByEmailAsync(Account account);

        public Task<List<ShopNotification>> ViewAllShopNotificationAsync();
        public Task<List<ShopNotification>> ViewAllShopNotificationByUserIdAsync(Account account);
        public Task<ShopNotification> ViewShopNotificationByIdAsync(ShopNotification notification);
        public Task<IdentityResult> CreateShopNotificationAsync(CreateShopNotification notification);
        public Task<int> CountShopNotificationByEmailAsync(Account account);

    }
}
