using System;

namespace Maths
{
    class Calculator
    {
        double[] numbers = new double[2];
        public double this[int index]
        {
            get
            {
                if (index < 0 && index >= numbers.Length)
                throw new IndexOutOfRangeException("Cannot store more than 2 objects");
                
                return numbers[index];
            }
            set 
            {   if (index < 0 && index >= numbers.Length)
                throw new IndexOutOfRangeException("Cannot store more than 2 objects");
                 
             numbers[index] = value; 
            }
        }
        static public float calcFloat(float numOne, float numTwo) 
        {
            if (numTwo == 0)
            {
                throw new ArgumentException();
            } 
            else
            {
                float divide = numOne/numTwo;
                return divide;
            }
        }
    }

    class Test
    {
        static void Main()
        {   
            Calculator cTwo = new Calculator();
            cTwo[0] = 2.4;
            cTwo[1] = 1.2;

                for(int i = 0; i < 2; i++)
                Console.WriteLine(Double.Parse(cTwo[i].ToString()));
                


        }
    }

}
