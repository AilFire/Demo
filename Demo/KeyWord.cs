using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   class KeyWord_Use
    {
        //值类型//
        int int_a;                                       
        string string_a;                                
        bool bool_a;
        byte byte_a;
        //值类型//



        //异常处理//
        static void Fun_Use()
        {
            try
               {
                int num = 10;
                checked { int i=num+ 2147483647; };      //throw System.OverflowException//checked可以检测算数溢出;
               }
            catch(System.OverflowException)
               {
                //抓到异常进行处理;
               }
            finally
              {
                //用于清除 try 块中分配的任何资源;
                //以及运行任何即使在发生异常时也必须执行的代码;
                //控制总是传递给 finally 块;
                //与 try 块的退出方式无关;
                //catch 用于处理语句块中出现的异常;
                //而 finally 用于保证代码语句块的执行;
                //与前面的 try 块的退出方式无关;
              }

        }
        //异常处理//
    }

}
