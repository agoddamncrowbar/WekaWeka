using System;
using System.Collections.Generic;
using System.Text;
using WekaWeka.Repositories;
using WekaWeka.Utils;
using WekaWeka.Models;

namespace WekaWeka.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo;

        public AuthService()
        {
            _userRepo = new UserRepository();
        }

        public User Login(string username, string password)
        {
            var user = _userRepo.GetByUsername(username);

            if (user == null)
                return null;

            if (user.Is_active != 1)
                return null;

            var hashed = PasswordHelper.Hash(password);

            if (user.password_hash != hashed)
                return null;

            return user;
        }
    }
}
