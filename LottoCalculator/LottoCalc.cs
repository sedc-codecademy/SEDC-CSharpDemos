using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoCalculator
{
    class LottoCalc
    {
        public int NumberOfBalls { get; private set; }

        private int numberDrawn;
        public int NumberDrawn
        {
            get
            {
                return numberDrawn;
            }
            set
            {
                if (value > NumberOfBalls)
                    throw new InvalidOperationException("Number drawn cannot be higher than total number");
                numberDrawn = value;
            }
        }

        public string Name { get; set; }

        public LottoCalc(string name, int numberOfBalls, int numberDrawn)
        {
            if (numberOfBalls < numberDrawn)
                throw new InvalidOperationException("Number drawn cannot be higher than total number");
            this.NumberOfBalls = numberOfBalls;
            this.numberDrawn = numberDrawn;
            this.Name = name;
        }

        public ulong Calculate()
        {
            var result = Factoriel(NumberOfBalls) /
                         Factoriel(numberDrawn)/
                         Factoriel(NumberOfBalls - numberDrawn);
            return result;  
        }

        //ulong Factoriel(int number)
        //{
        //    var result = 1ul;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= (ulong)i;
        //    }
        //    return result;
        //}

        private ulong Factoriel(int number)
        {
            if (number == 0)
                return 1;

            return (ulong)number*Factoriel(number - 1);
        }
    }
}
