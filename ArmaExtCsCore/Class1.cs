using Maca134.Arma.DllExport;
using System;
using System.Text;

namespace ArmaExtCsCore
{
    public class DllEntry // This can be named anything you like
    {
        // This 2 line are IMPORTANT and if changed will stop everything working
        // To send a string back to ARMA append to the output StringBuilder, ARMA outputSize limit applies!
        [ArmaDllExport]
        public static string Invoke(string input, int size)
        {
            StringBuilder output = new StringBuilder();
            // Reverses the input string
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string result = new string(arr);
            output.Append(result);
            return output.ToString();
        }

        [ArmaDllExport]
        public static string normalReply(string input, int size)
        {
            return input;
        }
    }
}
