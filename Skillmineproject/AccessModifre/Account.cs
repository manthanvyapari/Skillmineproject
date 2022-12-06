using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.AccessModifre
{
    class Account
    {
        int accountno;
        string accounttype;
        string costomername;
        int balence;

        public int Accountno { get => accountno; set => accountno = value; }
        public string Accounttype { get => accounttype; set => accounttype = value; }
        public string Costomername { get => costomername; set => costomername = value; }
        public int Balence { get => balence; set => balence = value; }
    }
    class Account_info
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.Accountno=551022100;
            a.Accounttype = "Saving Account";
            a.Costomername = "MANTHAN ANANTRAO VYAPARI";
            a.Balence = 100;
            Console.WriteLine(a.Accountno + " " + a.Accounttype + " " + a.Costomername + " " + a.Balence);

        }
    }
}
