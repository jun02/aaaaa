using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Threading;



namespace Console_Test
{
 
    delegate void dele(int a, int b);

    class Program
    {
  
        
        static void Main(string[] arg) {


            MainTest mt = new SubTest();

            mt.Print1("zzz");
            mt.print<int>(3);

            SubTest st = new SubTest();

            st.Print1("aa");
            st.print2(3, 3);

 
        }

    }

    class MainTest
    {
        public virtual void Print1(string msg) {
            Console.WriteLine(msg);
        }

        public void print<T>(T val) {
            Console.WriteLine(val);
        }
    }

    class SubTest : MainTest
    {
        public override void Print1(string msg) {
            Console.WriteLine("오바라이드" + msg);
        }

        public void print2(int a, int b) {
            print<int>(a + b);
        }
    }
    

}