using EntityFramework_CodeFirst_Manual.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Manual
{
    class LinqDepiction
    {
        /// <summary>
        /// LINQ SELECT基本查詢
        /// </summary>
        public static void select() {

            using (var context = new LunchBoxModel())
            {
                //查詢SELECT
                IQueryable<Product> products =
                    from product in context.Product
                    select product;

                foreach (Product p in products)
                {
                    Console.WriteLine(
                        "分類:{0}\t{1}\t{2}\t價格:{2}\t",
                        p.Category,
                        p.Id,
                        p.Name,
                        p.Price
                    );
                }
            }
        }
        /// <summary>
        /// LINQ SELECT結果放入匿名型別Object
        /// </summary>
        public static void selectResultToAnonyObject() {

            using (var context = new LunchBoxModel())
            {
                //查詢SELECT
                var products =
                    from product in context.Product
                    select new {
                                product.Name,
                                product.Price 
                                };

                foreach (var p in products)
                {
                    Console.WriteLine(
                        "分類:{0}\t{1}",
                        p.Price,
                        p.Name
                    );
                }
            }
        }

        /// <summary>
        /// LINQ SELECT結果放入匿名型別Object,並指定參數加入運算
        /// </summary>
        public static void selectResultToAnonyObject2()
        {

            using (var context = new LunchBoxModel())
            {
                //查詢SELECT
                var products =
                    from product in context.Product
                    select new {
                                ProductName = product.Name,
                                Price = product.Price,
                                SPrict = product.Price * 0.8
                    };

                foreach (var p in products)
                {
                    Console.WriteLine(
                        "分類:{0}\t特價:{1}\t商品:{2}",
                        p.Price,
                        p.SPrict,
                        p.ProductName
                    );
                }
            }
        }

        /// <summary>
        /// LINQ SELECT結果放入匿名型別Object,並指定參數加入運算
        /// </summary>
        public static void selectResultToClassObject()
        {

            using (var context = new LunchBoxModel())
            {
                //查詢SELECT
                IEnumerable<SProduct> products =
                    from product in context.Product
                    select new SProduct()
                    {
                        PId = product.Id.ToString(),
                        SName = product.Category + "-" + product.Name,
                        Price = product.Price,
                        SPrice = product.Price * 0.8
                    };

                foreach (var p in products)
                {
                    Console.WriteLine(
                        "{0}\t定價:{1}\t特價:{2}\t:{3}",
                        p.PId,
                        p.Price,
                        p.SPrice,
                        p.SName
                    );
                }
            }
        }
        class SProduct {
            public string PId { get; set; }
            public string SName { get; set; }
            public int Price { get; set; }
            public double SPrice { get; set; }
        }
        /// <summary>
        /// 多維陣列select
        /// </summary>
        public static void selectNestedArray()
        {
            string[] weekMonth = {"JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER",
                                  "Monday, Tusday, Wednesday, Thursday, Friday, Saturday, Sunday" };

            IEnumerable<string> enumWeekMonth = from wm in weekMonth
                                                from daywm in wm.Split(',')
                                                select daywm.Substring(0, 3);

            string weekDayOutPut = "一星期七天與十二個月的英文全名:\n";
            foreach (string dayweekMonth in weekMonth)
            {
                weekDayOutPut = weekDayOutPut + dayweekMonth + "\n";
            }
            Console.WriteLine(weekDayOutPut);

            weekDayOutPut = "一星期七天與十二個月的英文全名縮寫:\n";

            foreach (string dayweekmonth in enumWeekMonth)
            {
                weekDayOutPut = weekDayOutPut + dayweekmonth + "\n";
            }

            Console.WriteLine(weekDayOutPut);
           
        }

    }
}
