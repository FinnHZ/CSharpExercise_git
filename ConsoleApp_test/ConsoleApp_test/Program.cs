using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_test
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Reflection;

    public class MyClass
    {

        //    public static void Main()
        //    {

        //        // *** 1) Find the parameters of constructor through reflection!!!!!!!
        //        //NewClass nc = new NewClass();
        //        //Type t = nc.GetType();
        //        //ConstructorInfo[] ci = t.GetConstructors();


        //        //foreach (var c in ci)
        //        //{
        //        //    Console.WriteLine("Count:");
        //        //    ParameterInfo[] ps = c.GetParameters();

        //        //    foreach (ParameterInfo pi in ps)
        //        //    {
        //        //        Console.Write("    " + pi.ParameterType.ToString() + " --- " + pi.Name + ",");
        //        //        Console.WriteLine();
        //        //    }

        //        //};


        //        // *** 2) Create a obj dynamically through reflection!!!!!!!
        //        // 1.
        //        //Type t = typeof(NewClass);
        //        //Type[] pt = new Type[2];
        //        //pt[0] = typeof(string);
        //        //pt[1] = typeof(int);

        //        //ConstructorInfo ci = t.GetConstructor(pt);
        //        //object[] obj = new object[2] { "5", 6 };

        //        //object o = ci.Invoke(obj);
        //        //((NewClass)o).show();
        //        //Console.WriteLine(o.GetHashCode());

        //        ////2.
        //        //NewClass nc = new NewClass("5", 6);
        //        //nc.show();
        //        //Console.WriteLine(nc.GetHashCode());



        //        // *** 3) Use Activator to create a obj dynamically through reflection!!!!!!!
        //        //Type t = typeof(NewClass);

        //        //object[] obj = new object[2] { "/*hello*/", 0 };  //"world"

        //        //object o = Activator.CreateInstance(t, "grayworm", 1);   //"hi.baidu.com/grayworm"


        //        ////object o = Activator.CreateInstance(t, obj[0], obj[1]);

        //        ////object o = Activator.CreateInstance(t);


        //        ////Console.WriteLine(((NewClass)o).a);

        //        //((NewClass)o).show();


        //        // *** 4) look for the property of the class
        //        //NewClass nc = new NewClass();
        //        //Type t = nc.GetType();


        //        //Console.WriteLine("1)======================================");
        //        ////1.  
        //        //PropertyInfo[] pis = t.GetProperties();

        //        //foreach(PropertyInfo pi in pis)
        //        //{
        //        //    Console.WriteLine(pi.Name);
        //        //}
        //        //Console.WriteLine("2)======================================");
        //        ////2.
        //        //MethodInfo[] mis = t.GetMethods();

        //        //foreach(MethodInfo mi in mis)
        //        //{
        //        //    Console.WriteLine(mi.ReturnType + ": " + mi.Name);
        //        //}
        //        //Console.WriteLine("3)======================================");
        //        ////3.
        //        //FieldInfo[] fis = t.GetFields();

        //        //foreach(FieldInfo fi in fis)
        //        //{
        //        //    Console.WriteLine(fi.Name);
        //        //}

        //        // *** 5) Use reflection to generate object and get the properties

        //        ////1. reflection method=====================================
        //        //NewClass nc = new NewClass();    //Call constructor   
        //        //Type t = nc.GetType();
        //        //object obj = Activator.CreateInstance(t);   //Call constructor   

        //        ////Get the ID field
        //        //FieldInfo fi1 = t.GetField("a");
        //        ////Set the value of the ID field
        //        //fi1.SetValue(obj, "80");


        //        //////Get the b field
        //        ////FieldInfo fi2 = t.GetField("b");
        //        //////Set the value of the ID field
        //        ////fi2.SetValue(obj, 16);


        //        ////Get properties
        //        //PropertyInfo pi1 = t.GetProperty("Name");
        //        //PropertyInfo pi2 = t.GetProperty("Age");

        //        //pi1.SetValue(obj, "  Finn He  ");  //, null
        //        //pi2.SetValue(obj, 16);  //, null

        //        //// Get the method ---- show
        //        //MethodInfo mi = t.GetMethod("show");

        //        //mi.Invoke(obj, null);

        //        //Console.WriteLine("ttttttttttttt: " + nc.a);

        //        ////2. common instance method=====================================
        //        //NewClass nnnn = new NewClass();    //Call constructor   

        //        //nnnn.a = "80";


        //        //nnnn.Name = "  Finn He  ";
        //        //nnnn.Age = 16;

        //        //nnnn.show();

        //        //Console.WriteLine("sssssssssssss: " + nnnn.a);


        //        // !!!!***!!!! 6) test by myself: the whole process when we need to use reflection to create an insrance without type of target.
        //        //Q:  When we need to use reflection to create instance? 
        //        //A:  (1) we want to create a new instance && (2) we don't know the type of class / we know the name of class but we haven't refer the dll file/package.


        //        // step 1:
        //        Assembly ass = Assembly.Load("ConsoleApp_test");   // if we need to load .dll file, we should use LoadForm("dll file path")
        //                                                           // if we use System.Reflection.Assembly to do that, we should use LoadFile("dll file path"), and use:  object obj = assembly.CreateInstance("full name of class")


        //        // step 2:
        //        Type tt = ass.GetType("ConsoleApp_test.MyClass");   // GetTypes()
        //        //Type tn = tt.GetNestedType("NewClass");

        //        // step 3:
        //        Type[] ts = tt.GetNestedTypes();

        //        // step 4: Get all kinds of information we need for creating an instance (Assume we don't know the type of the aim before.)
        //        foreach (Type tn in ts) {
        //            // parameters--------------------m, n
        //            ConstructorInfo[] ci = tn.GetConstructors();


        //            foreach (ConstructorInfo c in ci)
        //            {
        //                ParameterInfo[] ps = c.GetParameters();
        //                foreach (ParameterInfo pi in ps)
        //                {
        //                    Console.WriteLine(pi);
        //                }
        //            };


        //            Console.WriteLine("******************************************");
        //            // properties--------------------Name, Age
        //            PropertyInfo[] prs = tn.GetProperties();
        //            foreach (PropertyInfo pri in prs)
        //            {
        //                Console.WriteLine(pri);
        //            };

        //            Console.WriteLine("******************************************");
        //            // fields--------------------a, b
        //            FieldInfo[] fs = tn.GetFields();
        //            foreach (FieldInfo fi in fs)
        //            {
        //                Console.WriteLine(fi);
        //            };

        //            Console.WriteLine("******************************************");
        //            // methods--------------------show....
        //            MethodInfo[] mes = tn.GetMethods();
        //            foreach (MethodInfo mei in mes)
        //            {
        //                Console.WriteLine(mei);
        //            };


        //            //test use, don't mind===================
        //            // members--------------------all the items in the NewClass
        //            Console.WriteLine("**************************************test:");
        //            MemberInfo[] tes = tn.GetMembers();
        //            foreach (MemberInfo te in tes)
        //            {
        //                Console.WriteLine(te);
        //            };
        //            //=======================================

        //        }


        //        Console.WriteLine("**************************************Create new insetance with refleciton information:");
        //        // The steps above can tell us all the information we need, so we can use them like below:
        //        Type nc = tt.GetNestedType("NewClass");

        //        object obj = Activator.CreateInstance(nc);

        //        FieldInfo f_use = nc.GetField("a");
        //        f_use.SetValue(obj, "80");

        //        PropertyInfo name_use = nc.GetProperty("Name");
        //        name_use.SetValue(obj, "Finn");

        //        PropertyInfo age_use = nc.GetProperty("Age");
        //        age_use.SetValue(obj, 16);

        //        MethodInfo m_use = nc.GetMethod("show");

        //        m_use.Invoke(obj, null);








        //        Console.ReadKey();
        //    }

        //    public class NewClass
        //    {
        //        public string a = "aaa";

        //        public int b = 999;
        //        public string Name { get; set; }
        //        public int Age { get; set; }

        //        public NewClass(string m, int n)
        //        {
        //            a = m;
        //            b = n;
        //        }

        //        public NewClass()
        //        {
        //            Console.WriteLine("Call the construction function");
        //        }

        //        public void show()
        //        {
        //            Console.WriteLine("Generate a obj successfully! " + a + b + this.Name + this.Age);
        //        }

        //    }






        //};


        class Student
        {

            private string code = "N.A";
            private string name = "not known";
            private int age = 0;

            // 声明类型为 string 的 Code 属性
            public string Code
            {
                get
                {
                    return code;
                }
                set
                {
                    code = value;
                }
            }

            // 声明类型为 string 的 Name 属性
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            // 声明类型为 int 的 Age 属性
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
            public override string ToString()
            {
                return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
            }
        }
        class ExampleDemo
        {
            public static void Main()
            {
                // 创建一个新的 Student 对象
                Student s = new Student();

                // 设置 student 的 code、name 和 age
                s.Code = "001";
                s.Name = "Zara";
                s.Age = 9;
                Console.WriteLine("Student Info: {0}", s);  //Call the ToString() automatically?
                // 增加年龄
                s.Age += 1;
                Console.WriteLine("Student Info: {0}", s.ToString());
                Console.ReadKey();
            }
        }
    }

}
