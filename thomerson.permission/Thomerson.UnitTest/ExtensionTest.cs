using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using thomerson.Gatlin;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Thomerson.UnitTest
{
    [TestClass]
    public class ExtensionTest
    {
        [TestMethod]
        public void CheckNullOrEmpty()
        {
            try
            {
                var task = new Task(() => { Console.WriteLine("New Task Run"); });
                task.Start();

                Task.Run(() =>  //static function 
                {
                    Console.WriteLine("New Task Run");
                });

                var aa = 10;
                var bb = aa;
                bb = 100;
                Console.WriteLine(aa);

                dynamic dd = new { aa = 1 };
                dd.aa = 2;
                dd.bb = "dd";

                dd = 1;

                Console.WriteLine(dd.bb);

                var str1 = "aaaa";
                var str2 = str1;
                var res = object.ReferenceEquals(str1, str2);

                string str = "Old String";
                ChangeStr(str);
                Console.WriteLine(str);

                ChangeStr(ref str);
                Console.WriteLine(str);

                var a = 15;
                ChangeStr(a);
                Console.WriteLine(a);


                var s = new Mo() { A = 20 };
                ChangeStr(s);
                Console.WriteLine(s.A);

                //var str2 = string.Empty;
                str.CheckNullOrEmpty("专业组");
            }
            catch (System.Exception ex)
            {
                throw;
            }

        }

        public static void TaskFactoryTest()
        {
            var factory = new TaskFactory();

            for (int i = 0; i < 10; i++)
            {
                var task = factory.StartNew(() =>
                {
                    Console.WriteLine("Task : {0}", i);
                    System.Threading.Thread.Sleep(5000);
                    return i;
                });

                Console.WriteLine("Task Result: {0}", task.Result);
            }
        }

        public static void Test()
        {
            //设置同时执行最大执行数  和  最大异步I/O线程数
            ThreadPool.SetMaxThreads(5, 10);

            for (int i = 0; i < 20; i++)
            {
                //添加线程  带object参数
                ThreadPool.QueueUserWorkItem(Work, i);
            }

        }

        public static void Work(object state)
        {
            Console.WriteLine("thread:{0} start", state);
            Thread.Sleep(5000);
            Console.WriteLine("thread:{0} end", state);
        }

        //  - 该方法具有一个async修饰符.  
        //  - 返回类型为 Task or Task<t>. (参考 "返回类型" 一节.)
        //    这里, 返回值是 Task<int> 因为返回的是一个整数类型. 
        //  - 这个方法的名称以 "Async" 结尾.
        async Task<int> AccessTheWebAsync()
        {
            // 你需要添加System.Net.Http的引用来声明client
            var client = new System.Net.Http.HttpClient();

            // GetStringAsync 返回 Task<string>. 这意味着当Task结束等待之后 
            // 你将得到一个string (urlContents).
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

            // 你可以做一些不依赖于 GetStringAsync 返回值的操作.
            //DoIndependentWork();

            // await 操作挂起了当前方法AccessTheWebAsync. 
            //  - AccessTheWebAsync 直到getStringTask完成后才会继续. 
            //  - 同时, 控制权将返回 AccessTheWebAsync 的调用者. 
            //  - 控制权会在getStringTask完成后归还到AccessTheAsync.  
            //  - await操作将取回getStringTask中返回的string结果. 
            string urlContents = await getStringTask;

            // return语句用来指定一个整数结果。
            // 调用AccessTheWebAsync将会收到一个返回值的长度. 
            return urlContents.Length;
        }



        void ChangeStr(string aStr)
        {
            aStr = "Changing String";
            Console.WriteLine(aStr);
        }

        void ChangeStr(int aStr)
        {
            aStr = 10;
            Console.WriteLine(aStr);
        }

        void ChangeStr(ref string aStr)
        {
            aStr = "Changing String new";
            Console.WriteLine(aStr);
        }

        void ChangeStr(Mo aStr)
        {
            aStr.A = 5;
            Console.WriteLine(aStr.A);
        }


        static void LingTest()
        {
            var List = new List<Student>() { };
        }


    }

    public class Mo
    {
        public int A { get; set; }
    }

    public class Student
    {
        int Id { get; set; }
        string Name { get; set; }
        int Score { get; set; }
    }
}
