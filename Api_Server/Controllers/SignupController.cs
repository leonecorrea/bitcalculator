using Api_Server.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace Api_Server.Controllers {
    public class SignupController : ApiController {

        [EnableCors("*", "*", "*")]
        // POST: New Account
        public Account Post(Account account){

            try {
                Account acc = new Account(account.Name, account.Username, account.Password);
                acc.Signup(acc);
                return (acc);
            } catch (Exception ex) {
                account.Error = ex.ToString();
                return account;
            }
        }
    }
}