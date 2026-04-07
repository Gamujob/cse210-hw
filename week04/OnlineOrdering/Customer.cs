using System.Net.Sockets;

public class Customer
{
  private string _customerName;
  private Address _address;

  public Customer(string customerName, Address address)
  {
    _customerName = customerName;
    _address = address;
  }

  public bool LiveInUSA()
  {
    
    return _address.IsInUSA();
  }
  // public string DisplayCustomer()
  // {
  //   return $"{_customerName} {_address}";
  // }
  public string GetCustomerName()
  {
    return _customerName;
  }
  public string GetCustomerAddress()
  {
    return _address.GetFullAddress();
  }
}