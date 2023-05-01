namespace OperatorExercise
{
    public class Program
    {
        //-----------Exercise 1-------
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        static double Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int num1, int num2)
        {

            return num1 * num2;
        }
        static string RemainderOfDivision(int a, int b)
        {
            int result = a / b;
            int remainder = a % b;
            string answer = ("The result of division of  " + a + "/" + b + "  " + result.ToString() + " and remainder is " + result.ToString());
            return answer;
        }
        //-----------Exercise2-----------
        static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3.5));
            Console.WriteLine(Subtract(2, 5));
            Console.WriteLine(Multiply(9, 4));
            Console.WriteLine(RemainderOfDivision(17, 4));
            Console.Write("Type a number for radius: ");
            var circleRadius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(circleRadius));
            var i = 3;
            var j = 4;
            var k = ++i * j++;
        }
    }
}
        