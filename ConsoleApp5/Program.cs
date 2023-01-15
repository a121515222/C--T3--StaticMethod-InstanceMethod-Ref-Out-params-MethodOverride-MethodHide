using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSpace;
using SampleSpace;
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bank.TotalMoney);
            Console.WriteLine(Bank.Add(50000));
            Console.WriteLine(Bank.Spent(100));

            decimal sumSave;
            decimal avgSave;
            // overlord 同名的method隨著傳入的參數不同做出不同的反映
            Bank.SaveAvgAndSum(100,500,out sumSave, out avgSave);
            Console.WriteLine($"sum:{sumSave}");
            Console.WriteLine($"avg:{avgSave}");
            
            Console.WriteLine("input string number");
            Bank.SaveAvgAndSum("8000", "4000", out sumSave, out avgSave);

            Console.WriteLine("showRef");
            int number = 55;
            Bank.NonRef(number);
            Console.WriteLine(number);
            Bank.ShowRef(ref number);
            Console.WriteLine(number);
            Console.WriteLine("ShowParams");
            Bank.ShowParams();
            Console.WriteLine("ShowParams");
            int[] numArry = { 1, 2, 3 };
            Bank.ShowParams(numArry);
            Console.WriteLine("ShowParams");
            Bank.ShowParams(5,6,7);

            Console.WriteLine("Overrider and Hide");

            ClassA myClass = new ClassA();
            Console.WriteLine("ClassA的method=====");
            myClass.SampleOverrideMethod();
            
            ClassA myClassB = new ClassB();
            Console.WriteLine("ClassB的Override ClassA 的method=====");
            myClassB.SampleOverrideMethod();
            Console.WriteLine("ClassA的method========");
            myClass.SampleMethod();
            ClassA myClassC = new ClassC();
            Console.WriteLine("ClassC的method但是因為以ClassA為TYPE所以以ClassA的method為主所以產生method hide");
            myClassC.SampleMethod();
            ClassC myClassC2 = new ClassC();
            Console.WriteLine("ClassC的method但是因為以ClassC為TYPE解決Hide的問題'");
            myClassC2.SampleMethod();


            Base1 myBase2 = new Sub1();
            myBase2.Print();
        }
    }
}
