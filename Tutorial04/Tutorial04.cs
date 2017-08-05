using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 类、实例方法
/// 结构体的存储方式
/// 值类型与引用类型的传递
/// </summary>
namespace Tutorial03
{
    class Tutorial04
    {
        static void Main(string[] args)
        {
            School s;
            s.name = "汕头一中";//查看结构体在栈内存的存储方式
            s.location = "广东汕头";
            s.area = 38.5f;
            Person _072 = new Person("072", Person.Sex.Female);
            Person robert = new Person("Robert",Person.Sex.Male);
            _072.school = robert.school = s;
            robert.school.name = "汕头一中老校区";//结构体是值类型，所以传的是值而非引用
            robert.friend = _072;
            robert.friend.isDalao = true;//类是引用类型，所以传的是引用
            robert.SayHello();//调用实例方法
            _072.SayHello();
            //Person.SayHello();//不是静态方法，不能这样调用
            Console.Read();
        }
    }
    struct School
    {
        public string name;
        public string location;
        public float area;
        public School(string name,string location,float area)
        {
            this.name = name;
            this.location = location;
            this.area = area;
        }
    }
    class Person
    {
        public bool isDalao = false;
        public string name;
        public enum Sex
        {
            Male,Female
        }
        public Sex sex;
        public School school;
        public Person friend;
        public Person(string name,Sex sex)
        {
            this.name = name;
            this.sex = sex;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello!I'm " + name + ".");
        }
    }
}
