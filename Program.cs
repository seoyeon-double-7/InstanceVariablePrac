using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자바 스타일
            Product product1 = new Product();
            product1.name = "감자";
            product1.price = 2000;

            // C# 스타일
            Product product2 = new Product() { name = "고구마", price = 1000 };
            Product product3 = new Product() { name = "고구마", price = 1000 };
            Product product4 = new Product() { name = "고구마", price = 1000 };
            Product product5 = new Product() { name = "고구마", price = 1000 };

            // 클래스 변수 출력
            Console.WriteLine(Product.origin);
            Console.WriteLine(product1.name + "/" + + product1.price);
            Console.WriteLine(product1);

            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "배서연", grade = 3 });
            list.Add(new Student() { name = "배서연", grade = 3 });
            list.Add(new Student() { name = "배서연", grade = 3 });

            List<Student> list2 = new List<Student>
            {
                new Student(){ name = "배서연", grade=3},
                new Student(){ name = "배서연", grade=3},
                new Student(){ name = "배서연", grade=3}
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
