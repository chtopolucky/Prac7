using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр5
{
    public class Pair
    {
        int one, second;
        public int One 
        {
            get
            {
                return one;
            }
            set
            {
                if (value % 2 == 0) one = value;
            }
        }//первое число
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value % 2 == 0) second = value;
            }
        }//второе число
        public Pair Multiply(Pair value)//метод вычисления произведения пар
        {
            Pair multiplyPairs = new Pair();// объект содержащий результат умножения
            multiplyPairs.One = One * value.One;
            multiplyPairs.Second = Second * value.Second;
            return multiplyPairs;//результат умножения пар
        }
        public void Multiply()
        {
            One = One * 2;
            Second = Second * 2;
        }
        public static Pair operator ++(Pair c1)
        {
            Pair result = new Pair();
            result.One = c1.One + c1.One;
            result.Second = c1.Second + c1.Second;
            return result;
        }
        public static Pair operator *(Pair c1, Pair c2)
        {
            Pair resultMultiplyPair = new Pair();
            resultMultiplyPair.One = c1.One * c2.One;
            resultMultiplyPair.Second = c1.Second * c2.Second;
            return resultMultiplyPair;
        }
    }
    public class RightAngled : Pair
    {

        public double AnswerHypoenuse()
        {
            return Math.Round(Math.Sqrt(Math.Pow(One, 2) + Math.Pow(Second, 2)), 2);
        }
        public double AnswerArea()
        {
            double p = (One + Second + AnswerHypoenuse()) / 2;
            return Math.Round(Math.Sqrt(p * (p - One) * (p - Second) * (p - AnswerHypoenuse())), 2);
        }
    }
}
