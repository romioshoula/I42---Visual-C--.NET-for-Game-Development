using System;
using System.Collections.Generic;
using System.Linq;
using static L2O___D09.ListGenerators;
using System.IO;

namespace Day10_Submission
{

    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            Console.WriteLine("LINQ - Restriction Operators");
            //Task 1
            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            var Result = from P in ProductList
                         where P.UnitsInStock == 0
                         group P by P.Category;
            foreach (var i in Result)
            {
                foreach (var j in i)
                    Console.WriteLine($"{j.ProductID}");
            }

            #endregion
            //Task 2
            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            Result = from P in ProductList
                     where P.UnitsInStock > 0
                     where P.UnitPrice > 3.00m
                     group P by P.Category;

            foreach (var i in Result)
            {
                foreach (var j in i)
                    Console.WriteLine($"{j}");
            }

            #endregion
            //Task 3
            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3");

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var res = Arr.Where((D, i) => D.Length < i);
            foreach (var i in res)
            {
                Console.WriteLine($"{i}");
            }

            #endregion
            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////  
            #region LINQ - Element Operators

            Console.WriteLine("LINQ - Element Operators");

            //Task 1
            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            var Prod = (from P in ProductList
                     where P.UnitsInStock == 0
                     select P).First();
            Console.WriteLine(Prod);

            #endregion

            //Task 2
            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            Prod = (from P in ProductList
                 where P.UnitPrice > 1000m
                 select P).FirstOrDefault();
            Console.WriteLine(Prod);
            #endregion

            //Task 3
            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var ergregreg = arr.OrderByDescending(r => r).Skip(2).FirstOrDefault(); //skip 2 to get second number greater than 5 not first
            Console.WriteLine(ergregreg);
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////  
            #region LINQ - Set Operators
            Console.WriteLine("LINQ - Set Operators");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            var catnms = ProductList.Select(P => P.Category).Distinct();
            foreach (var i in catnms)
            {
                Console.WriteLine($"{i}");
            }
            #endregion

            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            var prodlist = ProductList.Select(P => P.Category[0]);
            var customerloist = CustomerList.Select(C => C.CustomerID[0]);
            var bothlist = prodlist.Union(customerloist);

            foreach (var i in bothlist)
                Console.WriteLine($"{i}");
            #endregion

            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            var firstcommon = customerloist.Intersect(prodlist);

            foreach (var i in firstcommon)
                Console.WriteLine($"{i}");
            #endregion

            #region Task 4
            Console.WriteLine("");
            Console.WriteLine("Task 4: ");
            var commonuniq = prodlist.Except(customerloist);

            foreach (var i in commonuniq)
                Console.WriteLine($"{i}");
            #endregion

            #region Task 5
            Console.WriteLine("");
            Console.WriteLine("Task 5: ");
            var prodlast = ProductList.
            Select(P => (P.ProductName.Substring(P.ProductName.Length - 3)));
            var customerlast = CustomerList
                .Select(C => ((C.CustomerID.Substring(C.CustomerID.Length - 3))));

            var threes = prodlast.Concat(customerlast);

            foreach (var i in threes)
                Console.WriteLine($"{i}");
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////  
            #region LINQ - Aggregate Operators
            Console.WriteLine("LINQ - Aggregate Operators");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            int[] array_ODD = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var No_of_Odd = array_ODD.Count(i => i % 2 != 0);
            Console.WriteLine(No_of_Odd);
            #endregion

            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            var custmoerorder = CustomerList.Select(i => new { customer = i, orders = i.Orders.Count() });

            foreach (var i in custmoerorder)
                Console.WriteLine($"{i}");
            #endregion

            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            var countproducts = ProductList.GroupBy(i => i.Category).Select(i => new { category = i.Key, count = i.Count() });
            foreach (var i in countproducts)
                Console.WriteLine($"{i}");
            #endregion

            #region Task 4
            Console.WriteLine("");
            Console.WriteLine("Task 4: ");
            int[] ar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var summation = ar.Sum();
            Console.WriteLine($"{summation}");
            #endregion

            #region Task 5
            Console.WriteLine("");
            Console.WriteLine("Task 5: ");
            string[] dict = System.IO.File.ReadAllLines("dictionary_english.txt");
            var Lettering = dict.Select(i => i.Count()).Sum();
            Console.WriteLine($"{Lettering}");
            #endregion

