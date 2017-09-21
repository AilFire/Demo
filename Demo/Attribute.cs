using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Index
{
//1.Attribute;
}
namespace Demo
{
    [AttributeUsage(AttributeTargets.All,/*使用特性的途径*/Inherited = true,/*是否允许被继承;*/AllowMultiple =true)]//AllowMultiple获取或设置一个布尔值，该值指示能否为一个程序元素指定多个指示属性实例
    class DemoAttribute:Attribute   //特性,使用的时候直接使用名字Demo,特性会自动补全;
    {
        DemoAttribute() { }
    }
}
