﻿using InternPulse4.Core.Application.Interfaces.Services;

namespace InternPulse4.Core.Application.Services
{
    public class PasswordHasherService 
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

  
    }
}
