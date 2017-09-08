using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Index
{
    /*
     * 1.class
     * 2.public
     * 3.private 
     * 4.protected
     * 5.abstract
     * 6.virtual
     * 7.base
     * 8.override
     * 9.delegate
     * 10.event
     * 11.interface
     * 12.属性;
     * 13.索引器;
     * 14.
     */
}
namespace Demo
{   
    interface Inter_T_I                        //继承接口的子类必须对接口的成员函数进行初始化,接口除了字段,都可以申明;
    {
        void Fun_Interface();                  //函数;
        int GetNum { get; set; }               //属性;
        string this[int index]{get;set;}       //索引器;

    }
    abstract class C_T_Class//abstract:加以修饰的话,对该类进行继承的了,必须对该类的未实例化函数进行实例化,也就是必须对父类的函数进行定义,而被声明为abstract的类,不能进行实例化;
    //sealed class C_T_Class//sealed关键字使其他类无法继承该类;
    {
        virtual protected void Fun_sealed() { }//该函数用于测试函数的sealed关键字;
        //访问级别//
        public    void Fun_0()           { }   //public为公共访问级别,在任何地方都可以使用Fun_0，子类继承后,子类对该函数的权限为public;
        private   void Fun_1()           { }   //private为私有访问级别,在类内部的函数可以使用Fun_1,子类继承后,将访问不到该函数,也就是不进行继承;
        protected void Fun_2()           { }   //protected为私有访问级别,在类内部的函数可以使用Fun_2,子类继承后,子类对该函数权限为private;
        //访问级别//
        abstract public void Fun_abstract();   //如果该函数未实例化,就一定要在子类实例化;
        virtual public void Fun_virtual(){ }   //虚函数,实现了多态性,在编译的时候确定对象的类型,进行联编,也就是编译时确定使用的函数;
    }
    class C_T_SonClass : C_T_Class,Inter_T_I
    {
        sealed protected override void Fun_sealed(){}    //密封该函数,让之后继承该类的子类不能使用重写该函数;
        public delegate void Fun_Delegate();             //委托,即为函数指针.使用Fun_Delegate可以创建函数指针;
        public Fun_Delegate Var_method;                  //使用method(),即可以调用绑定的委托,任何地方可以调用;
        public event Fun_Delegate Var_event_method;      //将上面的委托进行申明成事件,事件只能使用+=进行捆绑,-=进行解绑,事件只能在和类内部进行调用;
        public void Fun_event_T(){Var_event_method();}   //调用事件,事件可以绑定很多个;
        public C_T_SonClass():base()       {}            //base关键字为基类的构造函数;
        public override void Fun_abstract(){}            //该函数是上面抽象函数的重写,如果不在子类重写该函数,就会引发编译报错,不过一定要加override关键字表示重写;
        public override void Fun_virtual() {}            //在编译时根据类型,确定调用的是子类的函数还是基类的函数,不过一定要加override关键字表示重写;

        static void method_one(int a, int b, int c) {}
        static int method_two(int a, int b, int c) {return 0;}
        Action<int, int, int> Var_a = new Action<int, int, int>(method_one);
                                                         //void 类型的委托,参数为三个int参数;
        Func<int, int, int, int> Var_b = new Func<int, int, int, int>(method_two);
        //第一个参数为函数类型,参数为三个int参数;;
        public void Fun_TL_()
        {
            Var_a(10, 10, 10);
            Var_b(10, 10, 10);
        }                         //使用上面那两个委托;
        public int GetNum                                //继承的接口的属性;                      
        {
            get { return 0; }
            set { }
        }                                           
        public string this[int index]                    //继承接口的索引器;
        {
            get { return "hello"; }
            set { }
        }                 
        public void Fun_Interface(){ }                    //继承接口的函数;
    }
}
