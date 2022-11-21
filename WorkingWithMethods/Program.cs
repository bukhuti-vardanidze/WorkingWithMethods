namespace WorkingWithMethods
{
    class Program
    {
        static void Main()
        {



            //Console.Write("enter some phrase : ");
            //string phrase = console.readline();
            //int c = CounterPhrase(phrase);
            //Console.Write(c);


            //PhrasePrinter();
            //  IndexPrinter();


            //int[] array = new int[10];
            // int[] result =  FillArr(array);
            int[] recurArray = { 1, 5, 6, 23, 66, 64, 12, 56, };
            PrintArray(recurArray);

            Console.ReadLine();
        }



        static int CounterPhrase(string PhraseCounter)
        {
            return  PhraseCounter.Count();
        }

        static void PhrasePrinter() 
        {
            Console.Write("enter some phrase : ");
            string Phrase = Console.ReadLine();
            //  int counter = Phrase.Count();
            Console.Write("enter how many times want to print phrase : ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < number; i++) 
            {
                Console.WriteLine(Phrase);
            }


        }

        static void IndexPrinter()
        {
            try
            {
                Console.Write("enter one of array numbers and show index  : ");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] numbers = { 5, 8, 7, 9, 2, 7, 70, 3, 1, 96, 25, 45 };
                for (int i = 0; i < numbers.Length; i++)
                {

                    // Console.WriteLine(numbers[i]);

                    if (number == numbers[i])
                    {
                        Console.WriteLine(i);
                    }
                }
               
            }
            catch
            {
                Console.WriteLine(-1);
            }
            
        }

        static int[] FillArr(int[] arr)
        {
            Random random= new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
            return arr;

        }

        // using recursion

        static void PrintArray(int[] recrArr, int iterator = 0)
        {
            if(iterator < recrArr.Length)
            {
                Console.WriteLine(recrArr[iterator]);
                PrintArray(recrArr, iterator + 1);
            }

        }

    }
}