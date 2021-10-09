namespace Ex1_2
{
    class Person
    {
        public string Name;
        public double Hour;
        public double Money;

        public Person(string name, double hour, double money)
        {
            Name = name;
            Hour = hour;
            Money = money;
        }

        override public string ToString()
        {
            return string.Format("Họ tên: {0}, Số giờ thuê: {1}, Thành tiền: {2}", Name, Hour, Money);
        }
    }
}
