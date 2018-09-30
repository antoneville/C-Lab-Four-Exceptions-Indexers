using System;

namespace Maths
{
    class Calculator
    {
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
        void Main()
        {   
            String one = "2.4F";
            String two = "3.2F";
            Double.Parse(one);
            Double.Parse(two);
            Calculator cTwo = new Calculator();
            cTwo.calcFloat(one, two);
        }
    }

}
