using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    //Single Reponsibility Principle:
    //States that you should have only one reason to change the class
    /// <summary>
    /// Problem in this case a class is dealing with multiple function
    /// This creates a Performance and maintainability issue
    /// </summary>
    public class User
    {
        public void InsertUser() {
            if (this.InsertUserData())
            {
                this.SendMail();
            }
        }
        public void UpdateUser()
        {

        }
        public void DeleteUser()
        {

        }
        public void SelectUser()
        {

        }
        public void SendMail()
        {

        }
        private bool InsertUserData()
        {
            return true;
        }
        public IList selection()
        {
            return null;
        }
    }
}
