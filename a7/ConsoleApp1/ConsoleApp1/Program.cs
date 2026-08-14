using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "7-16-30-38-49-52-63-70";
            //string result = ""; // 最终获取到的情报
            //string[] a = salt.Split('-');
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int b = int.Parse(a[i]);
            //    result += text[b];
            //}
            //Console.WriteLine(result);



            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "7-16-30-38-49-52-63-70";
            //string result = ""; // 最终获取到的情报
            //var a = salt.Split('-');
            //for (int i = 0; i < a.Length; i++)
            //{
            //   int b=int.Parse(a[i]);
            //    result += text[b];

            //}
            //Console.WriteLine(result);




            //通过情报内容获取到下标：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> list = new List<int>();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < salt.Length; j++)
            //    {
            //        if (text[i] == salt[j]) list.Add(i);
            //    }

            //}
            //string result = string.Join("-", list);
            ////foreach (int s in list)
            //Console.WriteLine(result);


            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> list = [];
            //for (int i = 0; i <salt.Length; i++)
            //{
            //    int a=text.IndexOf(salt[i]);
            //    list.Add(a);

            //}var b = string.Join('-',list);
            //Console.WriteLine(b);






            //为了更安全，生成密文的时候可以调整下标：（上一个字符）：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> list = new List<int>();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < salt.Length; j++)
            //    {
            //        if (text[i] == salt[j]) list.Add(i-1);
            //    }

            //}
            //string result = string.Join("-", list);
            ////foreach (int s in list)
            //Console.WriteLine(result);

            //通过密文获获取情报的时候，需要在原本的下标基础上 + 1：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "6-15-29-37-48-51-62-69";
            //string result = ""; // 最终获取到的情报
            //var a = salt.Split('-');
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int b=int.Parse(a[i])+1;
            //    result += text[b];

            //}
            //Console.WriteLine(result);



            //还可以在生成密文的时候，奇数就 - 1，偶数就 + 1：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> list = new List<int>();

            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int a = text.IndexOf(salt[i]);
            //    if (a % 2 == 0) list.Add(a + 1);
            //    if (a % 2 != 0) list.Add(a - 1);

            //}
            //
            //var r = string.Join('-', list);
            //Console.WriteLine(r);

            //此时找到情报的时候，也要判断下标是奇数还是偶数，奇数就 - 1，偶数就 + 1：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "6-17-31-39-48-53-62-71";
            //List<int> list = new List<int>();
            //var a=salt.Split('-');
            //var result = "";
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int b = int.Parse(a[i]);
            //    if (b % 2 == 0) result += text[b+1];
            //    if (b % 2 != 0) result += text[b-1];


            //}
            //Console.WriteLine(result);



            int money = 1000647;
            string str = money.ToString();
            string result = "";
            string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            for (int i = str.Length - 1; i >= 0; i--)
            {

                int idx = int.Parse(str[i].ToString());
                int index = str.Length - 1 - i;
                if (idx != 0 || units[index] == "萬")
                {
                    result = arr[idx] + units[index] + result;
                }
                else
                {
                    result = arr[idx] + result;
                }

            }

            result = Regex.Replace(result, @"零+萬", "萬");
            result = Regex.Replace(result, @"零+", "零");
            if (result.EndsWith("零"))
            {
                result = result.Substring(0, result.Length - 1);
            }
            Console.WriteLine(result);



            //List<Dictionary<string, dynamic>> singerList = new()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1001},
            //        {"singerName", "周杰伦"},
            //        {"genre", "流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1002},
            //        {"singerName", "林俊杰"},
            //        {"genre", "华语流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1003},
            //        {"singerName", "邓紫棋"},
            //        {"genre", "流行、摇滚"}
            //    }
            //};

            //// 配置序列化
            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true,// JSON序列化时候美化
            //    AllowTrailingCommas = true, // JSON反序列化时候允许 最后出现逗号
            //};

            //string json = JsonSerializer.Serialize(singerList, options);
            ////Console.WriteLine(json);

            //// json反序列化 ===> 将json字符串转换为原始类型数据
            //var res = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            ////Console.WriteLine(res);
            ////foreach (var item in res) Console.WriteLine($"{item["singerName"]}");


            // 反序列化的应用：
            // 将unicode编码汉字转成中文汉字
            //string source = "\\u6C11\\u8C23\\u6D41\\u884C";
            //string s = $"\"{source}\"";  
            //var r1 = JsonSerializer.Deserialize<string>(s);
            //Console.WriteLine(r1);  




























            //string money = "1000000";
            //string str = money.ToString();
            //// 0    1    2   3   4  。。。
            //// 零   壹   贰  叁  肆
            //// 对应关系：数字当作下标，从下面的集合中用下标获取汉字
            //// 创建汉字数组
            //string[] arr = new string[] {
            //    "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"
            //};
            //            // 创建单位数组
            //            string[] units = new string[] {
            //    "", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"
            //};
            //            string result = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    int idx = int.Parse(str[i].ToString());
            //    // 找单位的下标
            //    int index = str.Length - 1 - i;
            //    // 获取单位
            //    string unit = units[index];
            //    if (idx != 0)
            //    {
            //        result = arr[idx] + unit + result;
            //    }
            //    else
            //    {
            //        if (str.Length - 5 == i)
            //        {
            //            result = arr[idx] + units[4] + result;
            //        }
            //        else
            //        {
            //            result = arr[idx] + result;
            //        }
            //    }
            //}

            //Console.WriteLine(result);


        }
    }
}
