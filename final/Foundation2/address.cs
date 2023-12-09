public class Address

{
    private string streetaddress {get; set;}
    private string cityaddress {get; set;}
    private string stateandcountry {get; set;}
    
    public string GetAddressstring(string streetaddress, string cityaddress, string stateandcountry)
    {
       return $"\nAddress of customer: {streetaddress} in {cityaddress}\nLocated in:{stateandcountry}\n";
    }

}