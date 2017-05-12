﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hamming Distance solution 1
            HammingDistance hammingDistance1 = new HammingDistance(20,30);
            hammingDistance1.solutionOne();

            //Hamming Distance solution 2
            HammingDistance hammingDistance2 = new HammingDistance(20, 30);
            hammingDistance2.solutionTwo();

            //Reverse Bits
            ReverseBits reverseBits = new ReverseBits();
            uint n=reverseBits.reverseBits(1);

            //Power of Two
            PowerOfTwo checkPowerOfTwo = new PowerOfTwo();
            checkPowerOfTwo.IsPowerOfTwo(9);

            //Binary Watch
            BinaryWatch checkBinaryWatch=new BinaryWatch();
            checkBinaryWatch.ReadBinaryWatch(1);

            LetterCombPhone phone = new LetterCombPhone();
            phone.LetterCombinations("2");
        }
    }
}
