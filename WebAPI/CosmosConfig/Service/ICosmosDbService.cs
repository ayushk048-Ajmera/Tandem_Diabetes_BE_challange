﻿using Tandem_Diabetes_BE_challenge.Entities;

namespace Tandem_Diabetes_BE_challenge.CosmosConfig.Service
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<User>> GetUsersAsync(string query);
        Task<User> AddItemAsync(User item);
    }
}