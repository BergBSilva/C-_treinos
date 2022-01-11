using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            //int[] myArray = new int[] { 1, 10, 9, 8, 2 };
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = rand.Next(101);
            }
            PrintArray(myArray);
            QuickSort(myArray, 0, myArray.Length - 1);
            Console.WriteLine();
            PrintArray(myArray);

        }
        private static void QuickSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex)
            {
                return;

            }

            int pivot = array[highIndex];
            int leftPointer = lowIndex;
            int rightPointer = highIndex;
            while (leftPointer < rightPointer)
            {
                while (array[leftPointer] <= pivot && leftPointer < rightPointer)
                {
                    leftPointer++;
                }
                while (array[rightPointer] >= pivot && leftPointer < rightPointer)
                {
                    rightPointer--;
                }

                Swap(array, leftPointer, rightPointer); 

            }

            Swap(array, leftPointer, highIndex);
            QuickSort(array, lowIndex, leftPointer - 1);
            QuickSort(array, leftPointer + 1, highIndex);


        }

        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private static void PrintArray(int[] array)
        {
            /*
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");    
            }
            */
            foreach(var value in array)
            {
                Console.WriteLine(value);
            }
        }

    }

    




}


