using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcservicedemo.Models
{
    public class Repository
    {

        public FinancialData GetFinancialData()
        {
            FinancialData d = new FinancialData() {
                markedsvardi = 1000,
                ibd = 750,
                potLeje = 500,
                tomgang = 100
            };

            return d;
        }
        public List<Account> GetAllAccounts()
        {
            var l = new List<Account>();
            l.Add(new Account { Id = 1, Name = "x" });
            l.Add(new Account { Id = 2, Name = "y" });
            return l;
        }

        public Account GetAccount(int id)
        {
             return new Account { Id = id, Name = id.ToString() };
            
        }
    }
}