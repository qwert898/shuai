namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string,dynamic> a= new Dictionary<string,dynamic>()
            //{
            //    ["name"]="帅",
            //    ["age"]="18",
            //    ["job"]="人"

            //};
            //a.Add("gender", "nan");
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            //a.Remove("name");
            //foreach(dynamic d in a)
            //{
            //    Console.WriteLine(d);
            //}
            //a.Clear();
            //Console.WriteLine(a.Count);
            //Console.WriteLine(a.ContainsKey("name"));
            //Console.WriteLine(a.ContainsValue("人"));
            //Console.WriteLine(a.ContainsKey("ad"));
            //Console.WriteLine(a.ContainsValue("313"));

            //var b = a.Values;
            //List<string> c = b.ToList();
            //foreach (string s in c)
            //{
            //    Console.WriteLine(s);

            //}

            //var b = a.Values;
            //List<string>  c = b.ToList();
            //foreach (string s in c)
            //{
            //    Console.WriteLine(s);
            //}

            //var dicValues = a.Values;
            //// 获取所有字典中 键值 的集合
            ////dynamic[] valArr = dicValues.ToArray(); // 将键值集合转为数组
            ////foreach (dynamic val in valArr) Console.WriteLine(val);

            //List<dynamic> vallist = dicValues.ToList(); // 将键值集合转为list集合
            //foreach (dynamic val in vallist) Console.WriteLine(val);

            //思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，最终在字典中的键都是唯一的，将所有键放在一个新的List中
            //List<int> a = [1,2,3,3,4,5,6,6,7,7,8,9];
            //Dictionary<int, dynamic> c = new();
            //foreach(int  i in b)
            //{
            //    c[i] = "123";

            //}
            //List<int> d=c.Keys.ToList();
            //foreach(int x in d) Console.WriteLine(x);

            //Dictionary<int, dynamic> b = new();
            //foreach (int i in a)
            //{
            //    b[i] = "133";

            //}
            //List<int> c=b.Keys.ToList();
            //foreach (int x in c) Console.WriteLine(x);


            //让每相邻的两个元素比较大小，如果不满足顺序，就交换他俩的位置。
            //List<int> a = [3, 4, 7, 9, 1, 2, 5, 6, 8];
            //int b;
            //for (int i = 0; i < a.Count - 1; i++)
            //{
            //    for (int j = 0; j < a.Count - 1 - i; j++)
            //    {
            //        if (a[j] < a[j + 1])
            //        {
            //            b = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = b;
            //        }

            //    }
            //}
            //foreach (int i in a) Console.WriteLine(i);

            //List<int> a = [3, 4, 7, 9, 1, 2, 5, 6, 8];
            //int b;
            //for (int i = a.Count-1; i >=0; i--)
            //{
            //    for (int j = a.Count - 1-i; j >=0; j--)
            //    {
            //        if (a[j] > a[j + 1])
            //        {
            //            b = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = b;
            //        }

            //    }
            //}
            //foreach (int i in a) Console.WriteLine(i);


            //Console.WriteLine("请输入排序类型：");
            //string type = Console.ReadLine();
            //Console.WriteLine("请输入排序顺序:");
            //string shun = Console.ReadLine();
            //List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "机械键盘"},
            //        {"price", 299.99},
            //        {"code", "G001"},
            //        {"stock", 120}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "无线鼠标"},
            //        {"price", 89.50},
            //        {"code", "G002"},
            //        {"stock", 356}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "27寸显示器"},
            //        {"price", 1299.00},
            //        {"code", "G003"},
            //        {"stock", 48}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电竞耳机"},
            //        {"price", 199.00},
            //        {"code", "G004"},
            //        {"stock", 85}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电脑支架"},
            //        {"price", 69.90},
            //        {"code", "G005"},
            //        {"stock", 210}
            //    }
            //};

            //dynamic b;
            //if (type == "price")
            //{
            //    if (shun == "ASC")
            //    {
            //        for (int i = 0; i < goodsList.Count - 1; i++)
            //        {
            //            for (int j = 0; j < goodsList.Count - 1 - i; j++)
            //            {


            //                if (goodsList[j]["price"] > goodsList[j + 1]["price"])
            //                {

            //                    b = goodsList[j];
            //                    goodsList[j] = goodsList[j + 1];
            //                    goodsList[j + 1] = b;
            //                }

            //            }
            //        }
            //        foreach (dynamic M in goodsList) Console.WriteLine($"{M["name"]}--{M["price"]}");
            //    }


            //    if (shun == "DSC")
            //    {
            //        for (int i = 0; i < goodsList.Count - 1; i++)
            //        {
            //            for (int j = 0; j < goodsList.Count - 1 - i; j++)
            //            {


            //                if (goodsList[j]["price"] < goodsList[j + 1]["price"])
            //                {

            //                    b = goodsList[j];
            //                    goodsList[j] = goodsList[j + 1];
            //                    goodsList[j + 1] = b;
            //                }

            //            }
            //        }
            //        foreach (dynamic M in goodsList) Console.WriteLine($"{M["name"]}--{M["price"]}");
            //    }
            //}
            //if (type == "stock")
            //{
            //    if (shun == "ASC")
            //    {
            //        for (int i = 0; i < goodsList.Count - 1; i++)
            //        {
            //            for (int j = 0; j < goodsList.Count - 1 - i; j++)
            //            {

            //                if (goodsList[j]["stock"] > goodsList[j + 1]["stock"])
            //                {
            //                    b = goodsList[j ];
            //                    goodsList[j] = goodsList[j + 1];
            //                    goodsList[j + 1] = b;
            //                }

            //            }


            //        }
            //        foreach (dynamic M in goodsList) Console.WriteLine($"{M["name"]}--{M["stock"]}");
            //    }


            //    if (shun == "DSC")
            //    {

            //        for (int i = 0; i < goodsList.Count - 1; i++)
            //        {
            //            for (int j = 0; j < goodsList.Count - 1 - i; j++)
            //            {

            //                if (goodsList[j]["stock"] < goodsList[j + 1]["stock"])
            //                {
            //                    b = goodsList[j ];
            //                    goodsList[j] = goodsList[j + 1];
            //                    goodsList[j + 1] = b;
            //                }

            //            }


            //        }
            //        foreach (dynamic M in goodsList) Console.WriteLine($"{M["name"]}--{M["stock"]}");


            //    }
            //}


            //通过歌曲查找歌手

            List<Dictionary<string, dynamic>> singerList = new()
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

            List<Dictionary<string, dynamic>> songList = new()
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };
            // 用户输入歌手姓名：周杰伦/林俊杰 ==> 通过这个姓名将这个人唱的所有歌曲都找出来
            Console.WriteLine("请输入歌曲名字：");
            string song = Console.ReadLine(); 
            int singerId = 0; 
            foreach (Dictionary<string, dynamic> item in songList)
            {
               
                if (item["songName"] == song) singerId = item["singerId"];
            }

            var singerSongs = new List<Dictionary<string, dynamic>>();
            foreach (Dictionary<string, dynamic> item in singerList)
            {
                if (item["singerId"] == singerId) singerSongs.Add(item);
            }
            foreach (dynamic item in singerSongs)
            {
                Console.WriteLine(item["singerName"]);
            }





            //List<Dictionary<string, dynamic>> singer = new List<Dictionary<string, dynamic>>()
            //{
            //    new Dictionary<string, dynamic>()
            //    {
            //        ["name"]="周杰伦",
            //        ["song"]="晴天",
            //        ["song"]="告白气球"

            //    },
            //       new Dictionary<string, dynamic>()
            //    {
            //        ["name"]="邓紫棋",
            //        ["song"]="再见",
            //        ["song"]="光年之外"

            //    },
            //       new Dictionary<string, dynamic>()
            //       {
            //        ["name"]="薛之谦",
            //        ["song"]="丑八怪",
            //        ["song"]="意外"
            //       }

            //};
            ////List<Dictionary<string, dynamic>> singer2 = new List<Dictionary<string, dynamic>>()
            ////{
            ////};
            //Console.WriteLine("请输入歌曲名字");
            //string a=Console.ReadLine();

            //if (singer["song"].Contains(a))
            //{
            //    Console.WriteLine(
            //}























































        }
    }
} 
