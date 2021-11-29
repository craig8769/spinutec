namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number To Check Palindrome : ");
            string snumber = Console.ReadLine();
            if (snumber == null) { snumber = "0"; }
            int number = int.Parse(snumber);
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                remineder = number % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + remineder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
    