            #region Task 6
            Console.WriteLine("");
            Console.WriteLine("Task 6: ");
            var productunitinstock = ProductList.Sum(i => i.UnitsInStock);
            Console.WriteLine($"{productunitinstock}");
            #endregion

            #region Task 7
            Console.WriteLine("");
            Console.WriteLine("Task 7: ");
            var smallest = dict.Min(i => i.Count());
            Console.WriteLine($"{smallest}");
            #endregion

            #region Task 8
            Console.WriteLine("");
            Console.WriteLine("Task 8: ");
            var cheap1 = ProductList.GroupBy(p => p.Category).Select(i => i.Min(P => P.UnitPrice));
            foreach (var c in cheap1)
                Console.WriteLine(c);
            #endregion

            #region Task 9
            Console.WriteLine("");
            Console.WriteLine("Task 9: ");
            var stockCount = from P in ProductList
                             group P by P.Category into c
                             let stockSum = c.Sum(P => P.UnitsInStock)
                             select new { Category = c.Key, totalUnits = stockSum };
            foreach (var hhh in stockCount)
                Console.WriteLine($"{hhh}");
            Console.WriteLine();
            #endregion

            #region Task 10
            Console.WriteLine("");
            Console.WriteLine("Task 10: ");
            var longest = dict.Max(W => W.Count());
            Console.WriteLine($"{longest}");
            #endregion

            #region Task 11
            Console.WriteLine("");
            Console.WriteLine("Task 11: ");
            var expensive = ProductList.GroupBy(p => p.Category).Select(C => C.Max(P => P.UnitPrice));
            foreach (var c in expensive)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 12
            Console.WriteLine("");
            Console.WriteLine("Task 12: ");
            var mostexp = from P in ProductList
                          group P by P.Category into CCC
                          let exp = CCC.Max(P => P.UnitPrice)
                          select new { Category = CCC.Key, MostExpensive = exp };
            foreach (var c in mostexp)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 13
            Console.WriteLine("");
            Console.WriteLine("Task 13: ");
            var sec = dict.Select(W => W.Count());
            var avg = sec.Average();
            Console.WriteLine($"{avg}");
            #endregion

            #region Task 14
            Console.WriteLine("");
            Console.WriteLine("Task 14: ");
            var avgproduct = ProductList.GroupBy(x => x.Category).Select(z => z.Average(P => P.UnitPrice)); ;
            Console.WriteLine($"{avgproduct}");
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////
            #region LINQ - Ordering Operators
            Console.WriteLine("LINQ - Ordering Operators");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            var srtprod = ProductList.OrderBy(P => P.ProductName);
            foreach (var c in srtprod)
            {
                Console.WriteLine(c);

            }
            #endregion

            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            string[] arz = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            CaseSensetiveCheckComparer cer = new CaseSensetiveCheckComparer();
            var srted = arz.OrderBy(W => W, cer);
            foreach (var c in srted)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            var sortunits = ProductList.OrderByDescending(P => P.UnitsInStock);
            foreach (var c in sortunits)
            {
                Console.WriteLine(c);

            }
            #endregion

            #region Task 4
            Console.WriteLine("");
            Console.WriteLine("Task 4: ");
            string[] arrrrr = { "zero", "one", "two", "three", "four",
                              "five", "six", "seven", "eight", "nine" };

            var startdigit = arrrrr.OrderBy(D => D.Count()).ThenBy(D => D);

            foreach (var c in startdigit)
            {
                Console.WriteLine(c);

            }
            #endregion

            #region Task 5
            Console.WriteLine("");
            Console.WriteLine("Task 5: ");
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var strtbylen = words.OrderBy(W => W.Count()).ThenBy(W => W, cer);

            foreach (var c in strtbylen)
            {
                Console.WriteLine(c);

            }
            #endregion

            #region Task 6
            Console.WriteLine("");
            Console.WriteLine("Task 6: ");
            var strtbyprice = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            foreach (var c in strtbyprice)
            {
                Console.WriteLine(c);

            }
            #endregion

            #region Task 7_1
            Console.WriteLine("");
            Console.WriteLine("Task 7_1: ");
            var strtword = words.OrderBy(D => D.Count()).ThenByDescending(D => D, cer);
            foreach (var c in strtword)
            {
                Console.WriteLine(c);

            }
            #endregion

