using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoZLauncher.Objetos
{
   public class Account
    {
        private string _account;
        private string _password;
        private string rePass;
        private string _email;
        private string _answer;
        public Account(string account, string pass, string repass, string email, string answer)
        {
            _account = account;
            _password = pass;
            rePass = repass;
            _email = email;
            _answer = answer;
        }

        public string getAccount()
        {
            return _account;
        }
        
        public string getPassword()
        {
            return _password;
        }

        public string getRePass()
        {
            return rePass;
        }

        public string getEmail()
        {
            return _email;
        }

        public string getAnswer()
        {
            return _answer;
        }
    }
}
