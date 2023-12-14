// Задача 1: Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


 class Program
    {
        static void Main(string[] args)
        {

            int[,] array = GenerateArray(4, 4);
            PrintArray(array);

            Console.Write("Введите номер строки: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер столбца: ");
            int column = Convert.ToInt32(Console.ReadLine());

            int value = GetValue(array, rows, column);


            if (value != -1)
            {
                Console.WriteLine($"Значение элемента: {value}");
            }

            else
            {
                Console.WriteLine("Такого элемента нет");
            }

        }
        static int[,] GenerateArray(int rows, int column)

        {
            Random random = new Random();
            int[,] array = new int[rows, column];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }
            return array;
        }
        static void PrintArray(int[,] array)

        {
            int rows = array.GetLength(0);
            int column = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int GetValue(int[,] array, int one, int two)

        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

             if (row >= 0 && row < rows && column >= 0 && column < columns)

            {
                return array[one, two];
            }


            else
            {
                return -1;
            }
        }
    }


               








            

            

           
















            













           


            

        


            

            



            



            

            


            

            


        

        


            


        

        


        

        
