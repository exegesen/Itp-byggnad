class Calculator { 

    static void Main(string[] args) {
        while (true) {
            Console.WriteLine("Welcome to calculator! Enter operation");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtraction");
            Console.WriteLine("3 Division");
            Console.WriteLine("4 Multiplication");
            Console.WriteLine("5 Exit");
            int input = Int32.Parse(Console.ReadLine());
            if (input == 1) {
                Console.WriteLine("Enter first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + Addition(num1, num2));
            }
            else if (input == 2) {
                Console.WriteLine("Enter first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + Subtraction(num1, num2));
            }
            else if (input == 3) {
                Console.WriteLine("Enter first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + Division(num1, num2));
            }
            else if (input == 4) {
                Console.WriteLine("Enter first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + Multiplication(num1, num2));
            }
            else if (input == 5) {
                System.Environment.Exit(0);
            }

        }

        double Addition(double a, double b) {
            double result = 0;
            result = a + b;
            return result;
        }
        double Subtraction(double a, double b)
        {
            double result = 0;
            result = a - b;
            return result;
        }
        double Division(double a, double b)
        {
            double result = 0;
            if (b == 0) {
                Console.WriteLine("NaN: Not a Number");
                return double.NaN;
                Console.WriteLine("NaN: Not a Number");
            }
            result = a / b;
            return result;
        }
        double Multiplication(double a, double b)
        {
            double result = 0;
            result = a * b;
            return result;
        }

    }
}