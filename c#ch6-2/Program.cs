using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace c_ch6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
            //Console.WriteLine("輸入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi~" + name);
            //Console.ReadKey();

            //2.請輸入任何一個字，是否出現在”人人為我，我為人人、
            //饒人不癡漢，癡漢不饒人”這個字串裡。
            //string text = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //Console.WriteLine("請輸入任何一個字");
            //string input = Console.ReadLine();
            //if (text.Contains(input))
            //{
            //    Console.WriteLine("人人為我，我為人人、饒人不癡漢，癡漢不饒人");
            //    Console.WriteLine($"'{input}'有在字串中");
            //}
            //else
            //{
            //    Console.WriteLine("人人為我，我為人人、饒人不癡漢，癡漢不饒人");
            //    Console.WriteLine($"'{input}'不在字串中");
            //}
            //Console.ReadKey();

            //3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
            //--->InsertDashes每個字符之間有 - 的形式
            //    Console.WriteLine("輸入一段字: ");
            //    string input = Console.ReadLine();
            //    string output = dashes(input);
            //    Console.WriteLine(output);
            //    Console.ReadKey();
            //}
            //static string dashes(string input) {
            //    string result = "";
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        result += input[i];
            //        if (i < input.Length - 1)
            //        {
            //            result += "-";
            //        }
            //    }
            //    return result;

            //4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
            //Console.Write("輸入檔名：");
            //string name = Console.ReadLine();
            //          //Path.GetExtension 取得副檔名，並移除前面的點 (".")
            //string ex = Path.GetExtension(name).TrimStart('.');
            //Console.WriteLine("副檔名"+ ex );
            //Console.ReadKey();

            //5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若
            //大於五個字，則輸出前三個字。Length
            //Console.WriteLine("請輸入一個單字");
            //string word = Console.ReadLine();
            //if(word.Length<=5)
            //{
            //    Console.WriteLine("長度不夠");
            //}
            //else
            //{
            //    string three = word.Substring(0,3);//從0取前三個字
            //    Console.WriteLine("前三個字是:" + three);
            //}Console.ReadKey();

            //6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，
            //如輸入我在唱歌，輸出小明在唱歌。Replace()
            //Console.WriteLine("請輸入一段文字");
            //string input = Console.ReadLine();
            //string output = input. Replace("我", "小明");
            ////將 input 字串中所有的「我」替換為「小明」
            //Console.WriteLine("替換後:"+output);
            //Console.ReadKey();

            //7.輸入一串字，顯示輸入幾個字。Length
            //Console.WriteLine("請輸入一串字：");
            //string input = Console.ReadLine();
            //int lengthlong = input.Length;
            //Console.WriteLine($"你輸入了{lengthlong}個字");
            //Console.ReadKey();

            //補充1連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
            //--->HashSet 來記錄每次輸入的字串
            //HashSet<string> word = new HashSet<string>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("輸入一組文字:");
            //    string input = Console.ReadLine();
            //    if (word.Contains(input))
            //    {
            //        Console.WriteLine("這組已輸入過");
            //    }
            //    else
            //    {
            //        Console.WriteLine("這組沒出現過");
            //        word.Add(input);
            //    }
            //}
            //Console.WriteLine("輸入結束");
            //Console.ReadKey();

            //補充2用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出FifafIfafiFafifA
            //Console.WriteLine("請輸入單字:");
            //string input = Console.ReadLine();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    {
            //        string wave = "";
            //        for (int j = 0; j < input.Length; j++)
            //        {
            //            if (j == i)
            //            {
            //                wave += Char.ToUpper(input[j]);
            //            }
            //            else
            //            {
            //                wave += Char.ToLower(input[j]);
            //            }

            //        }
            //        Console.WriteLine(wave);
            //    }
            //}    Console.ReadKey();


            //補充3輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
            //Console.WriteLine("請輸入時間: ex:12:30");
            //string input = Console.ReadLine();
            //if (DateTime.TryParse(input,out DateTime time))
            //{
            //    Console.WriteLine($"{time.Hour}點{time.Minute}分");
            //}
            //else
            //{
            //    Console.WriteLine("請重新輸入");
            //}
            //Console.ReadKey();

            //補充4輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
            //< ul >
            //    < li > Justin<li>
            //    < li > Amy<li>
            //    < li > David<li>
            //</ ul >
            Console.WriteLine("請輸入名字 用逗號分隔 ex.Justin,Amy,David");
            string input = Console.ReadLine();
            string[] name = input.Split(',');
            Console.WriteLine("<ul>");
            foreach (string a in name)
            {
                Console.WriteLine($"<li>{a}<li>");
            }
            Console.WriteLine("<ul>");
            Console.ReadKey();

            //補充5輸入5處數字，用空白隔開，輸出總和。
            //例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
            //--->Split(' '); // 使用空格作為分隔符
            //Console.WriteLine("請輸入5個數字，用空白隔開");
            //string input = Console.ReadLine();
            //int sum = input.Split(' ')
            //          .Select(int.Parse)
            //          .Sum();
            //Console.WriteLine("總和是:" + sum);
            //Console.ReadKey();

            //補充6輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
            //Console.Write("輸入一段字: ");
            //string input = Console.ReadLine();
            //char[] output = input.ToCharArray();// 將字串轉換為字符陣列
            //Array.Reverse(output); //反轉字符陣列
            //string a = new string(output);
            //Console.Write(a);
            //Console.ReadKey();
        }
    }
}

     

