namespace ASSIGNMENT_5_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask User for input
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());  // Read and convert input to an integer

            // Calculate the sum of digits and print the result
            int result = SumDigits(num);
            Console.WriteLine("The sum of the digits of the number" + num + "is : " + result);

        }
    }
 public class SumOfDigits
 {
        public static int SumDigits(int num)
        { 
           int sum  = 0;

            //Convert the number to a string
            string numStr = num.ToString();

            //Use a for loop to interate through each character in the string representation of the number
            for (int i = 0; i < numStr.Length; i++)
            {
                //Convert the character to an interger and add it to the sum
                sum += numStr[i] - '0'; //Subtracting '0' converts the char to its corresponding digits value
            }

            return sum;
        
        
        }
 }
}
