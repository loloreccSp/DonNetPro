
namespace HomeWork4
{
    public class CreditCard
    {
        public int Money { get; set; }

        public CreditCard(int money)
        {
            Money = money;;      
        }

        public void Information()
        {
            Console.WriteLine($"On your account: {Money}");

        }

        public static CreditCard operator +(CreditCard money, CreditCard add)
            => new (money.Money + add.Money);

        public static CreditCard operator -(CreditCard money, CreditCard add)
            => new (money.Money - add.Money);


        public static bool operator >(CreditCard money, CreditCard add)
            => money.Money > add.Money;
        public static bool operator <(CreditCard money, CreditCard add)
            => money.Money > add.Money;
    }

    public class CardCVV
    {
        public int CVV { get; set; }

        public CardCVV(int cVV)
        {
            CVV = cVV;
        }

        public static bool operator ==(CardCVV mainCVV, CardCVV check)
            => mainCVV.CVV == check.CVV;
        public static bool operator !=(CardCVV mainCVV, CardCVV check)
            => mainCVV.CVV != check.CVV;
    }
}
