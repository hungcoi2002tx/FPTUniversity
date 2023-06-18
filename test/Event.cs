

namespace test
{
    delegate void SuKienNhapSo(int x);
    class UserInput
    {
        public SuKienNhapSo suKienNhapSo { set; get; }
        public event SuKienNhapSo sukiennhapso;
        public void Input()
        {
            do
            {
                Console.WriteLine("Nhap vao so nguyen:");
                String s = Console.ReadLine();
                int i = Int32.Parse(s);
                //phat su kien
                suKienNhapSo?.Invoke(i);
            } while (true);
        }
    }

    

            
}
