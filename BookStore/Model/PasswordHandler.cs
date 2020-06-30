using System;
using System.Collections.Generic;
using System.Text;
using BookStore;
using BookStore.ViewModel;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
using System.Windows;
using System.Security.Policy;
using System.Linq;
using BookStore.Converters;

namespace BookStore.Model
{
    /// <summary>
    /// Static methods to handle passwords
    /// </summary>
    public class PasswordHandler
    {
        private string Hash(string pass, string salt)
        {
            var rfc = new Rfc2898DeriveBytes(pass, Encoding.UTF8.GetBytes(salt));
            byte[] hash = rfc.GetBytes(20);
            return Encoding.UTF8.GetString(hash);
        }
        private string GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt);
            }
            return Encoding.UTF8.GetString(salt);
        }
        /// <summary>
        /// Accepts a string with user inputed password and returns a randomly generated salt
        /// hashsum of the combination.
        /// </summary>
        /// <param name="pass">User inputed password</param>
        /// <returns></returns>
        public HashWithSalt HashAndSaltPass(string pass)
        {
            var toReturn = new HashWithSalt();
            toReturn.Salt = GenerateSalt();
            toReturn.Hash = Hash(pass, toReturn.Salt);
            return toReturn;
        }
        /// <summary>
        /// Checks the database if the entered user has the entered password.
        /// </summary>
        /// <param name="userName">User name to match with password.</param>
        /// <param name="pass">Password to match with username.</param>
        /// <returns>The UserInfo instance of the confirmed user or NULL for mismatch.</returns>
        public UserInfo ConfirmPassword (string userName, string inputedPass, HashWithSalt hashWithSalt)
        {
            if(Hash(inputedPass,hashWithSalt.Salt)==hashWithSalt.Hash)
            {
                return new UserInfo("Admin", Enums.Privilege.Admin);
            }
            return null;
        }
        public static bool TrySaveUser(UserInfo givenInfo)
        {
            return true;
        }
    }
}
