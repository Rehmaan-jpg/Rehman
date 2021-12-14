using System;

namespace L4._6_BlockBacterialFrequencyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bacterial Frequency Table");
            // Your codes here
                int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int sum1 = 0;
            int sum2 = 0; 
            int sum3 = 0;
            int sum4 = 0;
            int length = 0;
            float percent1 = 0;
            float percent2 = 0;
            float percent3 = 0;
            float percent4 = 0;
            float totalCount = 0;
            float mean = 0;
            float totalSum = 0;
            int max = 0;
            int min = 800;

            do
            {
                Console.WriteLine("Enter Length of Bacteria: ");
                length = int.Parse(Console.ReadLine());
                if (length < 800)
                {
                    if (length > max)
                {
                    max = length;
                }
                if (length < min)
                {
                    length = min;
                }
                if (length < 200)
                {
                    count1++;
                    sum1 = length + sum1;
                }
                else if (length >= 200 && length <=399)
                {
                    count2++;
                    sum2 = length + sum2;
                }
                else if (length >= 400 && length <= 599)
                {
                    count3++;
                    sum3 = length + sum3;
                }
                else if (length >= 600 && length <=799)
                {
                    count4++;
                    sum4 = length + sum4;
                    }

                }
            }
            while ( length < 800);

            totalCount = count1 + count2 + count3 + count4;
            totalSum = sum1 + sum2 + sum3 + sum4;
            mean = totalSum / totalCount;


            percent1 = ((float)count1 / totalCount) * 100;
            percent2 = ((float)count2 / totalCount) * 100;
            percent3 = ((float)count3 / totalCount) * 100;
            percent4 = ((float)count4 / totalCount) * 100;

            Console.WriteLine( "| {0,11} | {1,11} | {2,11} | {3,11} |", "Range" , "Count" , "Sum Lengths" , " Percentage " );
            Console.WriteLine( "| {0,11} | {1,11} | {2,11} | {3,11} |","==========" , "==========" , "==========" , "==========");
            Console.WriteLine( "| {0,11} | {1,11} | {2,11} | {3,11} |"," <200 " , count1 , sum1 , percent1.ToString("F2"));
            Console.WriteLine( "| {0,11} | {1,11} | {2,11} | {3,11} |"," 200-399 " , count2 , sum2 , percent2.ToString("F2"));
            Console.WriteLine( "| {0,11} | {1,11} | {2,11} | {3,11} |"," 400-599 " , count3 , sum3 , percent3.ToString("F2"));
            Console.WriteLine( "| {0,11} | {1,11} | {2,11} | {3,11} |"," 600-799 " , count4 , sum4 , percent4.ToString("F2"));
            Console.WriteLine("The Mean Length of Bacteria is: " + mean.ToString("F2"));
            Console.WriteLine("The Maximum Length is: " + max.ToString("F2"));
            Console.WriteLine("The Minimum Length is: " +min.ToString("F2"));
        
        }
    }
}
