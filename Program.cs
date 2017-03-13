using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAppTest
{
    class Program
    {
        // Response to job application at https://kaseya.bamboohr.co.uk/jobs/view.php?id=79&source=indeed&src=indeed&postedDate=2017-03-08

        static void Main(string[] args)
        {
            var bits = new string[]
            {
                "01000001", "01101110", "01111001", "00100000",
                "01100110", "01101111", "01101111", "01101100",
                "00100000", "01100011", "01100001", "01101110",
                "00100000", "01110111", "01110010", "01101001",
                "01110100", "01100101", "00100000", "01100011",
                "01101111", "01100100", "01100101", "00100000",
                "01110100", "01101000", "01100001", "01110100",
                "00100000", "01100001", "00100000", "01100011",
                "01101111", "01101101", "01110000", "01110101",
                "01110100", "01100101", "01110010", "00100000",
                "01100011", "01100001", "01101110", "00100000",
                "01110101", "01101110", "01100100", "01100101",
                "01110010", "01110011", "01110100", "01100001",
                "01101110", "01100100", "00101110", "00100000",
                "01000111", "01101111", "01101111", "01100100",
                "00100000", "01110000", "01110010", "01101111",
                "01100111", "01110010", "01100001", "01101101",
                "01101101", "01100101", "01110010", "01110011",
                "00100000", "01110111", "01110010", "01101001",
                "01110100", "01100101", "00100000", "01100011",
                "01101111", "01100100", "01100101", "00100000",
                "01110100", "01101000", "01100001", "01110100",
                "00100000", "01101000", "01110101", "01101101",
                "01100001", "01101110", "01110011", "00100000",
                "01100011", "01100001", "01101110", "00100000",
                "01110101", "01101110", "01100100", "01100101",
                "01110010", "01110011", "01110100", "01100001",
                "01101110", "01100100", "00101110", "00000000",
            };

            var msg = ConvertToASCII(bits);

            Console.WriteLine($"The message is '{msg}'.");
            Console.ReadLine();
        }

        private static string ConvertToASCII(string[] bits)
        {
            if (bits == null) return null;

            var chars = new char[bits.Length];

            for (int i = 0; i < bits.Length; i++)
            {
                var value = ConvertBinaryStringToInt(bits[i]);
                chars[i] = Convert.ToChar(value);
            }

            return new string(chars);
        }

        private static object ConvertBinaryStringToInt(string v)
        {
            var intValue = 0;
            var bitPos = v.Length;

            for (int i = 0; i < v.Length; i++)
            {
                intValue += v[--bitPos] == '1' ? (int)Math.Pow(2, i) : 0;
            }

            return intValue;
        }
    }
}
