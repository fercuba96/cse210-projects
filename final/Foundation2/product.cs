public class Product
{   private string _nameofproduct= "";
    private string _productid = "";
    private int _priceofproduct = 0;
    protected int _quantityofproduct = 0;
    protected int _totalpriceofproduct = 0 ;

    private List<string> Listoforders = new List<string>();

    private static int _totalPriceOfOrders = 0;

    public static int TotalPriceOfOrders => _totalPriceOfOrders;

    public void AddCustomerOrder(string newOrder)
    {
        Listoforders.Add(newOrder);
        _totalPriceOfOrders += _totalpriceofproduct;
    }


    public void DisplayOrderList()
    {
        Console.WriteLine("List of orders:");
        for (int i = 0; i < Listoforders.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Listoforders[i]}");
        }
    }

    public string Getnameofproduct()
    {
        return _nameofproduct;
    }
    
    public void Setnameofproduct(string nameofproduct)
    {
        _nameofproduct = nameofproduct;
    }


    public string Getproductid()
    {
        return _productid;
    }

    public void Setproductid( string productid)
    {
        _productid = productid;
    }

    public int Getpriceofproduct()
    {
        return _priceofproduct ;
    }

    public void Setpriceofproduct(int priceofproduct)
    {
        _priceofproduct = priceofproduct;

    }

    public void Getquantity()

    {
       Console.WriteLine("How many of this product you would need?");

    }

    public string DisplayDetails()

    {
        return $"\nThis product is {_nameofproduct}! \nConsider the price: \n{_priceofproduct} dollars";
    }

    public int Getquantityint()
    {
        return _quantityofproduct;
    }

    public void Setquantitydisplay(int quantityofproduct)
    {
        _quantityofproduct = quantityofproduct;

    }

    public void Settotalpriceofproduct(int totalpriceofproduct)
    {
        _totalpriceofproduct = totalpriceofproduct;

    }

    public string Displayresultofeachorder()

    {
        return $"\nYou have choose this time {_nameofproduct}\nProduct ID: {_productid}\nPrice of product: {_priceofproduct}\nQuantity of product: {_quantityofproduct}\nTotal price for this product: {_totalpriceofproduct}\n";
    }

public void Chooseproduct()
    {  

         Console.WriteLine("Enter your products. Type 'exit' to finish.");
         while (true)
          { 
            Console.Write("Enter exit to close program\nOr Enter a kind of product: \n1.Tooth Paste\n2.Pack of cookies\n3.Burgers\n\n");
            string Kindofproduct = Console.ReadLine();
            if (Kindofproduct.ToLower() == "exit")
                        break;
        
            if (int.TryParse(Kindofproduct, out int Kindofproductnumber))
            {

               if (Kindofproductnumber == 1)
                  {        
                    Product product1 = new Product();
                    product1.Setnameofproduct("Tooth paste ");
                    product1.Setproductid("0091");
                    product1.Setpriceofproduct(80);
                    Console.WriteLine(product1.DisplayDetails());
                    product1.Getquantity();
                    string quantityofproduct1 = Console.ReadLine();

                   if (int.TryParse(quantityofproduct1, out int quantityNumber))
                    {
                   product1.Setquantitydisplay(quantityNumber);
                   product1.Settotalpriceofproduct(quantityNumber*80);
                   Console.WriteLine(product1.Displayresultofeachorder());
                   AddCustomerOrder(product1.Displayresultofeachorder());
        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for quantity. Please enter a valid number.");
                    }
                   }   
            if ( Kindofproductnumber == 2)
              {      
                Product product2 = new Product();
                    product2.Setnameofproduct("Pack of cookies");
                    product2.Setproductid("0092");
                    product2.Setpriceofproduct(30);
                    Console.WriteLine(product2.DisplayDetails());
                    product2.Getquantity();
                    string quantityofproduct2 = Console.ReadLine();

                   if (int.TryParse(quantityofproduct2, out int quantityNumber))
                    {
                   product2.Setquantitydisplay(quantityNumber);
                   product2.Settotalpriceofproduct(quantityNumber*30);
                   Console.WriteLine(product2.Displayresultofeachorder());
                   AddCustomerOrder(product2.Displayresultofeachorder());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for quantity. Please enter a valid number.");
                    }
               }
               if (Kindofproductnumber == 3)
              {      
                Product product3 = new Product();
                    product3.Setnameofproduct("Burgers");
                    product3.Setproductid("0093");
                    product3.Setpriceofproduct(50);
                    Console.WriteLine(product3.DisplayDetails());
                    product3.Getquantity();
                    string quantityofproduct3 = Console.ReadLine();

                   if (int.TryParse(quantityofproduct3, out int quantityNumber))
                    {
                   product3.Setquantitydisplay(quantityNumber);
                   product3.Settotalpriceofproduct(quantityNumber*50);
                   Console.WriteLine(product3.Displayresultofeachorder());
                   AddCustomerOrder(product3.Displayresultofeachorder());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for quantity. Please enter a valid number.");
                    }
               //      AddGoalDetails(checklistgoal1.GetStringRepresentation());
                     }
                 
                
                else 
                {
                    Console.WriteLine("Place a valid number.");
                }     
       
                    }
            Console.WriteLine($"\nTotal Price of Orders: {_totalPriceOfOrders}"); 
            }
            
            }

    

}
