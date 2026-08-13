using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var fn = (int n) =>
            //Action fn =()=> 
            //void fn(int n)
            //{
            //    for (int i = 1; i <=n; i++)
            //    {
            //        for (int j = 1; j <=i; j++)
            //        {
            //            Console.Write($"{j}*{i}={j * i}\t");
            //        }
            //        Console.WriteLine();
            //    }


            //};
            //fn(9);
            //Console.WriteLine($"======================");
            //fn(5);


            //Action<string> fn=(n)=> 
            //{
            //    Console.WriteLine(n);

            //};
            //fn("人才");
            //fn("131");



            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0 - 100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！

            //void fn()
            //{
            //    Random shu = new Random();
            //    int a1 = shu.Next(101);     
            //    for (int i = 0; i <7; i++)
            //    {
            //      Console.WriteLine($"请输入数字：");
            //      int a = int.Parse(Console.ReadLine());

            //    if (a == a1)
            //    {
            //        Console.WriteLine($"WIN");return;
            //    }
            //    if (a<a1) Console.WriteLine($"偏小");

            //    if (a>a1) Console.WriteLine($"偏大");
            //     }  
            //     Console.WriteLine($"GAME OVER");
            //}

            //fn();

            //bool isPrime(int n)
            //{
            //    for (int i = 1; i < n; i++)
            //    {
            //        if (i == 1 || i == n)
            //            continue;

            //        if (n % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
            //Console.WriteLine(isPrime(17));

            //bool a(int n)
            //{
            //    for (int i = 1; i < n; i++)
            //    {
            //        if(i ==1||i==n)
            //        {
            //            continue;
            //        }  
            //        if(n%i==0)
            //        {
            //            return false;
            //        }

            //    }
            //    return true;
            //}
            //Console.WriteLine(a(7));


            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //var fn = () =>
            //{
            //    Console.WriteLine("请输入圆的半径");
            //    double r = double.Parse(Console.ReadLine());
            //    double s = Math.PI * r * r;
            //    double price = s * 200;
            //    Console.WriteLine(price);
            //    return price;

            //};
            //fn();


            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //var fn=()=>
            //{
            //    string str = "qwerysssssqqqqwwweee";
            //    string resStr = ""; // 去重后的字符串               
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (!resStr.Contains(str[i])) resStr += str[i];

            //    }
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        char c = resStr[j];
            //        int count = 0;
            //        for (int k = 0; k < str.Length; k++)
            //        {
            //            if (c == str[k])
            //            {
            //                count++;

            //            }
            //        }
            //        Console.WriteLine($"{c}---{count}次");

            //    }
            //};
            //fn();


            //计算一个整型数组中，最小值第一次出现的下标。
            //var shu = () =>
            //{
            //    int[] arr = [10, 20, 5, 30, 50, 6, 7];
            //    int a = 0;
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] <= arr[a])
            //        {
            //            a = i;
            //        }
            //    }
            //    Console.WriteLine(a);
            //    return a;
            //};
            //shu();


            //判断一个字符串是否为回文，返回布尔值类型。
            bool a()
            {
                string str = "abcdcba";
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - 1 - i])
                        return false;

                }
                return true;
        }

            Console.WriteLine(a());



        }
    }
}
