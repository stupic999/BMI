using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定背景顏色為黑色 
            Console.BackgroundColor = ConsoleColor.Black;

            // 顯示“請誠實地輸入身高”
            Console.WriteLine("請誠實地輸入身高");

            // 把使用者輸入的數字代入height 
            double height = double.Parse(Console.ReadLine());

            // 顯示“請誠實地輸入體重”
            Console.WriteLine("請誠實地輸入體重");

            // 把使用者輸入的數字代入weight 
            double weight = double.Parse(Console.ReadLine());

            // 設定BMI的公式 
            double BMI = weight*10000/(height*height);

            // 如果BMI小於18.5，執行內部的指令 
            if (BMI < 18.5) 
                {
                // 顯示“體重過輕”
                Console.WriteLine("體重過輕");

                // 發出“嗶”的聲音 
                Console.Beep();

                // 設定背景顏色為紅色 
                Console.BackgroundColor = ConsoleColor.Red;  
                }

            // 如果BMI大於等於18.5，且小於24，執行內部的指令 
            else if (BMI>=18.5  && BMI < 24)
                {
                // 顯示“恭喜你，非常正常^^”
                Console.WriteLine("恭喜你，非常正常^^");

                // 設定背景顏色為綠色 
                Console.BackgroundColor = ConsoleColor.Green;
                }

            // 如果BMI大於等於24，且小於27，執行內部的指令 
            else if (BMI>=24 && BMI < 27)
                {
                // 顯示“你有點過重哦”
                Console.WriteLine("你有點過重哦");

                // 設定背景顏色為紅色 
                Console.BackgroundColor = ConsoleColor.Red;

                // 發出“嗶”的聲音
                Console.Beep();
                }

            // 如果BMI大於等於24，且小於27，執行內部的指令
            else if ( BMI>=27 && BMI < 30)
                {
                // 顯示“輕度肥胖”
                Console.WriteLine("輕度肥胖");

                // 設定背景顏色為紅色
                Console.BackgroundColor = ConsoleColor.Red;

                // 發出“嗶”的聲音
                Console.Beep();
                }
            // 如果BMI大於等於24，且小於27，執行內部的指令
            else if (BMI>=30 && BMI < 35)
                {
                // 顯示“中度肥胖”
                Console.WriteLine("中度肥胖");

                // 設定背景顏色為紅色
                Console.BackgroundColor = ConsoleColor.Red;

                // 發出“嗶”的聲音
                Console.Beep();
                }
            // 如果都不是，則執行內部的指令
            else
            {
                // 顯示“重度肥胖”
                Console.WriteLine("重度肥胖");

                // 設定背景顏色為紅色
                Console.BackgroundColor = ConsoleColor.Red;

                // 發出“嗶”的聲音
                Console.Beep();
                }
            // 顯示“你的BMI數值是(?)”,?為BMI
            Console.WriteLine("你的BMI數值是"+BMI.ToString());

            // 按任意按鈕即可退出 
            Console.ReadKey();
            }
        }
    }
