using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XuanThuLab
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sắc
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }
    public class  Brand {
    public string Name {set; get;}
    public int ID {set; get;}
}
    public class LearnLinQ
    {
        static void Main(string[] args)
        {
            var brands = new List<Brand>() {
    new Brand{ID = 1, Name = "Công ty AAA"},
    new Brand{ID = 2, Name = "Công ty BBB"},
    new Brand{ID = 4, Name = "Công ty CCC"},
};

            var products = new List<Product>()
{
    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
};


            ////lay ra san pham gia 400
            ////query
            //var query = from p in products
            //            where p.Price == 400
            //            select p;
            //foreach (var product in query)
            //{
            //    Console.WriteLine(product);
            //}

            ////select
            //var p1 = products.Select(
            //    (p) =>
            //    {
            //        return p.Price == 400;
            //    }
            //);
            //foreach (var item in p1)
            //{
            //    Console.WriteLine(item);
            //}

            ////where
            //var exWhere = products.Where(
            //        (p) =>
            //        {
            //            return p.Price >= 200;
            //        }
            //    );
            //foreach (var item in exWhere)
            //{
            //    Console.WriteLine(item);
            //}


            ////select many
            //var exSelectMany = products.SelectMany(
            //    (p) =>
            //    {
            //        return p.Colors;
            //    }
            //    );
            //foreach (var item in exSelectMany)
            //{
            //    Console.WriteLine(item);
            //}

            //min,max, sum , average => đối với các mảng số
            //
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(numbers.Where(p => p > 5).Sum());
            Console.WriteLine(products.Min(p => p.Price));


            //join
            var exJoin = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
            {
                return new
                {
                    Ten = p.Name,
                    ThuongHieu = b.Name
                };
            });
            foreach (var item in exJoin)
            {
                Console.WriteLine(item);
            }

            //group join
            var exGroupJoin = products.GroupJoin(brands, p => p.Brand, b => b.ID, (p, b) =>
            {
                return new
                {
                    cacSanPham = p.Name,
                    thuongHieu = b
                };
            });
            foreach (var item in exGroupJoin)
            {
                Console.WriteLine(item.cacSanPham);
                foreach (var item2 in item.thuongHieu)
                {
                    Console.WriteLine(item2.Name);
                }
            }

            //take

            products.Take(3).ToList().ForEach(p => Console.WriteLine(p));

            //skip
            products.Skip(3).ToList().ForEach(p => Console.WriteLine(p));

            //OderBy (tang dan ) , OderByDescending

            products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));


            //reverse
            products.Reverse();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            //groupby
            var exGroupBy = products.GroupBy(p => p.Price);
            foreach (var item in exGroupBy)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }

            //distinct
            products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(p => Console.WriteLine(p));


            // Single // Nếu có nhiều hơn 1 giá trị trả về thì hàm lỗi/ Không có giá trị nào trả về cũng lỗi
            var exSingle = products.Single(
                    p => p.Price == 600
                );
            Console.WriteLine(exSingle);

            //SingleOrDefault // Nếu có nhiều hơn 1 giá trị trả về thì hàm lỗi
            var exSingleOrDefault = products.SingleOrDefault(
                    p => p.Price == 600
                );
            Console.WriteLine(exSingleOrDefault);


            //any // kiểm tra collection xem có giá nào == 600 hay không (Trả về true nếu có và false ngược lại)
            var exAny = products.Any(p => p.Price == 600);
            Console.WriteLine($"Demo Any :" + exAny);

            //All //Kiểu tra collection sao cho tất cả các record phải thuộc deligate bên dưới ( trả về true nếu có và false nếu ngược lại )
            var exAll = products.All(p => p.Price > 200);
            Console.WriteLine($"Demo All : " + exAll);

            //Count
            //Có 2 cách dùng
            //Cách 1:
            //không có tham số auto đếm tất cả các giá trị trong collections
            var exCount1 = products.Count();
            Console.WriteLine($"Demo Count1 :" + exCount1);
            //tham số là 1 delegate
            var exCount2 = products.Count(p => p.Price > 300);
            Console.WriteLine($"Demo Count2 :" + exCount2);


            //Ex: In ra ten san pham, thuong hieu , co gia (300-400)
            //gia giam dan
            var exExcercise = products
           .Where(p => p.Price >= 300 && p.Price <= 400)
           .OrderByDescending(p => p.Price)
           .Join(brands, p => p.Brand, b => b.ID,
           (p, b) =>
           {
               return new
               {
                   Ten = p.Name,
                   ThuongHieu = b.Name,
                   Gia = p.Price
               };

           }
           );
           
            foreach ( var item in exExcercise)
            {
                Console.WriteLine(item.Ten + " " + item.Gia + " " + item.ThuongHieu);
            }

            // LINQ

            var exName = from Product in products
                         select Product.Name;
            foreach ( var item in exName )
            {
                Console.WriteLine(item);
            }
            //ex2
            var exName1 = from Product in products
                         select new
                         {
                             Ten = Product.Name,
                             Gia = Product.Price
                         };
            foreach (var item in exName1)
            {
                Console.WriteLine(item);
            }

            //ex3
            var ex3 = from product in products
                      from color in product.Colors
                      where product.Price >= 300 && color == "Xanh"
                      orderby product.Price descending
                      select new
                      {
                          Ten = product.Name,
                          Gia = product.Price,
                          Mau = product.Colors
                      };
            foreach(var item in ex3)
            {
                Console.WriteLine($"{item.Ten,15}{item.Gia,10}");
                foreach (var item1 in item.Mau)
                {
                    Console.WriteLine($"{item1,8}");
                }
            }
            //ex4 group buy . Nhóm sản phẩm theo giá

            var qr = from p in products
                     group p by p.Price;

            qr.ToList().ForEach(
                item =>
                {
                    Console.WriteLine(item.Key);
                    item.ToList().ForEach(
                        p => Console.WriteLine(p)
                        );
                }
                );


        }
    }
}
