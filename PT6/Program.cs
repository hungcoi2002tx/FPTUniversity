namespace PT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            Shop shop = new Shop();
            while (true)
            {
                Console.Write("Nhap lua chon cua ban: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        shop.addProduct();
                        break;
                    case 2:
                        shop.removeProduct();
                        break;
                    case 3:
                        shop.iterateProductList();
                        break;
                    case 4:
                        shop.searchProduct();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void menu()
        {
            Console.WriteLine("Product Management System");
            Console.WriteLine("Add new product");
            Console.WriteLine("Remove product");
            Console.WriteLine("Interate product list");
            Console.WriteLine("Search product");
            Console.WriteLine("Exit");
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        private int[] rate = new int[5];

        public int[] Rate
        {
            get { return rate ; }
            set { rate = value; }
        }


        public Product()
        {
        }

        public Product(string name, string description, double price, int[] rate)
        {
            Name = name;
            Description = description;
            Price = price;
            this.Rate = rate;
        }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            Rate = null;
        }

        public void viewInfo()
        {
            Console.WriteLine($"{Name} - {Description} - {Price}");

        }
    }

    public class Shop
    {
        List<Product> products = new List<Product>();
        public void addProduct()
        {
            Console.Write("Nhap ten san pham: ");
            String name = Console.ReadLine();
            Console.Write("Nhap mo ta san pham: ");
            String description = Console.ReadLine();
            double number;
            ValidatePrice(out number);
            Product p = new Product(name, description, number);

            products.Add(p);
        }

        public void removeProduct()
        {
            while (true)
            {
                Console.Write("Nhap ten san pham muon xoa: ");
                String name = Console.ReadLine();
                if (GetProductByName(name) != null)
                {
                    products.Remove(GetProductByName(name));
                    Console.WriteLine("XOA THANH CONG");
                    break;
                }
                else
                {
                    Console.WriteLine($"Khong thay san pham nao co ten la {name}");
                }
            }
        }

        public void ValidatePrice(out double number)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhập một số gia từ 0 đến 100: ");
                    number = Convert.ToDouble(Console.ReadLine());

                    if (number < 0 || number > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Số không hợp lệ. Vui lòng nhập lại.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Số không nằm trong phạm vi từ 0 đến 100. Vui lòng nhập lại.");
                }
            }
        }

        public Product GetProductByName(String name)
        {

            foreach (Product product in products)
            {
                if (product.Name.Equals(name))
                {
                    return product;
                }
            }
            return null;
        }

        public void iterateProductList()
        {
            Console.WriteLine("Duoi day la thong tin cac san pham: ");
            foreach (Product product in products)
            {
                product.viewInfo();
            }
        }

        public void searchProduct()
        {
            Console.WriteLine("Vui long nhap 2 so");
            Console.Write("Nhap so thu nhat: ");
            double number1;
            ValidatePrice(out number1);

            Console.Write("Nhap so thu hai: ");
            double number2;
            ValidatePrice(out number2);

            foreach (Product product in products)
            {
                if (product.Price > number1 && product.Price < number2)
                {
                    product.viewInfo();
                }
            }
        }
    }
}