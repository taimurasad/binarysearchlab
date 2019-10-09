using System;

namespace ConsoleApp2
{
    class Program
    {
        static int BinarySearch(int[] arr, int value, int LB, int UB)
        {
            //UB = arr.Length;
            if (LB > UB)
            {
                //Console.WriteLine("Value does not exist.");
                return -1;
            }
            int mid = (LB + UB) / 2;


            if (value < arr[mid])
            {
                return BinarySearch(arr, value, LB, mid-1);
            }
            else if (value > arr[mid])
            {
                return BinarySearch(arr, value, mid+1, UB);
            }
            else
            {
                return mid;
            }


        }
        static void Main(string[] args)
        {
            int[] NUMBERS = { 7, 12, 33, 35, 49, 56, 57, 60, 74, 98, 99 };

            int value01 = 35;
            int value02 = 78;
            int counter = 0;

            for (int i = 0; i < 11; i++)
            {
                int search = BinarySearch(NUMBERS, value01, 0, 11);
                //////////////////int[] arr = { 1, 2, 3, 4, 5 };
                //////////////////Console.WriteLine(BinarySearch(arr, 3, 0, 4));
                //int[] arr = { 2, 3, 4, 10, 40 };
                //int n = arr.Length;
                //int x = 10;

                //int result = BinarySearch(arr, x, 0, n - 1);

                //if (result == -1)
                //    Console.WriteLine("Element not present");
                //else
                //    Console.WriteLine("Element found at index "
                //                      + result);
                if (search != -1)
                {



                    if (NUMBERS[i] == NUMBERS[search])
                    {
                        //array01[i] = array01[i + 1];
                        for (int p = i; p < 11; p++)
                        {
                            if (p != (NUMBERS.Length - 1))
                                NUMBERS[p] = NUMBERS[p + 1];

                        }

                        counter++;
                    }
                }


                int search1 = BinarySearch(NUMBERS, value02, 0, 11);
                if (search1 != -1)
                {
                    
                    if (NUMBERS[i] == NUMBERS[search1])
                    {
                        //array01[i] = array01[i + 1];
                        for (int p = i; p < 11; p++)
                        {
                            if (p != (NUMBERS.Length - 1))
                                NUMBERS[p] = NUMBERS[p + 1];

                        }

                        counter++;
                    }

                }
            }
            for (int i = 0; i < (11 - counter); i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + NUMBERS[i]);
            }



        }
    }
}
