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
                str.CheckNullOrEmpty("רҵ��");
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
            //����ͬʱִ�����ִ����  ��  ����첽I/O�߳���
            ThreadPool.SetMaxThreads(5, 10);

            for (int i = 0; i < 20; i++)
            {
                //����߳�  ��object����
                ThreadPool.QueueUserWorkItem(Work, i);
            }

        }

        public static void Work(object state)
        {
            Console.WriteLine("thread:{0} start", state);
            Thread.Sleep(5000);
            Console.WriteLine("thread:{0} end", state);
        }

        //  - �÷�������һ��async���η�.  
        //  - ��������Ϊ Task or Task<t>. (�ο� "��������" һ��.)
        //    ����, ����ֵ�� Task<int> ��Ϊ���ص���һ����������. 
        //  - ��������������� "Async" ��β.
        async Task<int> AccessTheWebAsync()
        {
            // ����Ҫ���System.Net.Http������������client
            var client = new System.Net.Http.HttpClient();

            // GetStringAsync ���� Task<string>. ����ζ�ŵ�Task�����ȴ�֮�� 
            // �㽫�õ�һ��string (urlContents).
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

            // �������һЩ�������� GetStringAsync ����ֵ�Ĳ���.
            //DoIndependentWork();

            // await ���������˵�ǰ����AccessTheWebAsync. 
            //  - AccessTheWebAsync ֱ��getStringTask��ɺ�Ż����. 
            //  - ͬʱ, ����Ȩ������ AccessTheWebAsync �ĵ�����. 
            //  - ����Ȩ����getStringTask��ɺ�黹��AccessTheAsync.  
            //  - await������ȡ��getStringTask�з��ص�string���. 
            string urlContents = await getStringTask;

            // return�������ָ��һ�����������
            // ����AccessTheWebAsync�����յ�һ������ֵ�ĳ���. 
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
