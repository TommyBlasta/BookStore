using System;
using System.Collections.Generic;
using System.Text;
using BookStore;
using BookStore.ModelView;

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
        static HashWithSalt HashAndSaltPass(string pass)
        {

            return new HashWithSalt { Hash = "", Salt = "" };
        }
        static UserInfo ConfirmPassword (string userName, string pass)
        {
            return new UserInfo();
        }
    }
}
