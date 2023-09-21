using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab3
{
    public struct BankAccount
    {
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
    }

    public enum AccountType
    {
        Savings,
        Current
    }
    public struct Worker
    {
        public Names Name1 { get; set; }
        public VUZS VUZ1 { get; set; }
        public Names Name2 { get; set; }
        public VUZS VUZ2 { get; set; }
        public Names Name3 { get; set; }
        public VUZS VUZ3 { get; set; }
    }
    public enum Names
    {
        Petr,
        Alexander,
        Fedor
    }
    public enum VUZS
    {
        KGU,
        KAI,
        KXTI
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1 (необходимо создать переменную типа перечисления, присвоить ей значение и вывести это значение): ");
            AccountType account = AccountType.Savings;
            Console.WriteLine($"Счет: {account.ToString()}");

            Console.WriteLine("Упражнение 3.2 (необходимо cоздать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс): ");
            BankAccount bankAccount = new BankAccount
            {
                AccountNumber = "439",
                AccountType = AccountType.Savings,
                Balance = 128000
            };
            Console.WriteLine($"Account Number: {bankAccount.AccountNumber}");
            Console.WriteLine($"Account Type: {bankAccount.AccountType}");
            Console.WriteLine($"Balance: {bankAccount.Balance}");

            Console.WriteLine("Домашнее задание 3.1 (необходимо создать структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и вывести)");
            Worker worker = new Worker
            {
                Name1 = Names.Petr,
                VUZ1 = VUZS.KGU,
                Name2 = Names.Alexander,
                VUZ2 = VUZS.KAI,
                Name3 = Names.Fedor,
                VUZ3 = VUZS.KXTI,

            };
            Console.WriteLine($"1 Работник: {worker.Name1}");
            Console.WriteLine($"ВУЗ: {worker.VUZ1}");
            Console.WriteLine($"2 Работник: {worker.Name2}");
            Console.WriteLine($"ВУЗ: {worker.VUZ2}");
            Console.WriteLine($"3 Работник: {worker.Name3}");
            Console.WriteLine($"ВУЗ: {worker.VUZ3}");
        }
    }
}
