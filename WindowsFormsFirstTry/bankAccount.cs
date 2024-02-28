using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFirstTry
{


    internal class operationHistory
    {
        public string operationType { get; set; }
        public int amount { get; set; }
        public DateTime operationDate{ get; set; }

        public operationHistory(string operationType, int amount, DateTime operationDate)
        {
            this.operationType = operationType;
            this.amount = amount;
            this.operationDate = operationDate;
        }
    } 
    internal class Owner
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportNumber { get; set; }

        // Конструктор
        public Owner(string fullName, DateTime dateOfBirth, string passportNumber)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PassportNumber = passportNumber;
        }
    }
   
   
    internal class bankAccount
    {
        public long number { get; set; }
        public string accountType { get; set; }
        public decimal balance { get; set; }
        public DateTime dateOpened { get; set; }
        public bool smsNotification { get; set; }
        public bool internetBanking { get; set; }
        public Owner Owner { get; set; }
        public  operationHistory operationHistory { get; set; }

        public bankAccount(long number, string accountType, decimal balance, DateTime dateOpened, bool smsNotification, bool internetBanking, string ownerFullName, DateTime ownerBirth, string ownerPassport,string operationType,int amount, DateTime operationDate)
        {
            this.number = number;
            this.accountType = accountType;
            this.balance = balance;
            this.dateOpened = dateOpened;
            this.smsNotification = smsNotification;
            this.internetBanking = internetBanking;
            Owner = new Owner(ownerFullName, ownerBirth, ownerPassport);
            operationHistory = new operationHistory(operationType, amount, operationDate);
        }

    }
}



