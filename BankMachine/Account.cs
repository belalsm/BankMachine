using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    class Account
    {
        private int accountNumber = 0;
        private int pin = 0;
        private int chequingBalance = 100;
        private int savingsBalance = 100;
        private int creditCardBalance = 100;

        public enum AccountType {savings, creditcard, chequings }

        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                this.accountNumber = value;
            }
        }

        public int Pin
        {
            get
            {
                return this.pin;
            }
            set
            {
                this.pin = value;
            }
        }

        public int ChequingBalance
        {
            get
            {
                return this.chequingBalance;
            }
            set
            {
                this.chequingBalance = value;
            }
        }

        public int SavingsBalance
        {
            get
            {
                return this.savingsBalance;
            }
            set
            {
                this.savingsBalance = value;
            }
        }

        public int CreditCardBalance
        {
            get
            {
                return this.creditCardBalance;
            }
            set
            {
                this.creditCardBalance = value;
            }
        }

        public void Transfer(AccountType accountFrom, AccountType accountTo, int amount ) {

            if (accountFrom == AccountType.chequings && accountTo == AccountType.creditcard) { ChequingBalance -= amount; CreditCardBalance += amount; }
            if (accountFrom == AccountType.chequings && accountTo == AccountType.savings) { ChequingBalance -= amount; SavingsBalance += amount; }

            if (accountFrom == AccountType.creditcard && accountTo == AccountType.chequings) { CreditCardBalance -= amount; ChequingBalance += amount; }
            if (accountFrom == AccountType.creditcard && accountTo == AccountType.savings) { CreditCardBalance -= amount; SavingsBalance += amount; }

            if (accountFrom == AccountType.savings && accountTo == AccountType.creditcard) { SavingsBalance -= amount; CreditCardBalance += amount; }
            if (accountFrom == AccountType.savings && accountTo == AccountType.chequings) { SavingsBalance -= amount; ChequingBalance += amount; }

        }

        public void Deposit(AccountType accountTo, int amount) {
            if (accountTo == AccountType.chequings) { ChequingBalance += amount; }
            if (accountTo == AccountType.creditcard) { CreditCardBalance += amount; }
            if (accountTo == AccountType.savings) { SavingsBalance += amount; }
        }

        public void Withdraw(AccountType accountFrom, int amount) {
            if (accountFrom == AccountType.chequings) { ChequingBalance -= amount; }
            if (accountFrom == AccountType.creditcard) { CreditCardBalance -= amount; }
            if (accountFrom == AccountType.savings) { SavingsBalance -= amount; }
        }



    }
}
