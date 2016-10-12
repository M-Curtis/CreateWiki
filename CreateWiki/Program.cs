using System;
using System.Collections.Generic;
using System.IO;
using log4net.Appender;
using Microsoft.VisualBasic.FileIO;

namespace CreateWiki
{
    static class Program
    {
        private static void Main(string[] args)
        {
            List<Company> companies = new List<Company>();
            var companyInput = "";
            var products = new string[10];
            Console.WriteLine("Reading data..");
            using (var fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "a.txt", FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    companyInput = sr.ReadLine();
                    products[0] = sr.ReadLine();
                    products[1] = sr.ReadLine();
                    products[2] = sr.ReadLine();
                    products[3] = sr.ReadLine();
                    products[4] = sr.ReadLine();
                    products[5] = sr.ReadLine();
                    products[6] = sr.ReadLine();
                    products[7] = sr.ReadLine();
                    products[8] = sr.ReadLine();
                    products[9] = sr.ReadLine();
                }
            }
            Console.WriteLine("Parsing data..");
            var output = companyInput.Split(Convert.ToChar(","));

            var Product0 = products[0].Split(Convert.ToChar(","));
            var Product1 = products[1].Split(Convert.ToChar(","));
            var Product2 = products[2].Split(Convert.ToChar(","));
            var Product3 = products[3].Split(Convert.ToChar(","));
            var Product4 = products[4].Split(Convert.ToChar(","));
            var Product5 = products[5].Split(Convert.ToChar(","));
            var Product6 = products[6].Split(Convert.ToChar(","));
            var Product7 = products[7].Split(Convert.ToChar(","));
            var Product8 = products[8].Split(Convert.ToChar(","));
            var Product9 = products[9].Split(Convert.ToChar(","));

            for (int i = 0; i < Product0.Length; i++)
            {
                if (Product0[i].Contains("("))
                {
                    Product0[i] = Product0[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product1.Length; i++)
            {
                if (Product1[i].Contains("("))
                {
                    Product1[i] = Product1[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product2.Length; i++)
            {
                if (Product2[i].Contains("("))
                {
                    Product2[i] = Product2[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product3.Length; i++)
            {
                if (Product3[i].Contains("("))
                {
                    Product3[i] = Product3[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product4.Length; i++)
            {
                if (Product4[i].Contains("("))
                {
                    Product4[i] = Product4[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product5.Length; i++)
            {
                if (Product5[i].Contains("("))
                {
                    Product5[i] = Product5[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product6.Length; i++)
            {
                if (Product6[i].Contains("("))
                {
                    Product6[i] = Product6[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product7.Length; i++)
            {
                if (Product7[i].Contains("("))
                {
                    Product7[i] = Product7[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product8.Length; i++)
            {
                if (Product8[i].Contains("("))
                {
                    Product8[i] = Product8[i].Split(Convert.ToChar("("))[0];
                }
            }
            for (int i = 0; i < Product9.Length; i++)
            {
                if (Product9[i].Contains("("))
                {
                    Product9[i] = Product9[i].Split(Convert.ToChar("("))[0];
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = output[i].Trim();
                if (output[i].Contains(" "))
                {
                    output[i] = output[i].Replace(" ", "-");
                }
            }
            for (int i = 0; i < output.Length; i++)
            {
                companies.Add(new Company(output[i], Product0[i], Product1[i], Product2[i], Product3[i], Product4[i], Product5[i], Product6[i], Product7[i], Product8[i], Product9[i]));
            }

            Console.WriteLine("Writing data..");
            foreach (var company in companies)
            {
                using (var fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + $"/companies/{company.name}.txt",FileMode.Create,FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"====== {company.name} ======");
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine("===== Support status =====");
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine("===== Products =====");
                        sw.WriteLine();
                        if (company.product0 != "")
                        {
                            sw.WriteLine(company.product0);
                        }
                        if (company.product1 != "")
                        {
                            sw.WriteLine(company.product1);
                        }
                        if (company.product2 != "")
                        {
                            sw.WriteLine(company.product2);
                        }
                        if (company.product3 != "")
                        {
                            sw.WriteLine(company.product3);
                        }
                        if (company.product4 != "")
                        {
                            sw.WriteLine(company.product4);
                        }
                        if (company.product5 != "")
                        {
                            sw.WriteLine(company.product5);
                        }
                        if (company.product6 != "")
                        {
                            sw.WriteLine(company.product6);
                        }
                        if (company.product7 != "")
                        {
                            sw.WriteLine(company.product7);
                        }
                        if (company.product8 != "")
                        {
                            sw.WriteLine(company.product8);
                        }
                        if (company.product9 != "")
                        {
                            sw.WriteLine(company.product9);
                        }
                        sw.WriteLine();
                        sw.WriteLine("===== Contacts =====");
                        sw.WriteLine("^ Name            ^ Email                      ^ Telephone  ^");
                        sw.WriteLine("|                 |                            |            |");
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine("===== Address =====");
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine();
                    }
                }
                using (var fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + $"/inf/{company.name}.changes", FileMode.Create, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"1476092610	192.168.10.70	C	customer-information:{company.name}	admin	created		3");
                    }
                }
                using (var fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + $"/inf/{company.name}.meta", FileMode.Create, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"a:2:{{s:7:\"current\";a:7:{{s:4:\"date\";s:0:\"\";s:7:\"creator\";s:0:\"\";s:4:\"user\";s:0:\"\";s:11:\"last_change\";s:0:\"\";s:8:\"internal\";s:0:\"\";s:11:\"description\";s:0:\"\";s:8:\"relation\";s:0:\"\";}}s:10:\"persistent\";a:4:{{s:4:\"date\";a:1:{{s:7:\"created\";i:1476092610;}}s:7:\"creator\";s:22:\"DokuWiki Administrator\";s:4:\"user\";s:5:\"admin\";s:11:\"last_change\";a:8:{{s:4:\"date\";i:1476092610;s:2:\"ip\";s:13:\"192.168.10.70\";s:4:\"type\";s:1:\"C\";s:2:\"id\";s:24:\"customer-information:{company.name}\";s:4:\"user\";s:5:\"admin\";s:3:\"sum\";s:7:\"created\";s:5:\"extra\";s:0:\"\";s:10:\"sizechange\";i:3;}}}}}}");
                    }
                }
            }
            Console.WriteLine("done");
            Console.ReadKey();

        }
    }
}
