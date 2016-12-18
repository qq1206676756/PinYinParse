using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.International.Converters.PinYinConverter;
using PinYinParse.Plan;

namespace PinYinParse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ChineseChar 小试
            //string str = Console.ReadLine();
            //var ch = str[0];
            //Console.WriteLine($"汉字:{ch}");

            //ChineseChar cc = new ChineseChar(ch);
            //var pinyins = cc.Pinyins.ToList();
            //pinyins.ForEach(p =>
            //{
            //    Console.WriteLine($"拼音：{p}");
            //});
            #endregion

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入中文：");
                string str = Console.ReadLine();
                var strs = PinYinConverterHelp.GetTotalPingYin(str).TotalPingYin;
                var frists = PinYinConverterHelp.GetTotalPingYin(str).FirstPingYin;
                Console.WriteLine("全拼音：" + String.Join(",", strs));
                Console.WriteLine("首音：" + String.Join(",", frists));
                Console.WriteLine();
            }
        }
    }
}
