namespace Taskx17 {
    internal class Program {
        static void Main(string[] args) {
            int program = programSelect();

            object[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.3, "Hey", "No", "Yes" };
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Clear();

            switch (program) {
                case 1: {
                        Console.Write("Please enter your weight in kg: ");
                        double weight = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Please enter your size in cm: ");
                        double size = Convert.ToDouble(Console.ReadLine());

                        double bmi = CalculateBMI(weight, size);

                        Console.WriteLine("Your BMI is: " + bmi.ToString("0.00"));
                        break;
                    }
                case 2: {
                        Console.Write("Enter a random number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Another one please: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("And one more: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Thanks! Your sum is: " + calcSum(num1, num2, num3));
                        break;
                    }
                case 3: {
                        printArray(numbers);
                        break;
                    }
                case 4: {
                        Console.Write("Enter Array entry Position: ");
                        int pos1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter another Array entry Position: ");
                        int pos2 = Convert.ToInt32(Console.ReadLine());

                        object[] mixedArray = arrayMixUp(pos1, pos2, numbers);
                        Console.WriteLine("The elements in Array 'numbers' on position " + pos1 + " and " + pos2 + " will be switched!");
                        printArray(mixedArray);
                        break;
                    }
                case 5: {
                        Console.Write("Enter a number to check for: ");
                        int entry = Convert.ToInt32(Console.ReadLine());

                        if (checkForEntry(entry, ints)) {
                            Console.WriteLine("The number " + entry + " is in the Array!");
                        } else {
                            Console.WriteLine("The number " + entry + " is not in the Array!");
                        }
                        break;
                    }
                case 6: {
                        Environment.Exit(0);
                        break;
                    }
            }

            Thread.Sleep(5000);

            Main(args);
        }

        static int programSelect() {
            Console.Clear();

            Console.WriteLine("Please select a program to run:");
            Console.WriteLine("1: BMI Calculator");
            Console.WriteLine("2: Sum Calculator");
            Console.WriteLine("3: Array Printer");
            Console.WriteLine("4: Array Mixer");
            Console.WriteLine("5: Array Entry Checker");
            Console.WriteLine("6: Exit Program");
            Console.WriteLine("\n");
            Console.Write("Enter your selection: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            return selection;
        }

        static double CalculateBMI(double weight, double size) {
            Console.WriteLine("Calculating BMI");

            size /= 100;

            double bmi = weight / (size * size);

            return bmi;
        }

        static double calcSum(double num1, double num2, double num3) {
            double sum = num3 - (num1 + num2);

            return sum;
        }

        static void printArray(object[] array) {
            Console.WriteLine("Printing Array Elements:");
            foreach (object element in array) {
                Console.WriteLine(element);
            }
        }

        static object[] arrayMixUp(int pos1, int pos2, object[] array) {
            object valPos1 = array[pos1];
            object valPos2 = array[pos2];

            array[pos1] = valPos2;
            array[pos2] = valPos1;

            return array;
        }

        static bool checkForEntry(int entry, int[] array) {
            foreach (int element in array) {
                if (element == entry) {
                    return true;
                }
            }

            return false;
        }
    }
}