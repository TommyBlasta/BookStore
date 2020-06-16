using System;
using System.Collections.Generic;
using System.Text;
using BookStore;
using BookStore.ViewModel;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
using System.Windows;

namespace BookStore.Model
{
    /// <summary>
    /// Static methods to handle passwords
    /// </summary>
    static class PasswordHandler
    {
        /// <summary>
        /// Accepts a string with user inputed password and returns a randomly generated salt
        /// hashsum of the combination.
        /// </summary>
        /// <param name="pass">User inputed password</param>
        /// <returns></returns>
        public static HashWithSalt HashAndSaltPass(string pass)
        {
            //byte array with random generated values
            byte[] salt= new byte[16];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt);
            }
            //hashes the given pass with the generated salt
            var rfc = new Rfc2898DeriveBytes(pass,salt);           
            byte[] hash = rfc.GetBytes(20);

            //FOR TESTING
            //byte[] concatedPswHsh = new byte[36];
            ////Adds salt from index 0 to the array concatedPswHsh starting at its index 0 and adds 16 bytes from salt 
            //Array.Copy(salt, 0, concatedPswHsh, 0, 16);
            ////Adds the hashed value.
            //Array.Copy(hash, 0, concatedPswHsh, 16, 20);
            //var finishedString = Convert.ToBase64String(concatedPswHsh);
            //MessageBox.Show(finishedString);

            return new HashWithSalt { Hash = Convert.ToBase64String(salt), Salt = Convert.ToBase64String(hash)};
        }
        /// <summary>
        /// Checks the database if the entered user has the entered password.
        /// </summary>
        /// <param name="userName">User name to match with password.</param>
        /// <param name="pass">Password to match with username.</param>
        /// <returns>The UserInfo instance of the confirmed user or NULL for mismatch.</returns>
        static UserInfo ConfirmPassword (string userName, string pass)
        {
            return new UserInfo();
        }
        public static bool TrySaveUser(UserInfo givenInfo)
        {
            return true;
        }
    }
}
