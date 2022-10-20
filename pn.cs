namespace perfect number
{
    internal class
    {
        public static int FindPerfectNum(int number)
       
{
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)        //Check Number % i  is equal To 0
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number"); //Accept Value From User
            int number = Convert.ToInt32(Console.ReadLine());

            int Result = FindPerfectNum(number); //Decalre A Function To Check Given Number Prfect 

            if (number == Result)          //Here Check Number Is equal To Result
            {
                Console.WriteLine("Given Number Is A Perfect Number");
            }
            else
            {
                Console.WriteLine("Given Number Is Not A Perfect Number");
            }
        }
    }
}

