// See https://aka.ms/new-console-template for more information

public enum Color
{
    Red, Green, Blue
}

public enum Size
{
    Small, Medium, Large, Yuge
}

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Color = color;
        Size = size;
    }
}
public interface ISpecification<T>
{
    bool IsSatisfied(Product p);
}

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}

public class ColorSpecification : ISpecification<Product>
{
    private Color color;

    public ColorSpecification(Color color)
    {
        this.color = color;
    }

    public bool IsSatisfied(Product p)
    {
        return p.Color == color;
    }
}

public class SizeSpecification : ISpecification<Product>
{
    private Size size;

    public SizeSpecification(Size size)
    {
        this.size = size;
    }

    public bool IsSatisfied(Product p)
    {
        return p.Size == size;
    }
}

// combinator
public class AndSpecification<T> : ISpecification<T>
{
    private ISpecification<T> first, second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }

    public bool IsSatisfied(Product p)
    {
        return first.IsSatisfied(p) && second.IsSatisfied(p);
    }
}
public class ProductFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var i in items)
            if (spec.IsSatisfied(i))
                yield return i;
    }
}
class Program
{
    static void Main()
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        Product[] products = { apple, tree, house };
        var pf = new ProductFilter();
        Console.WriteLine("Green products (new):");
        foreach (var p in pf.Filter(products, new ColorSpecification(Color.Green)))
            Console.WriteLine($" - {p.Name} is green");

        Console.WriteLine("Large products");
        foreach (var p in pf.Filter(products, new SizeSpecification(Size.Large)))
            Console.WriteLine($" - {p.Name} is large");

        Console.WriteLine("Large blue items");
        foreach (var p in pf.Filter(products,
          new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))
        )
        {
            Console.WriteLine($" - {p.Name} is big and blue");
        }
    }
}

