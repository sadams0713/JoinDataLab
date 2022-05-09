namespace JoinDataLab
{ 

public class Program
{
    public static void Main()
    {
        List<Order> Orders = new List<Order>();

        Order a = new Order("Acme Hardware", "Mouse", 25, 3);
        Order b = new Order("Acme Hardware", "Keyboard", 45, 2);
        Order c = new Order("Falls Reality", "Macbook", 800, 2);
        Order d = new Order("Julies Morning Diner", "Ipad", 525, 1);
        Order e = new Order("Julies Morning Diner", "Card Reader", 45, 1);

        Orders.Add(a);
        Orders.Add(b);
        Orders.Add(c);
        Orders.Add(d);
        Orders.Add(e);

        Orders.ToArray();
        decimal runningtotal = 0;
        string lastcustomer = "";
        foreach (Order currentcustomer in Orders)
        {

            decimal customertotal = currentcustomer.Quantity * currentcustomer.Price;
            string thiscustomer = currentcustomer.CustomerName;
            if (thiscustomer != lastcustomer)
            {
                lastcustomer = thiscustomer;

                Console.WriteLine();
                Console.WriteLine(currentcustomer.CustomerName);

                Console.WriteLine("Item: " + "\t\tPrice: " + "\t\tQuanity: " + "\tTotal: ");

                Console.WriteLine(currentcustomer.Item + "\t\t  " + currentcustomer.Price + "\t\t   " + currentcustomer.Quantity + "\t\t  " + customertotal);
                runningtotal = 0;

            }
            else
            {
                runningtotal = customertotal + runningtotal;
                Console.WriteLine(currentcustomer.Item + "\t  " + currentcustomer.Price + "\t\t   " + currentcustomer.Quantity + "\t          " + customertotal);
                Console.WriteLine();
            }

        }

    }
}
}