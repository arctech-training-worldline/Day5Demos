using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    internal static class DemoBitwiseOperators
    {
        /// <summary>
        /// Refer attached file "Algorithm explanation = Swap bits 3 4 5 with 24 25 26.xlsx"
        /// which explains graphically with single byte how to do bits swapping.
        /// </summary>
        public static void TestSwapBits()
        {
            uint num = 748654965;
            /*
             * ~ & | ^ << >>
             */

            //                   87654321876543218765432187654321
            //                   ______***__________________***__
            // source num      = 00101100100111111001000101110101
            // expected answer = 00101110100111111001000101100101

            uint ans = ((0b00000000000000000000000000011100 & num) << 21) |
                       ((0b00000011100000000000000000000000 & num) >> 21) |
                        (0b11111100011111111111111111100011 & num);

            /*
             * 1. get the 1st set of bits and save in tmp1
             * 2. get the 2nd set of bits and save in tmp2
             * 3. LEFT Shift 1st set of bits into the 2nd space => tmp1
             * 4. RIGHT Shift 2nd set of bits into the 1nd space => tmp2
             * 5. Merge tmp1 & tmp2
             * 6. get number bits with the swapping bits off
             * 7. Final answer by ORing last 2 numbers from point 5 and 6 above
            */

            //1.get the 1st set of bits and save in tmp1
            uint tmp1 = 0b00000000000000000000000000011100 & num;
            //            ___________________________***__
            //   tmp1 =   00000000000000000000000000010100

            //2.get the 2nd set of bits and save in tmp2
            uint tmp2 = 0b00000011100000000000000000000000 & num;
            //            ______***_______________________
            //   tmp2 =   00000000100000000000000000000000

            //3. LEFT Shift 1st set of bits into the 2nd space => tmp1
            tmp1 <<= 21;
            //4. RIGHT Shift 2nd set of bits into the 1nd space => tmp2
            tmp2 >>= 21;
            //            ______***__________________***__
            //   tmp1 =   00000010100000000000000000000000
            //   tmp2 =   00000000000000000000000000000100

            //5.Merge tmp1 & tmp2
            uint merged = tmp1 | tmp2;
            //            ______***__________________***__
            // merged =   00000010100000000000000000000100

            //6. get number bits with the swapping bits off
            uint tmp3 = 0b11111100011111111111111111100011 & num;
            //            ______***__________________***__
            //    num =   00101100000111111001000101100001

            //7. Final answer by ORing last 2 numbers from point 5 and 6 above
            uint ans2 = merged | tmp3;
            

            Console.Write($"        ______***__________________***__\n");
            Console.Write($"num   = {ToBinary(num)}\n");
            Console.Write($"ans   = {ToBinary(ans)}\n");
            Console.Write($"        ______***__________________***__\n");
            Console.Write($"tmp1  = {ToBinary(tmp1)}\n");
            Console.Write($"tmp2  = {ToBinary(tmp2)}\n");
            Console.Write($"merged= {ToBinary(merged)}\n");
            Console.Write($"tmp3  = {ToBinary(tmp3)}\n");
            Console.Write($"        ______***__________________***__\n");
            Console.Write($"ans2  = {ToBinary(ans2)}\n");
        }

        private static string ToBinary(uint num)
        {
            return Convert.ToString(num, 2).PadLeft(32, '0');
        }
    }
}
