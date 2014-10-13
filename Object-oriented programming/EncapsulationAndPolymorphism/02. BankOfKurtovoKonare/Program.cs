using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {

            Loan individualLoan = new Loan("Plamen", Customer.Individual, 2040, 24);
            Loan companyLoan = new Loan("Happy", Customer.Company, 45000, 12);

            Deposit individualDeposit = new Deposit("Angel", Customer.Individual, 19000, 24);
            Deposit companyDeposit = new Deposit("Trader", Customer.Company, 180120, 20);

            Mortgage individualMortgage = new Mortgage("Mariya", Customer.Individual, 2500, 12);
            Mortgage companyMortgage = new Mortgage("Agro", Customer.Company, 25000, 14);

            var accounts = new List<Account>();

            accounts.Add(individualDeposit);
            accounts.Add(companyDeposit);
            accounts.Add(individualMortgage);
            accounts.Add(companyMortgage);
            accounts.Add(individualLoan);
            accounts.Add(companyLoan);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

        }
    }
}
