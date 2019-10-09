using System;
    class Program
    {
        static void Main(string[] args)
        {

                int numCase = 0;
                //Console.WriteLine("Enter Number of Total Cases");
                //get number of cases from user
                numCase = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numCase; i++)
                {
                    int[] numPerCase = new int[5000];
                    string[] caseStrings = new string[5000];
                    int counter = 0;
                    int temp3 = (i + 1);
                    //Console.WriteLine("Enter Number of strings for case: " + temp3);
                    //get number of strings for current case
                    numPerCase[i] = Convert.ToInt32(Console.ReadLine());
                    //read in the amount of strings per 
                    for (int x = 0; x < numPerCase[i]; x++)
                    {
                        int temp = (x + 1);
                        int temp2 = (i + 1);
                        //Console.WriteLine("Enter string number: " + temp + " for test case " + temp2);
                        //get strings for each case
                        caseStrings[counter] = Console.ReadLine();
                        counter++;
                    }
                    //call heapSort to sort each case
                    heapStart(caseStrings, 5000);
                    //print sorted array
                    for (int y = 0; y < caseStrings.Length; y++)
                    {
                        if (caseStrings[y] != "" && caseStrings[y] != null)
                            Console.WriteLine(caseStrings[y]);
                    }
                }
                Environment.Exit(0);
            }
            
        

        static void heapStart(string[] caseStrings, int size)
        {
            for(int i = size / 2 - 1; i >= 0; i--)
            {
                heapSort(caseStrings, size, i);
            }
            //swap
            for(int i = size-1; i>=0; i--)
            {
                string temp = caseStrings[0];
                caseStrings[0] = caseStrings[i];
                caseStrings[i] = temp;
                heapSort(caseStrings, i, 0);
            }
        }

        static void heapSort(string[] caseStrings, int size, int i)
        {
            int right = 2 * i + 2;
            int left = 2 * i + 1;
            int large = i;
            if (left < size && string.CompareOrdinal(caseStrings[left], caseStrings[large]) > 0)
            {
                large = left;
            }
            if (right < size && string.CompareOrdinal(caseStrings[right], caseStrings[large]) > 0)
            {
                large = right;
            }
            //swap
            if(large != i)
            {
                string temp = caseStrings[i];
                caseStrings[i] = caseStrings[large];
                caseStrings[large] = temp;
                heapSort(caseStrings, size, large);
            }
        }
    }

