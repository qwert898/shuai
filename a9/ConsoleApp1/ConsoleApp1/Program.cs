using System.Text.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        //delegate void De(string msg);
        static void Main(string[] args)
        {

            //void sayhello(string name)
            //{
            //    Console.WriteLine($"hello,{name}");
            //}
            //void saybye(string name)
            //{
            //    Console.WriteLine($"Bye,{name}");

            //}
            //De del = sayhello;
            //del("tom");
            //De d = saybye;
            //d("jessica");

            //void d(string name)
            //{
            //    Console.WriteLine($"hello,{name}");
            //}
            //void b(string name)
            //{
            //    Console.WriteLine($"bye,{name}");

            //}
            //Action<string> a = d;

            //a += b;
            //b("jessica");

            //int a = 3;
            //int b = a;
            //b = 200;
            //Console.WriteLine(a);

            //var getsum = (params int[] args) =>
            //{
            //    int sum = 0;
            //    foreach (int item in args)
            //    {
            //        sum += item;
            //    }
            //    return sum;
            //}; Console.WriteLine(getsum(1));
            //Console.WriteLine(getsum(1,6,3,5));

            //var fn = (int n1, int n2, params int[] args) =>
            //    {
            //        foreach (var arg in args) Console.Write(arg);
            //        Console.WriteLine();
            //    };
            ////fn(10, 20);
            //fn(10, 20, 30);
            //fn(10, 20, 30, 40);

            //void a(ref int x)
            //{
            //    x = x * 2;
            //}
            //int num = 5;
            //a(ref num);
            //Console.WriteLine(num);

            //void a(ref List<int> list)
            //{
            //    list.Add(888);
            //    list= new List<int>();
            //    list.Add(999);
            //}
            //var mylist = new List<int> { 1, 2, 3 };
            //a(ref mylist);
            //Console.WriteLine(string.Join("-", mylist));

            //void agename(out string name,out int age)
            //{
            //    name = "小明";
            //    age = 18;

            //}
            //string n;
            //int a;
            //agename(out n,out a);
            //Console.WriteLine($"{n}的年龄是{a}");

            //var a=(1,1,3,4);
            //Console.WriteLine(a.Item1);

            //var person = (id: 101, name: "李逵", age: 33);
            //Console.WriteLine(person.id);
            //Console.WriteLine(person.name);
            //Console.WriteLine(person.age);

            //(int id, string name) product = (205, "apple");
            //Console.WriteLine(product.name);

            //(int age,string gender,bool isadult)qqq()
            //{
            //    Console.WriteLine("请输入年龄:");
            //    int age=int.Parse(Console.ReadLine());
            //    Console.WriteLine("请输入性别:");
            //    string gender=Console.ReadLine();
            //    bool isadult = age >= 18;
            //    return (age, gender, isadult);
            //}
            //var (age, gender, isadult) = qqq();
            //Console.WriteLine($"{age},{gender},{isadult}");


            //void a(string msg, int age)
            //{
            //    Console.WriteLine($"{msg},{age}");
            //}
            //a("name", 16);


            //Action a = () => Console.WriteLine($"人才");
            //var b = (Action f) =>
            //{
            //    Console.WriteLine($"dak");
            //    f();
            //};
            //b(a);


            //List<int> list = [100, 200, 300, 400, 200, 500, 300];
            //var res = list.Exists(item =>
            //{
            //    Console.WriteLine("find");
            //    return item>200;
            //});
            ////Console.WriteLine(JsonSerializer.Serialize(res));
            //Console.WriteLine(res);


            //List<int> list1 = [100, 200, 300, 400, 500, 300];
            //Action<int> fn = n => Console.WriteLine(n);
            //list1.ForEach(fn);
            //Console.WriteLine(fn);
            //list1.ForEach(n => Console.WriteLine(n));


            //List<Dictionary<string, dynamic>> list = new() {
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zs",
            //        ["age"] = 29,
            //        ["isMan"] = true,
            //        ["isSingle"] = true,
            //        ["salary"] = 4200
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "ls",
            //        ["age"] = 20,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 3400
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "ww",
            //        ["age"] = 19,
            //        ["isMan"] = true,
            //        ["isSingle"] = false,
            //        ["salary"] = 6000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zl",
            //        ["age"] = 14,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 2000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "sq",
            //        ["age"] = 35,
            //        ["isMan"] = true,
            //        ["isSingle"] = false,
            //        ["salary"] = 7000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zb",
            //        ["age"] = 27,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 2900
            //    },
            //};
            //List<Dictionary<string, dynamic>> qqq = new();
            //foreach (var a in list)
            //{
            //    if (a["age"] < 20) qqq.Add(a);
            //}
            //Console.WriteLine(JsonSerializer.Serialize(qqq));
            //var res = qqq.Find(item =>
            //{
            //    return item["age"] < 20;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));

            //var res = list.Find(item =>
            //{
            //    return item["age"] < 20;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));


            //var res = list.FindLast(item =>
            //{
            //    return item["age"] > 25;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));


            //var res = list.FindAll(item =>
            //{
            //    return item["isMan"];
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));

            //var res = list.FindIndex(item =>
            //{
            //    return item["salary"] > 5000;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));

            //var res = list.FindLastIndex(item =>
            //{
            //    return item["salary"] < 3000;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));

            //var res = list.Exists(item =>
            //{
            //    return item["salary"] > 5000;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));

            //list.ForEach((item) => Console.WriteLine($"{item["name"]}--{item["age"]}"));


            //list.Foreach(n =>
            //{
            //    Console.WriteLine($"{n["name]}");
            //})

            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true,// JSON序列化时候美化
            //    AllowTrailingCommas = true, // JSON反序列化时候允许 最后出现逗号
            //};

            //string json = JsonSerializer.Serialize(list, options);
            //Console.WriteLine(json);





            //var res = list.ConvertAll(item =>
            //{
            //    return item["salary"];
            //    //Console.WriteLine($"{item["salary"]");
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));


            //var res = list.TrueForAll(item =>
            //{
            //    return item["age"]>18;
            //});
            //Console.WriteLine(JsonSerializer.Serialize(res));


            //封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            //var fn = () =>
            //{
            //    Console.WriteLine("请输入一个字符串：");
            //    string str = Console.ReadLine();
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
            //        //Console.WriteLine($"{resStr}--{count}");
            //    }
            //    List<Dictionary<string, dynamic>> list = new() {
            //        new Dictionary<string, dynamic>(){
            //            ["resStr"] = "zs",

            //        },
            //        };
            //};
            //fn();

            //封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数

            Func<string, Dictionary<char, int>> getCount = str =>
            {
                Dictionary<char, int> a1 = new();
                int i = 0;
                for (; i < str.Length; i++)
                {
                    if (a1.ContainsKey(str[i]))
                    {
                        //a1.Add(str[i], i);
                        a1[str[i]]++;
                    }
                    else a1[str[i]]=1;
                   
                }
                return a1;

            };
            var res = getCount("aaaaadadfgrgzxceewrtgdafswadq");
            foreach(var item in res) Console.WriteLine($"{item.Key}---{item.Value}");





        }
    }
}
