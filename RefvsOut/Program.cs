// See https://aka.ms/new-console-template for more information

Customer customer1 = new Customer() { Id = 1, Name = "Burak", Surname = "YILDIRIM", Credit = 19823913, InterestRate = 0.02 };
double CreditAmount = 2500000;


LoanCalculator(ref customer1, CreditAmount);


static void LoanCalculator(ref Customer customer, double CreditAmount)
{
if (customer.Credit <= 1000000)
{
double price = CreditAmount * (1 + customer.InterestRate);
double amountOfInterest = price - CreditAmount;
Console.WriteLine("Faiz Tutarı = {0}", amountOfInterest);
}
else
{
customer.InterestRate = 0.015;

double discountetPrice = CreditAmount * (1 + customer.InterestRate);
double discountetAmount = discountetPrice - CreditAmount;
Console.WriteLine("Hesabınızda 1.000.000 TL'nin üzerinde tutar olduğu için faiz oranında indirim kazandınız");
Console.WriteLine("Ödeyecek faiz tutarı = {0}", discountetAmount);
}

}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Credit { get; set; }
    public double InterestRate { get; set; }
}