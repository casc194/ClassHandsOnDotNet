﻿using System;

namespace HandsOnEnums
{
    public enum AccountType { Savings,Current,Joint};
    public enum Week:byte {Mon=10,Tue,Wed=30,Thu,Fri=40,Sat,Sun };
    public enum Engine : short { Start=1,Stop=0};
    class Program
    {
        public static AccountType AccountType { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(AccountType.Current); //Name of the Enumrator
            Console.WriteLine((int)AccountType.Current); //value of the Enumarator
            Program.AccountType = HandsOnEnums.AccountType.Joint;
            Console.WriteLine(Program.AccountType);
            Console.WriteLine((short)Engine.Start);
            
        }
    }
}
