using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string MyString = "My \"so-called\" life";
            // string MyString = @"Go to your c:\ Drive";
            //string MyString = string.Format("{0:C}", 123.45); for currency
            // string MyString = string.Format("{0:N}", 1234567890); format number for easy readabilty

            //string MyString = string.Format("Percentage: {0:P}", .123);

            string MyString = string.Format("Phone number: {0:(###) #### ####}", 1234567899990);

            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}
