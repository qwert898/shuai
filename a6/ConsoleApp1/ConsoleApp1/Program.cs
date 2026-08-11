using System.Text.RegularExpressions;
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace：将字符串中指定的子串都替换成的新的子串
            //string str = "abacdaeafeeg";
            ////Console.WriteLine(str.Replace("a","0"));
            //Console.WriteLine(str.Replace("ee","**"));

            // 敏感词替换为 * , 而且个数要保持一致
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];


            // 生活总会有**烦, 黑***过去



            //string a = "you love i";
            //string[] b = a.Split();
            //List<string> list = new List<string>();
            //string s3 = "";
            //foreach (var i in b)
            //{
            //    list.Add(i); //Console.WriteLine(i);
            //}
            ////Console.WriteLine(list);
            //list.Reverse();
            //foreach (var s in list)
            //{
            //    string s1=s.Substring(0,1).ToUpper();
            //    string s2=s.Substring(1).ToLower();
            //     s3 += s1 + s2+" ";

            //}
            //Console.WriteLine(s3);

            //string a = "真是个神人，你说是吧，兄弟";
            //List<string> b = ["神人", "兄弟"];
            //foreach (dynamic s in b)
            //{
            //    string c = "".PadRight(s.Length, '*');
            //    a = a.Replace(s, c);

            //}
            //Console.WriteLine(a);


            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];

            //foreach (string str1 in mgc)
            //{
            //    string newStr = "".PadRight(str1.Length, '*');
            //    str = str.Replace(str1, newStr);
            //}
            //Console.WriteLine(str);


            //string reg = @"a";
            //bool res = Regex.IsMatch("bac", reg);
            //Console.WriteLine(res);

            //string reg = @"a";
            //string str = "bac";
            //Match res= Regex.Match(str, reg);
            //Console.WriteLine(res.Value);

            //string reg = @"a";
            //string res = Regex.Replace("bac", reg, "e");
            //Console.WriteLine(res);

            //string reg = @"\w";
            //bool res = Regex.IsMatch("314", reg);
            //Console.WriteLine(res);

            //string reg = @"";
            //string str = "bacbbbd";
            ////Match res = Regex.Match(str, reg);
            ////Console.WriteLine(res.Value);
            //bool res = Regex.IsMatch(str, reg);
            //Console.WriteLine(res);

            //string a = "abfdsfefsbrgh";
            //string b = "";
            //for(int i=0;i<a.Length; i++)
            //{
            //    if (!b.Contains(a[i])) b += a[i];

            //}
            //foreach(dynamic s in b) Console.WriteLine(s);



            //string reg = @"[\u4e00-\u9fa5]+";
            //string str = "hello, I am 刘德华,your name is 黎明?";
            //MatchCollection res = Regex.Matches(str, reg);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);

            //-替换所有多余空格
            //string reg = @"\w+";
            //string str = "abc  dd  ee  ff  gg  HH  h j k";
            //MatchCollection res = Regex.Matches(str, reg);
            //string a = "";
            // for(int b=0; b<res.Count; b++)
            //{
            //    a=a+res[b];
            //}
            //Console.WriteLine(a);

            //身份证号码
            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //// 书写正则, 找到字符串中的身份证号及 出生年,月,日
            //string reg = @"[1-40]\d{0,}";
            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //MatchCollection res = Regex.Matches(str, reg);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1] + "X");
            //string a = "res[0],res[1]";
            //string r1 = str.Substring(15, 8);
            //string r2 = str.Substring(42, 8);
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);



            //string str = "我的身份证号是：360731200111052112，你的身份证是：42108320041119211X";
            //string reg = @"\d{6}(\d{8})\d{3}[\dXx]";
            //MatchCollection res = Regex.Matches(str, reg);

            //foreach (Match item in res)
            //{
            //    Console.WriteLine("完整身份证：" + item.Value);
            //    string birthday = item.Groups[1].Value;
            //    string year = birthday.Substring(0, 4);
            //    string month = birthday.Substring(4, 2);
            //    string day = birthday.Substring(6, 2);
            //    Console.WriteLine($"出生：{year}年{month}月{day}日");
            //}

            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //// 书写正则, 找到字符串中的身份证号及 出生年,月,日
            //var reg = @"[1-9]\d{5}(\d{4})(\d{2})(\d{2})\d{3}[0-9Xx]";
            //var res = Regex.Matches(str, reg);
            ////res[0].Groups
            ////Console.WriteLine(res[0].GetType());
            //foreach (Match item in res)
            //{
            //    Console.WriteLine($"{item} -- {item.Groups[1]} -- {item.Groups[2]} -- {item.Groups[3]}");
            //}

            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            ////书写正则, 找到字符串中的身份证号及 出生年,月, 日
            //var reg = @"[1-9]\d{5}(\d{4})(\d{2})(\d{2})\d{3}[0-9xX]";
            //var res = Regex.Matches(str, reg);
            //foreach (Match r in res)
            //{

            //    Console.WriteLine($"{r.Groups[0]}\t{r.Groups[1]}-{r.Groups[2]}-{r.Groups[3]}");

            //}

            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //var reg = @"[1-9]\d{5}(\d{4})(\d{2})(\d{2})\d{3}[0-9xX]";
            //var a = Regex.Matches(str, reg);
            //foreach (Match c in a)
            //{
            //    Console.WriteLine($"{c.Groups[0]} - {c.Groups[1]} - {c.Groups[2]} - {c.Groups[3]}");
            //}




            //密码强度检测：强中弱（字母、数字、特殊符号）
            // 请输入密码（字母、数字、特殊符号）

            //密码中可以有数字,字母,特殊符号;长度要求8~15 
            //如果只有一种则 强度为弱
            //如果只有两种则 强度为中
            //如果两种都有则 强度为强

            //验证密码长度是否符合,并输出密码强度


            Console.WriteLine("请输入密码：");
            string mima = Console.ReadLine();
            var reg1 = @"\d+";
            var reg2 = @"[a-zA-Z]";
            var reg3 = @"[^a-zA-Z0-9]";
            int count = 0;
            if (mima.Length > 8 && mima.Length < 15)
            {
                bool a1 = Regex.IsMatch(mima, reg1);
                bool a2 = Regex.IsMatch(mima, reg2);
                bool a3 = Regex.IsMatch(mima, reg3);
                if (a1) count++;
                if (a2) count++;
                if (a3) count++;
                if (count == 1) Console.WriteLine(@"弱");
                if (count == 2) Console.WriteLine(@"中");
                if (count == 3) Console.WriteLine(@"强");
            }
            else Console.WriteLine(@"密码设定错误");












        }
    }
}