            #region Task 7_2
            Console.WriteLine("");
            Console.WriteLine("Task 7_2: ");
            string[] asd = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            List<String> adwad = asd.ToList();
            var strl = asd.Where(D => D[1] == 'i').OrderByDescending(D => adwad.IndexOf(D));

            foreach (var c in strl)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 7_3
            Console.WriteLine("");
            Console.WriteLine("Task 7_3: ");
            var prodname = ProductList.Select(P => P.ProductName);

            foreach (var c in prodname)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region 7_4
            Console.WriteLine("");
            Console.WriteLine("Task 7_4: ");
            string[] wordsarr = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var wvar = wordsarr.Select(P => new { Upper = P.ToUpper(), Lower = P.ToLower() });

            foreach (var c in wvar)
            {
                Console.WriteLine(c);
            }
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////
            #region LINQ - Partitioning Operators
            Console.WriteLine("LINQ - Partitioning Operators");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            var newprod = ProductList.Select(P => new { price = P.UnitPrice, id = P.ProductID, name = P.ProductName });

            foreach (var c in newprod)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            int[] ararar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var vallal = ararar.Select((D, i) => D == i);

            foreach (var c in vallal)
            {
                Console.WriteLine(c);
            }
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////
            #region LINQ - Projection Operators
            Console.WriteLine("LINQ - Projection Operators");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");

            foreach (var c in newprod)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 5
            Console.WriteLine("");
            Console.WriteLine("Task 5: ");
            int[] n1 = { 0, 2, 4, 5, 6, 8, 9 };
            int[] n2 = { 1, 3, 5, 7, 8 };

            var pairs = from A in n1
                        let B = n2
                        from item in B
                        where A < item
                        select A + " is less than: " + item;

            foreach (var c in pairs)
            {

                Console.WriteLine(c);
            }
            #endregion

            #region Task 6
            Console.WriteLine("");
            Console.WriteLine("Task 6: ");
            var lless500 = CustomerList.SelectMany(C => C.Orders).Where(a => a.Total < 500);
            foreach (var c in lless500)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Task 7
            Console.WriteLine("");
            Console.WriteLine("Task 7: ");
            var a19 = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);
            foreach (var c in a19)
            {
                Console.WriteLine(c);
            }
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////
            #region LINQ - Quantifiers
            Console.WriteLine("LINQ - Quantifiers");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            bool haslet = dict.Any(W => W.Contains("ei"));
            Console.WriteLine($"{haslet}");
            #endregion

            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            var lessone = ProductList.GroupBy(P => P.Category).Where(C => C.Any(P => P.UnitsInStock < 1));
            foreach (var c in lessone)
            {
                foreach (var i in c)
                    Console.WriteLine(i);
            }
            #endregion

            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            var alllin = ProductList.GroupBy(P => P.Category).Where(C => C.All(P => P.UnitsInStock > 0));
            foreach (var c in alllin)
            {
                foreach (var i in c)
                    Console.WriteLine(i);
            }
            #endregion

            //Break
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            #endregion
            ////////////////////////////////////////////////////
            #region LINQ - Grouping Operators
            Console.WriteLine("LINQ - Grouping Operators");

            #region Task 1
            Console.WriteLine("");
            Console.WriteLine("Task 1: ");
            var seq = Enumerable.Range(0, 15);
            var asdasdasd = seq.GroupBy(N => N % 5);

            foreach (var c in asdasdasd)
            {
                foreach (var i in c)
                    Console.WriteLine(i);
            }
            #endregion

            #region Task 2
            Console.WriteLine("");
            Console.WriteLine("Task 2: ");
            var Dictionary_Read = dict.GroupBy(W => W[0]);


            foreach (var c in Dictionary_Read)
            {
                foreach (var i in c)
                    Console.WriteLine(i);
            }
            #endregion

            #region Task 3
            Console.WriteLine("");
            Console.WriteLine("Task 3: ");
            string[] string_read = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            WordsCheckComparer pp = new WordsCheckComparer();
            var gwords = string_read.GroupBy(W => W, pp);

            foreach (var c in gwords)
            {
                foreach (var i in c)
                    Console.WriteLine(i);
            }
            #endregion
            #endregion
        }

    }
}
