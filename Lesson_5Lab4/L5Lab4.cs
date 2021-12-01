using System;

namespace Lesson_5Lab4{
    
    public class L5Lab4{

        static void Main(string[] args){
            int min = int.MaxValue;
            int max = int.MinValue;
            
            MinmaxSeq(ref min, ref max);
            Console.WriteLine("минимальное: " + min + ", максимальное: " + max);
        }

        static void MinmaxSeq(ref int min, ref int max){
            Console.Write("Введите полседовательность и закончите ввод нулем: ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), i => int.Parse(i));

            for(int i = 0; i < numbers.Length; i++){
                int num = numbers[i];
                if(num != 0){
                    if(num < min){
                        min = num;
                    }

                    if(num > max){
                        max = num;
                    }
                }
            }
        }
    }
}
