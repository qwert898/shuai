using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a=1 ;
            //int sum=0;

            //while(a<=10)
            //{
            //    sum = sum + a;
            //    a++;
            //}
            //Console.WriteLine(sum);

            //int b=1;
            //int sum = 0;
            //while (b<=100)
            //{
            //    sum = sum + b;
            //    b++;

            //}
            //Console.WriteLine(sum);

            //将1 - 10之间的奇数加起来
            //int c = 1;
            //int sum = 0;
            //while (c <=100)
            //{
            //    if (c % 2 != 0) sum = sum + c;
            //    c++;
            //}


            //Console.WriteLine(sum);

            //输出50以内所有能被3整除且能被5整除的数字
            //int a = 1;
            //while(a<50)
            //{
            //    if(a%3==0&&a%5==0) Console.WriteLine(a);
            //    a++;
            //}

            //1 - 5相乘a
            //int a = 1;
            //int ji = 1;
            //while(a<=5)
            //{
            //    ji = ji * a;
            //    a++;
            //}
            //Console.WriteLine(ji);

            //逢7就过的游戏中，100以内所有喊过的数字
            //int a=1;
            //while(a<=100)
            //{
            //    if (a % 7 == 0) Console.WriteLine($"{a}过");
            //    else Console.WriteLine(a);
            //    a++;
            //}

            // 求100~1000之间所有的水仙花数 (其百位、十位、个位上的数字的 3次方之和 恰好等于这个数本身)
            //int a = 100;
            //while(a<=1000)
            //{
            //    int b = a / 100;//百位
            //    int c = (a / 10) % 10;//十位
            //    int d = a % 10;//个位
            //    if(Math.Pow(b,3)+ Math.Pow(c, 3)+ Math.Pow(d, 3)==a)
            //        Console.WriteLine(a);
            //    a++;

            //}

            //输出1 - 5
            //int a = 1;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a < 5);

            ////逢7就过的游戏中，100以内所有喊过的数字
            //int a = 1;
            //do
            //{
            //    if (a % 7 == 0) Console.WriteLine($"{a}过");
            //    else Console.WriteLine(a);
            //    a++;
            //} while (a <= 100);

            //计算100以内偶数的和
            //int a = 1;
            //int b = 0;
            //do
            //{
            //    if (a % 2 == 0) b = b + a;
            //    a++;

            //} while (a <= 100);
            //Console.WriteLine(b);

            //倒着输出1 - 10

            //for(int a=10;a>1;a--)
            //{
            //    Console.WriteLine(a);

            //}

            //输出1 - 10之间的偶数
            //for (int i = 2;i<10;i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //for(int i=1;i<10;i++)
            //{
            //    if(i%2==0) Console.WriteLine(i);
            //}

            //入职薪水10K，每年涨幅5 %，50年后工资多少？
            //double i = 10;
            //for (int n = 1;n<=50; n++)
            //{
            //    i = i + i * 0.05;


            //}
            //Console.WriteLine(i);

            //遍历List
            //List<string> str = new()
            //{
            //    "1",
            //    "2",
            //    "3",
            //    "4"

            //}; 
            //for(int a=0; a<str.Count; a++)
            //{
            //    Console.WriteLine(str[a]);
            //}

            //求int型List的所有数据之和
            //List<int> a = new()
            //{
            //    1, 2, 3, 4, 5, 6,
            //};
            //int sum = 0;
            //for (int b = 0; b < a.Count;b++)
            //{

            //    sum+= a[b];

            //}
            //Console.WriteLine(sum);

            //专门遍历数组、List。
            //int[] s= {1, 2, 3, 4};
            //foreach (int i in s)
            //{

            //    Console.WriteLine(i);
            //}

            //List<string> a=new List<string>()
            //{
            //    "1",
            //    "2",
            //    "3"
            //};
            //foreach (string s in a)
            //{
            //    Console.WriteLine(s);
            //}


            //Dictionary<string,dynamic> a= new Dictionary<string,dynamic>()
            //{
            //    ["name"]="tom",
            //    ["job"] ="工作",
            //    ["age"]="20"


            //};
            //foreach (var s in a)
            //{
            //    Console.WriteLine(s);
            //}


            // 判断一个数是否是素数 (素数，就是除了1和自己本身，不能被别的数整除)
            // 素数，就是除了1和自己本身，不能被别的数整除
            //int m = 11; 
            //string s = "黑色"; 
            //for (int i = 1; i <= m; i++)
            //{

            //    if (i == 1 || i == m)
            //    {
            //        continue;
            //    }
            //    if (m % i == 0)
            //    {
            //        s = "白色";
            //    }
            //}
            //if (s == "黑色")
            //{
            //    Console.WriteLine($"{m}是素数");
            //}

            //每个人，每个人都跑5圈

            //for (int a = 1;a<=5;a++)
            //{
            //    for (int b = 1;b<=5; b++)
            //    {
            //        Console.WriteLine($"{a}人跑{b}圈");
            //    }

            //}

            //输出5行星号，每行5个
            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int b = 1; b <= 5; b++)
            //    {

            //        Console.Write($"*");
            //    }
            //    Console.WriteLine();
            //}

            //用星号输出直角三角形
            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {

            //        Console.Write($"*");
            //    }
            //    Console.WriteLine();
            //}

            //输出九九乘法表
            //for(int a=1;a<=9;a++)
            //{
            //    for(int b=1;b<=a;b++)
            //    {
            //        Console.Write($"{a}*{b}={a * b}\t");
            //    }
            //    Console.WriteLine();
            //}

            //计算100以内偶数的和
            //int sum = 0;
            //for(int a=2;a<=100;a+=2)
            //{
            //    sum=sum+a;

            //}
            //Console.WriteLine(sum);

            //显示出1000 - 2000年中所有的闰年，并以每行四个数的形式输出

            //for(int i = 1000;i<=2000;i++)
            //{
            //    if (i % 4 == 0 && i % 100 != 0||i%400==0)
            //    {
            //        for (int a = 1; a <= 4; a++)
            //        {
            //            Console.Write($"{i}\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //int count = 0;
            //for (int i = 1000; i <= 2000; i++)
            //{
            //    //完整闰年条件
            //    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
            //    {
            //        Console.Write($"{i}\t");
            //        count++;
            //        if (count % 4 == 0) //累计4个，换行
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //Console.WriteLine();

            //输出一个倒三角形
            //for(int i = 9;i>=1;i--)
            //{
            //    for(int a=1;a<=i;a++)
            //    {
            //        Console.Write($"*");
            //    }
            //    Console.WriteLine();
            //}

            //1 - 1 / 2 + 1 / 3 - 1 / 4 + ... -1 / 100
            //double sum = 0;
            //for (int n = 1; n <= 100; n++)
            //{

            //    if (n%2==0)
            //    {
            //        sum -= 1.0 / n;
            //    }else
            //    {
            //        sum+=1.0 / n;
            //    }

            //}
            //Console.WriteLine(sum);

            //求10以内所有数字的阶乘的和
            //for(int a=1;a<=10;a++)
            //{
            //    for(int b = 1; b <= a; b++)
            //    {
            //        Console.Write($"{a}*{b}={a*b}\t");
            //    }
            //    Console.WriteLine();
            //}
            //int sum = 0;
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {
            //        int c = a*b;
            //        sum=sum+c;
            //        Console.Write($"{a}*{b}={a * b}\t");

            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine(sum);

            //篮球从5米高的地方掉下来，每次弹起的高度是原来的30 %，经过几次弹起，篮球的高度小于0.1米。
            //double a = 5;
            //int b=0;
            //for (; ; )
            //{
            //    a *= 0.3;
            //    b++;
            //    if (a < 0.1) break;


            //}
            //Console.WriteLine(b);

            //double h = 5;
            //int cnt = 0;
            //for (; ; )
            //{
            //    h *= 0.3;
            //    cnt++;
            //    if (h < 0.1) break;
            //}
            //Console.WriteLine(cnt);

            //有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            //int a = 0;
            //int h = 1;
            //for(int i = 1; i < 64; i++)
            //{
            //    a += h;
            //    h *= 2;

            //}double b = a * 0.00001;
            //Console.WriteLine($"芝麻总粒数{a}");
            //Console.WriteLine($"芝麻总重量{b}");

            //int a = 0;
            //int b = 1;
            //for(int i = 1; i < 64; i++)
            //{
            //    a += b;
            //    b *= 2;

            //}
            //Console.WriteLine(a);

            //某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5 %，总额不大于5000元的时候不收服务费；假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？
            //double a = 50000;
            //int b = 0;

            //for(; ; )
            //{
            //    if (a > 5000)
            //    {
            //        a *= 0.95;
            //        b++; Console.WriteLine($"第{b}次扣费，剩余{a}元");
            //    }
            //    else break;

            //}
            //Console.WriteLine(b);

            //猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            //double a = 1.5;
            //double x = 0;
            //for (int i = 1; i < 7; i++)
            //{
            //    x += a;


            //}
            //Console.WriteLine(x + 1);

            //有个皮球，每次落地弹起都是高度的一半，如果从10米高的地方丢下，第十次弹起时，皮球总过经历了多少距离。
            //double a = 10;

            //double sum = 10;
            //for (int i = 1; i <=10; i++)
            //{
            //    a = a * 0.5;
            //    sum += a;
            //    sum += a;
            //}
            //Console.WriteLine(sum);





















        }
    }
}
