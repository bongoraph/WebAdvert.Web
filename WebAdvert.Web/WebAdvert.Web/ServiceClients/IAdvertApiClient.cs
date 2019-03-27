﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.ServiceClients
{
    public interface IAdvertApiClient
    {
        Task<AdvertResponse> CreateAsync(CreateAdvertModel model, string userName);
        Task<bool> ConfirmAsync(ConfirmAdvertRequest model);
        Task<List<Advertisement>> GetAllAsync();
        Task<Advertisement> GetAsync(string advertId);
    }
}
