using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            
            Console.WriteLine("Введите первое слагаемое");
            int addend1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое");
            int addend2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат равен  {addend1+addend2}");

        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Введите первое слагаемое");
            int addend1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое");
            int addend2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите результат");
            int result = Convert.ToInt32(Console.ReadLine());
            if (addend1 + addend2 == result)
                Console.WriteLine("верно");
            else
                Console.WriteLine("неверно");

        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Введите первое слагаемое");
            int addend1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое");
            int addend2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите результат");
            int result = Convert.ToInt32(Console.ReadLine());
            if (addend1 + addend2 == result)
                Console.WriteLine("верно");
            else
            {
                Console.WriteLine("неверно");
                if (addend1+addend2>result)
                    Console.WriteLine("Введенный вариант меньше правильного ответа");
                else
                    Console.WriteLine("Введенный вариант больше правильного ответа");
            }
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Введите первое число");
            int addend1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите + или - ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int addend2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш ответ");
            int result = Convert.ToInt32(Console.ReadLine());
            int trueResult;
            if (oper.Equals('+'))            
                trueResult = addend1 + addend2;            
            else if (oper.Equals('-'))            
                trueResult = addend1 - addend2;            
            else
            {
               Console.WriteLine("Неподдерживаемый оператор ((");
               return;
            }                                 
            if (trueResult == result)
                Console.WriteLine("верно");
            else
            {
                Console.WriteLine("неверно");
                if (trueResult > result)
                    Console.WriteLine("Введенный вариант меньше правильного ответа");
                else
                    Console.WriteLine("Введенный вариант больше правильного ответа");
            }
        }

        // <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
          Console.WriteLine("Введите первое число");
            int addend1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите + или - ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int addend2 = Convert.ToInt32(Console.ReadLine());
           
            int trueResult;
            //сунуть в цикл   for
            
            Console.WriteLine("Ваш ответ");
            int result = Convert.ToInt32(Console.ReadLine());
            if (oper.Equals('+'))            
                trueResult = addend1 + addend2;            
            else if (oper.Equals('-'))            
                trueResult = addend1 - addend2;            
            else
            {
               Console.WriteLine("Неподдерживаемый оператор ((");
               return;
            }
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"попытка № {i}");
                if (trueResult == result)
                {
                    Console.WriteLine("верно");
                    break;
                }
                else
                {
                    Console.WriteLine("неверно");
                    if (trueResult > result)
                        Console.WriteLine("Введенный вариант меньше правильного ответа");
                    else
                        Console.WriteLine("Введенный вариант больше правильного ответа");
                }
            }


        }

        /* /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {

        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {

        }    */
    }
}