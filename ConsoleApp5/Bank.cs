using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSpace
{
    public static class Bank
    {
        private static decimal _totalMoney;

        static Bank()
        {
            _totalMoney = 10000;
        }
        public static decimal TotalMoney
        {
            get { return _totalMoney; }
        }
        public static decimal Add(decimal saveMoney)
        {

            _totalMoney = _totalMoney + saveMoney;
            return _totalMoney;
        }
        public static decimal Spent(decimal saveMoney)
        {
            _totalMoney = _totalMoney - saveMoney;
            return _totalMoney;
        }
        public static void SaveAvgAndSum(decimal saving, decimal daving2, out decimal sum, out decimal avg)
        {
            sum = saving + daving2;
            avg = sum / 2;
            _totalMoney = _totalMoney + sum;
            Console.WriteLine($"CurrentBankMomey:{_totalMoney}");
        }
        public static void SaveAvgAndSum(string saving, string saving2, out decimal sum, out decimal ave)
        {
            decimal parse1;
            decimal parse2;

            Decimal.TryParse(saving, out parse1);
            Decimal.TryParse(saving2, out parse2);
            sum = parse1 + parse2;
            ave = sum / 2;
            _totalMoney = _totalMoney + sum;
            Console.WriteLine($"CurrentBankMomey:{_totalMoney}");
        }
        // ref 是傳參考
        public static void NonRef(int num)
        {
            num = 100;
        }
        public static void ShowRef(ref int num)
        {
            num = 100;
        }
        //params 參數是可以變動的，不用因為參數個數的不一樣而多載相同邏輯的程式。
        //params的參數必須要同一型別，整數就只能搭配整數，不能一個整數一個字串
        //params的參數個數可0～n個
        //params要搭配一個一維陣列來宣告
        //params的參數必須要在參數中的最後一個，且只能一個
        public static void ShowParams(params int[] num)
        {
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
