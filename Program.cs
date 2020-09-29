using System;

namespace P2_UsingBubbleSort
{
    class Program
    {
        static int[] numeros = new int[]{3,35,60,501,410,42,21,60,1};

        static void Cambio(int[] arr, int i, int j){
            int temp = arr[i];
            
            arr[i] = arr[j];

            arr[j] = temp;
        }

        static void BubbleSort(int[] numbers){
            for (int i = numbers.Length - 1; i > 0; i--){
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                      Cambio(numbers,j,j +1);   
                    }
                }
            }
        }

        static void PrintArray(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                System.Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args){
            System.Console.WriteLine("antes de ordenar");
            PrintArray(numeros);
            BubbleSort(numeros);
            System.Console.WriteLine("despues de ordenar");
            PrintArray(numeros);
        }

    }
}
