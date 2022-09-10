﻿using Domain.Entities.UsersModule;

namespace Domain.Common.ResponseModels
{
    public class UserLoginResponseModel
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public User? User { get; set; }
    }
}