using System;

namespace bmi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your height in meter and decimal separator is point not comma and thousand separator is ignored");
            double height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight in kg");
            double weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2);//Sử dụng hàm Math.Pow(x,2) để bình phương của một số.

            bmi = Math.Round(bmi, 1);//Math.Round(10.4531, 2), khi đó 10.4531 là số cần làm tròn và làm tròn lên 2 chữ số. Kết quả sẽ là 10.45.

            Console.WriteLine("Your BMI is: "+ bmi);

            if (bmi < 18.5)
                Console.WriteLine("You are Underweight.");
            else if (bmi < 25.0)
                Console.WriteLine("You are Normal.");
            else if (bmi < 30.0)
                Console.WriteLine("You are Overweight.");
            else
                Console.WriteLine("You are Obese.");

        }
    }
}