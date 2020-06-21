using BookStore.Data;
using BookStore.Enums;
using BookStore.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Automation;

namespace BookStore.ViewModel
{
    class UserInfo : ObservableObject
    {
        public string Name { get; private set; }
        public Privilege UserPrivilege { get;private set; }
        
        public UserInfo(Users input)
        {
            Name = input.Name;
            if(input.Position!=null)
            {
                try
                {
                    UserPrivilege = (Privilege)Enum.Parse(typeof(Privilege), input.Position);
                }
                catch(Exception ex)
                {
                    ExceptionLogger.Log(ex);

                }
            }
        }
        public UserInfo()
        {

        }


    }
}
