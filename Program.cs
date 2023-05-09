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

            // 멤버 변수
            Console.WriteLine(Product.origin);
            Console.WriteLine(product1.name + "/" + + product1.price);
            Console.WriteLine(product1);
        }
    }
}
