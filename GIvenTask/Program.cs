namespace GIvenTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string str = "xushnudbek";

            Console.Write("enter optional number: ");
            int optnum = Convert.ToInt32(Console.ReadLine());

            string satr = "";

            if (optnum > str.Length)
            {
                satr = str.ToUpper();
            }
            else
            {
                satr = str.ToLower();
            }

            Console.WriteLine(satr);

            // Task 2

            int firstnumber = 7;
            int secondnumber = 7;

            if (firstnumber > secondnumber)
            {
                Console.WriteLine("first is greater than second");
            }
            else if (firstnumber < secondnumber)
            {
                Console.WriteLine("first is less than second");
            }
            else if (firstnumber == secondnumber)
            {
                Console.WriteLine("both numbers are equal to each other");
            }
            else
            {
                Console.WriteLine("e given numbers cannot be compared!");
            }

            // Task 3

            Console.Write("Enter a certain weekday: ");
            string Progress = Console.ReadLine();
            string weekday = Progress switch
            {
                "Dushanba" => "Monday",
                "Seshanba" => "Tuesday",
                "Chorshanba" => "Wednesday",
                "Payshanba" => "Thursday",
                "Juma" => "Friday",
                "Shanba" => "Saturday",
                "Yakshanba" => "Sunday",
                _ => "no such day"
            };

            Console.WriteLine(weekday);
        }
    }
}
