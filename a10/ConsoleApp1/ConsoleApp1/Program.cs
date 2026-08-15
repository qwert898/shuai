using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //书写函数 实现写入日志操作, 日志内容: 输入内容 + 日期
            //var Writelog = () =>
            //{  
            //    var res = DateTime.Now;
            //    var n = @"D:\Desktop\a10\log.text";
            //    File.AppendAllText(n,"time"+res);

            //    //File.WriteAllText(n, res);
            //    //Console.WriteLine(res);
            //};
            //Writelog();

            //bool res = Directory.Exists("data");
            //Console.WriteLine(res);

            //Func<string, int> isFileorDir = path =>
            //{
            //    if (File.Exists(path)) return 1;
            //    if (Directory.Exists(path)) return 2;
            //    return 0;
            //};
            //string[] resArr = ["啥也不是", "是文件", "是文件夹"];
            ////int res = isFileorDir("./log.txt");
            //int res = isFileorDir(@"D:\Desktop\a10\ConsoleApp1\ConsoleApp1\bin\Debug");

            //Console.WriteLine(resArr[res]);

            //Func<string, Dictionary<string, string[]>> getFileAndDir = path =>
            //{
            //    var resDic = new Dictionary<string, string[]>();
            //    if (isFileOrDir(path) != 2) throw new Exception("传递的参数有误,必须要是目录路径");
            //    // 获取目录下的所有文件
            //    string[] files = Directory.GetFiles(path);
            //    resDic["files"] = files;

            //    // 获取所有的目录
            //    string[] dirs = Directory.GetDirectories(path);
            //    resDic["dirs"] = dirs;
            //    return resDic;
            //};

            //var res = getFileAndDir("./");
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item.Value) Console.WriteLine(item2);
            //    Console.WriteLine("-----------------------");
            //}


            List<Dictionary<string, dynamic>> list = new()
            {
                    new Dictionary<string, dynamic>(){
                        ["name"] = "zs",
                        ["age"] = 29,
                        ["isMan"] = true,
                        ["isSingle"] = true,
                        ["salary"] = 4200
                    },
                    new Dictionary<string, dynamic>(){
                        ["name"] = "ls",
                        ["age"] = 20,
                        ["isMan"] = false,
                        ["isSingle"] = true,
                        ["salary"] = 3400
                    },
                    new Dictionary<string, dynamic>(){
                        ["name"] = "ww",
                        ["age"] = 19,
                        ["isMan"] = true,
                        ["isSingle"] = false,
                        ["salary"] = 6000
                    },
                    new Dictionary<string, dynamic>(){
                        ["name"] = "zl",
                        ["age"] = 14,
                        ["isMan"] = false,
                        ["isSingle"] = true,
                        ["salary"] = 2000
                    },
                    new Dictionary<string, dynamic>(){
                        ["name"] = "sq",
                        ["age"] = 35,
                        ["isMan"] = true,
                        ["isSingle"] = false,
                        ["salary"] = 7000
                    },
                    new Dictionary<string, dynamic>(){
                        ["name"] = "zb",
                        ["age"] = 27,
                        ["isMan"] = false,
                        ["isSingle"] = true,
                        ["salary"] = 2900
                    },
                };

            //var res = list.Where(item => item["isSingle"]);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item["name"]}");
            //}


            //var res = list.Where(item => item["isSingle"]);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"name={item["name"]}--age={item["age"]}--salary={item["salary"]}--isSingle={item["isSingle"]}");
            //}

            //var res1 = list.Select(item =>
            //{
            //    return new Dictionary<string, dynamic>()
            //    {
            //        ["name"] = item["name"],
            //        ["age"] = item["age"],
            //    };

            //});
            //foreach (var item in res1) Console.WriteLine($"{item["name"]}");

            //var res2 = list.Where(item => item["age"]>30).Select(item =>
            //{
            //    return new Dictionary<string, dynamic>()
            //    {
            //        ["name"] = item["name"],
            //        ["age"] = item["age"],
            //    };

            //});
            //foreach (var item in res2) Console.WriteLine($"{item["name"]}");

            //var res = list.OrderBy(item => item["age"]);
            //foreach(dynamic item in res) Console.WriteLine($"{item["age"]}");

            //var res = list.OrderByDescending(item => item["age"]);
            //foreach (dynamic item in res) Console.WriteLine($"{item["age"]}");


            //var res = list.DistinctBy(item => item["age"]);
            //foreach (dynamic item in res) Console.WriteLine($"{item["age"]}");



            //        List<Dictionary<string, dynamic>> arr = new() {
            //            new Dictionary<string, dynamic>(){
            //                ["name"] = "手机",
            //                ["type"] = "电子产品"
            //            },
            //            new Dictionary<string, dynamic>(){
            //                ["name"] = "香蕉",
            //        //        ["type"] = "水果"
            //        //    },
            //        //    new Dictionary<string, dynamic>(){
            //        //        ["name"] = "苹果",
            //        //        ["type"] = "水果"
            //        //    },
            //        //    new Dictionary<string, dynamic>(){
            //        //        ["name"] = "平板",
            //        //        ["type"] = "电子产品"
            //        //    },
            //        //    new Dictionary<string, dynamic>(){
            //        //        ["name"] = "耳机",
            //        //        ["type"] = "电子产品"
            //        //    },
            //        //    new Dictionary<string, dynamic>(){
            //        //        ["name"] = "水蜜桃",
            //        //        ["type"] = "水果"
            //        //    },
            //        //};
            //        //var res = arr.GroupBy(item => item["type"]);
            //        //// 结果是第一个字典, 水果一组,电子产品一组                        
            //        //foreach (var item in res)
            //        //{
            //        //    Console.WriteLine(item.Key);
            //        //    foreach (var i in item) Console.WriteLine($"{i["type"]}--{i["name"]}");
            //        //}



            //   作业: 使用读写文件配合命令行窗口 模拟实现注册功能

            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)

            //Console.WriteLine("请输入用户名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();
            //if (password.Length >= 8 && password.Length <= 15) Console.WriteLine($"注册成功");
            //else Console.WriteLine($"请重新注册：");
            //var s = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //    Console.WriteLine(s);
            //File.AppendAllText("user.txt", $"{s}===userName:{userName}===password:{password}\n");


            // 扩展练习: 使用读写文件配合命令行窗口 模拟实现注册登录功能

            //进入就是菜单栏界面, 1注册,2登录,0退出
            Console.WriteLine("请点击您要的服务：1注册，2登录，0退出");
            int service = int.Parse(Console.ReadLine());

            //输入1 进入注册, 要求输入用户名,密码, 用户输入用户名和密码 则实现注册功能, 要求校验用户名和密码
            if (service == 1)
            {
                Console.WriteLine("请输入用户名：");
                string userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string password = Console.ReadLine();
                var datetime = DateTime.Now;
                var s = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                Console.WriteLine(s);
                if (password.Length >= 8 && password.Length <= 15 && userName.Length > 3)
                {
                    Console.WriteLine($"注册成功");
                    File.AppendAllText("user.json", $"{datetime}===={s}===userName:{userName}===password:{password}\n");
                }
                else Console.WriteLine($"请重新注册：");
                File.AppendAllText("user.log", $"{datetime}==={s}===userName:{userName}===password:{password}\n");
            }
            //输入2 进入登录, 要求输入用户名, 密码, 输入后完成登录校验功能; 登录成功提示 登录成功

            //输入0 退出程序,

            //-用户注册成功的用户信息 以文件的形式存储在user.json中(要求以json形式存储)
            //  - [{ username: "",password: "",datetime: "时间戳"}]
            //  -用户操作日志user.log: 用户每次操作都要有日志记录, 记录操作,用户名,操作方式,时间,如果有异常的,记录异常

        }
    }
}
