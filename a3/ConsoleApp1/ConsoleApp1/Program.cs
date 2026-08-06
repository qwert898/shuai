using System.ComponentModel.Design;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            //Console.WriteLine("请输入资产：");
            //int zichan=int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值：");
            //double yanzhi=double.Parse(Console.ReadLine());
            //bool res = zichan > 300 || yanzhi > 9.5;
            //Console.WriteLine(res);

            //小红想做车模，车模条件年龄16~22
            //Console.WriteLine("请输入年龄:");
            //int ningling=int.Parse(Console.ReadLine());
            //bool a1 = ningling > 16 && ningling < 22;
            //Console.WriteLine(a1);

            //根据输入的成绩判断是不及格(小于60),及格(大于60小于80), 良好(大于80小于90),优秀(大于90小于100)
            //Console.WriteLine("请输入成绩");
            //double a=double.Parse(Console.ReadLine());
            //if (a < 60)
            //{
            //    Console.WriteLine("{a}---不及格");
            //}
            //else if (a < 80)
            //{
            //    Console.WriteLine("{a}---及格");
            //}
            //else if (a < 90)
            //{
            //    Console.WriteLine("{a}---良好");
            //}
            //else if (a < 100)
            //{
            //    Console.WriteLine("{a}---优秀");
            //}
            //else
            //{
            //    Console.WriteLine("请输入{0~100}的数");

            //}

            //输入年份，判断是否是闰年(普通闰年：能被4整除但不能被100整除 / 世纪闰年：可以被400整除)
            //Console.WriteLine("请输入年份：");
            //int ning=int.Parse(Console.ReadLine());
            //if (ning %4== 0 && ning %100!= 0 || ning %400== 0)
            //{
            //    Console.WriteLine("闰年");
            //} else
            //    Console.WriteLine("不是闰年");

            //判断是否为奇数，偶数(如果能被2整除则是偶数，否则为奇数)
            //Console.WriteLine("请输入一个数");
            //double b=double.Parse(Console.ReadLine());
            //if(b%2==0)
            //{
            //    Console.WriteLine("{b}---偶数");
            //}else
            //    Console.WriteLine("{b}---奇数");

            //输出星期几
            //Console.WriteLine("请输入数字:");
            //int t=int.Parse(Console.ReadLine());
            //switch (t)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: Console.WriteLine("星期六"); break;
            //    case 7: Console.WriteLine("星期七"); break;
            //    default: Console.WriteLine("重新输入");break;
            //}

            // 输入分数 1~100
            // 判断等级输出
            // 分数90~100  输出A  ===> 分数的十位9 / 10
            // 分数80~90   输出B  ===> 分数的十位8
            // 分数70~80   输出C  ===> 分数的十位7
            // 分数60~70   输出D  ===> 分数的十位6
            // 分数1~60    输出F  ===> 分数的十位0/1/2/3/4/5
            //Console.WriteLine("请输入分数");
            //double s=double.Parse(Console.ReadLine());
            ////int d = Math.Floor(s / 10);
            //double d = s / 10;
            //if (s > 0 && s <= 100)
            //{
            //    switch (d)
            //    {
            //        case 0: Console.WriteLine($"{s}分是F级");break;
            //        case 1: Console.WriteLine($"{s}分是F级");break;
            //        case 2: Console.WriteLine($"{s}分是F级");break;
            //        case 3: Console.WriteLine($"{s}分是F级");break;
            //        case 4: Console.WriteLine($"{s}分是F级");break;
            //        case 5: Console.WriteLine($"{s}分是F级");break;
            //        case 6: Console.WriteLine($"{s}分是D级");break;
            //        case 7: Console.WriteLine($"{s}分是C级");break;
            //        case 8: Console.WriteLine($"{s}分是B级");break;
            //        case 9: Console.WriteLine($"{s}分是A级");break;
            //        case 10: Console.WriteLine($"{s}分是A级");break;

            //    }
            //}
            //else
            //    Console.WriteLine("重新输入");

            // 输出星期几  6-7输出周末  穿透写法
            //Console.WriteLine("请输入数字:");
            //int t = int.Parse(Console.ReadLine());
            //switch (t)
            //{
            //    case 1: 
            //    case 2:
            //    case 3: 
            //    case 4: 
            //    case 5: Console.WriteLine("工作日"); break;
            //    case 6: 
            //    case 7: Console.WriteLine("周末"); break;
            //    default: Console.WriteLine("重新输入"); break;
            //}

            //成绩等级输出 switch 简写
            //Console.WriteLine("请输入分数");
            //double s = double.Parse(Console.ReadLine());
            ////int d = Math.Floor(s / 10);
            ////double d = s / 10;
            //if (s > 0 && s <= 100)
            //{
            //    string w = s switch
            //    {
            //        >= 90 => "优秀",
            //        > 80 => "良好",
            //        > 60 => "及格",
            //        _ => "不及格",
            //    };
            //    Console.WriteLine($"{s}是{w}的");
            //}else
            //    Console.WriteLine($"输入有误");

            //三元表达式: 判断 成年了/ 未成年
            //Console.WriteLine("请输入年龄");
            //double s = double.Parse(Console.ReadLine());
            //string res = s > 18 ? "成年了" : "未成年";
            //Console.WriteLine($"{res}");

            //三元表达式: 判断 闰年(能被4整除但不能被100整除, 能被400整除) 平年
            //    Console.WriteLine("请输入年");
            //    double s = double.Parse(Console.ReadLine());
            //    string y = (s % 4 == 0 && s % 100 != 0 || s % 400 == 0) ? "闰年" : "平年";
            //    Console.WriteLine($"{s}是{y}");

            //奇数偶数判断
            //Console.WriteLine("请输入一个数字:");
            //double a=double.Parse(Console.ReadLine());
            //string res = a % 2 == 0 ? "偶数" : "奇数";
            //Console.WriteLine($"{a}是{res}");

            //是否在线
            //Console.WriteLine("请输入一个数");
            //int b =int.Parse(Console.ReadLine());
            //if (b == 1) Console.WriteLine($"在线");
            //else Console.WriteLine("不在线");


            //文件大小单位不同（1024以下kb / 以上MB）
            //Console.WriteLine("请输入一个数");
            //int b =int.Parse(Console.ReadLine());
            //if(b>1024)
            //{
            //    int c = b / 1024;
            //    Console.WriteLine($"{c}MB");
            //}else Console.WriteLine($"{b}kb");


            //数学运算计算器：让用户输入两个数字，再输入一个运算符(+-* /)，判断输入的运算符是什么，对两个数字进
            //行对应的数学运算，将结果输出
            //Console.WriteLine("请输入一个数");
            //int b1 =int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入一个数");
            //int b2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入一个运算符");
            //string b3=Console.ReadLine();
            //switch(b3)
            //{
            //    case "+":
            //    Console.WriteLine($"b1{b3}b2={b1+b2}");
            //    break;
            //    case "-":
            //    Console.WriteLine($"b1{b3}b2={b1+b2}");
            //    break;
            //    case "*":
            //    Console.WriteLine($"b1{b3}b2={b1 + b2}");
            //        break;
            //    case "/":
            //        if(b2==0) Console.WriteLine($"有误");
            //    else Console.WriteLine($"b1{b3}b2={b1 + b2}");
            //    break;
            //    default:
            //    Console.WriteLine("输出有误");
            //    break;
            //}

            //不同血型不同性格：输入血型，当血型为A时，输出"细心稳重"；当血型为B时，输出"乐观自由"；当血型为AB
            //时，输出"思维多变"；当血型为O时，输出"热情外向
            //Console.WriteLine("请输入一个数");
            //string c= Console.ReadLine();
            //string res = c switch
            //{
            //    "A" => "细心稳重",
            //    "B" => "乐观自由",
            //    "AB" => "思维多变",
            //    "O" => "热情外向",


            //}; Console.WriteLine(res);

            //账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；账号不对，就输出账号不存在；密码不对，就输出密码错误。
            //Console.WriteLine("请输入账号");
            //string b1 = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string b2 = Console.ReadLine();
            //string a = "admin";
            //string b = "123456";
            //if(b1==a)
            //{
            //    if (b2 == b) Console.WriteLine($"登入成功");
            //    else Console.WriteLine($"密码错误");
            //}
            //else Console.WriteLine($"账号不存在");

            //选择菜单（add / edit / del）执行操作（练习多分支和switch）：提示用户选择菜单（add / edit / del），判断输入的是add，就输出新增成功；输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
            //Console.WriteLine("请输入菜单");
            //string c = Console.ReadLine();
            //string res = c switch
            //{
            //    "add" => "新增成功",
            //    "edit" => "编辑成功",
            //    "del" => "删除成功"
            //}; Console.WriteLine(res);

            ////会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：让用户输入自己的类型（VIP / USER）和消费金额，如果是VIP，判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
            //Console.WriteLine("请输入用户类型");
            //string a = Console.ReadLine();
            //Console.WriteLine("请输入消费金额");
            //double b=double.Parse(Console.ReadLine());
            //if (a == "会员")
            //{
            //    if (b > 1000) Console.WriteLine($"{b * 0.9}");
            //    else Console.WriteLine($"{b}");
            //}
            //else if (b > 2000) Console.WriteLine($"{b * 0.95}");
            //else Console.WriteLine($"{b}");

            //通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。
            //Console.WriteLine("请输入月份：");
            //int a=int.Parse(Console.ReadLine());
            //switch(a)
            //{

            //    case 3: 
            //    case 4: 
            //    case 5: Console.WriteLine("春季"); break;
            //    case 6:
            //    case 7: 
            //    case 8: Console.WriteLine("夏季"); break;
            //    case 9:
            //    case 10:
            //    case 11: Console.WriteLine("秋季"); break;
            //    case 12:
            //    case 1:
            //    case 2: Console.WriteLine("冬季"); break;
            //    default: Console.WriteLine("重新输入"); break;


            //}

            //快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。
            //Console.WriteLine("请输入快递重量：");
            //double a=double.Parse(Console.ReadLine());
            //if(a<1&&a>0) Console.WriteLine($"快递费10元");
            //else if(a>1&&a<5) Console.WriteLine($"快递费20元");
            //else if(a>5) Console.WriteLine($"快递费50");

            //会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；等级是4，输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。
            //Console.WriteLine("请输入会员等级");
            //string a = Console.ReadLine();
            //string res = a switch
            //{
            //    "1" => "没有福利",
            //    "2" => "没有福利",
            //    "3" => "已购买矿泉水",
            //    "4" => "每月可领优惠券",
            //    "5" => "终身免运费"

            //}; Console.WriteLine(res);

            //-自动售货机选商品（练习多分支和switch）：输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；3输出已购买矿泉水；否则输出无此商品。
            //Console.WriteLine("请输入商品编号整数");
            //string a=Console.ReadLine();
            //string res = a switch
            //{
            //    "1" => "已购买可乐",
            //    "2" => "已购买雪碧",
            //    "3" => "已购买矿泉水",
            //    "4" => "无此商品"

            //}; Console.WriteLine(res);

            //速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。
            Console.WriteLine("请输入当前速度");
            int a=int.Parse(Console.ReadLine());
            if(a>0&&a<30) Console.WriteLine($"低速通过");
            else if(a>=30&&a<60) Console.WriteLine($"中速通过");
            else if(a>=60&&a<100) Console.WriteLine($"高速通过");
            else if(a>=100&&a<120) Console.WriteLine($"超速通过");
     
           ; 













        }
    }
}
