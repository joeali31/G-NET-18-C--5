namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //int dayNumber;
            //bool isParsed;

            //do
            //{
            //    Console.Write("Enter a day number (1-7): ");

            //    isParsed = int.TryParse(Console.ReadLine(), out dayNumber);
            //    dayNumber -= 1;

            //    if (!Enum.IsDefined(typeof(Days), dayNumber))
            //    {
            //        isParsed = false;
            //    }
            //}
            //while (!isParsed);

            //Days day = (Days)dayNumber;

            //switch (day)
            //{
            //    case Days.Saturday:
            //    case Days.Friday:
            //        Console.WriteLine($"\tDay: {day}");
            //        Console.WriteLine($"\tit's the Weekend \n");
            //        break;
            //    default:
            //        Console.WriteLine($"\tDay: {day}");
            //        Console.WriteLine($"\tit's the Workday \n");
            //        break;
            //}
            #endregion


            #region Question2
            //int numberSize;
            //bool isparsed;

            ////take from user size of array with defensive code
            //do
            //{
            //    Console.Write("Enter array size: ");
            //    isparsed = int.TryParse(Console.ReadLine(), out numberSize);

            //    if (numberSize <= 1)
            //    {
            //        isparsed = false;
            //    }
            //}
            //while (!isparsed);

            //int[] arrNumbers = new int[numberSize];

            ////take from user element
            //for (int i = 0; i < arrNumbers.Length; i++)
            //{
            //    int number;

            //    do
            //    {
            //        Console.Write($"Enter Element [{i}]: ");

            //        isparsed = int.TryParse(Console.ReadLine(), out number);
            //    }
            //    while (!isparsed);

            //    arrNumbers[i] = number;
            //}

            ////sum of array
            //Console.WriteLine($"\nSum          = {arrNumbers.Sum()}");
            ////Average of array
            //Console.WriteLine($"Average      = {arrNumbers.Average()}");
            ////Max of array
            //Console.WriteLine($"Max          = {arrNumbers.Max()}");
            ////Min of array
            //Console.WriteLine($"Min          = {arrNumbers.Min()}");
            ////Reverse of array
            //Console.Write($"Reverse      = ");

            //for (int i = arrNumbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arrNumbers[i]);

            //    if (i == 0)
            //    {
            //        break;
            //    }

            //    Console.Write(", ");
            //}
            #endregion

        }
    }
}
