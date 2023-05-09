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
            list.Add(new Student() { name = "일서연", grade = 1 });
            list.Add(new Student() { name = "이서연", grade = 2 });
            list.Add(new Student() { name = "삼서연", grade = 3 });
            list.Add(new Student() { name = "사서연", grade = 4 });
            list.Add(new Student() { name = "오서연", grade = 1 });
            list.Add(new Student() { name = "육서연", grade = 2 });

            List<Student> list2 = new List<Student>
            {
                new Student(){ name = "배서연", grade=3},
                new Student(){ name = "배서연", grade=2},
                new Student(){ name = "배서연", grade=1}
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // 리스트 안에 인스턴스 지우기
            foreach (var item in list)
            {
                if (item.grade == 3)
                {
                    list.Remove(item);
                }
            }

            for(int i=0; i<list.Count; i++)
            {
                if(list[i].grade == 3)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
