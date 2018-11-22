﻿using PingYourPackage.Domain.Abstract;
using PingYourPackage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static User GetSingleByUsername(
        this IEntityRepository<User> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(x => x.Name == username);
        }
    }
}
