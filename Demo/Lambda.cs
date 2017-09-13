using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Xie_Bian_Ni_Bian
{
    class C_1 { }
    class C_2:C_1 { } 
    class C_T_Xie_Bian
    {
        delegate C_1 T_Xie_Bian();
        delegate void T_Ni_Bian(C_2 a);
        static C_2 t_XieBian() { return null; }
        static void t_NiBian(C_1 a) { }
        T_Xie_Bian X = new T_Xie_Bian(t_XieBian);                //协变,指的是,委托的返回是可以向下兼容的,返回值是子类类型,属于协变;
        T_Ni_Bian  Y = new T_Ni_Bian(t_NiBian);                  //逆变,指的是,委托的参数是可以向上兼容的,参数可以使父类的对象;
    }
}
namespace Demo
{
    class Lambda
    {
        delegate void Lambda_Tset();
        Lambda_Tset Lambda_T = delegate ()               //Lambda表达式;
        {
            Console.WriteLine("Lambda_Tset");
        };
 
    }
}
