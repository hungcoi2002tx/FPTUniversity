

namespace test
{
    public abstract class AbstractClass
    {
        public abstract void Infomationnn();
    }

    public class implemental : AbstractClass,AbstractClass1
    {
        public void Infomationn1()
        {
            throw new NotImplementedException();
        }

        public override void Infomationnn()
        {
            Console.WriteLine("hungdz");
        }
    }
    public interface AbstractClass1
    {
        public abstract void Infomationn1();
    }
}
