using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAnswer = 0;
            Random n = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("What size of array");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] array = CreateArray(Size, n);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            menu(array);


        }
        static int[] CreateArray(int size, Random r)
        {
            int[] array = new int[size];
            for (int k  = 0; k < array.Length; k++)
            {
                array[k] = r.Next(0, 100);
            }
            Console.WriteLine("Array from 1 to 100 created");
            return array;
        }
        static void menu(int[] array)
        {
            Console.WriteLine("1. Linear search");
            Console.WriteLine("2. Binary search");
            Console.WriteLine("3. Merge sort");
            Console.WriteLine("4. Bubble sort");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Write the number");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userAnswer);
            if (userAnswer == 1)
            {
                Console.WriteLine("What would you like to find");
                int numToFind = Convert.ToInt32(Console.ReadLine());
                LinearSearch(array, numToFind);
            }
            else if (userAnswer == 2)
            {
                Console.WriteLine("What would you like to find");
                int numToFind = Convert.ToInt32(Console.ReadLine());
                LinearSearch(array, numToFind);
            }
            else if (userAnswer == 3)
            {
                BubbleSort(array);
            }
            else if(userAnswer == 4)
            {
                MergeSortRecursive
            }


        }
        
        static void BubbleSort(int[] a)
        {
            
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {

        }
        static bool BinarySearch(int[] a, int numToFind)
        {
            
        }
            
    }
}
