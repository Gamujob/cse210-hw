using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

public class Order
{
  private Customer _customer;
  private List<Product> _products;

  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }
  public void AddProduct(Product product)
  {
    _products.Add(product);
  }
  public double GetTotalCost()
  {
    double total = 0;
    foreach (Product product in _products)
    {
      total += product.GetTotalCost();
    }

    double shippingCost;
    // double shippingCost = _customer.LiveInUSA();
    if (_customer.LiveInUSA())
    {
      shippingCost = 5;
    }
    else
    {
      shippingCost = 35;
    }
    total += shippingCost;
    return total;
  }
  public string GetPackingLabel()
  {
    string label = "Packing Label\n";
    foreach (Product product in _products)
    {
      label += product.GetPackingInfo() + "\n";
    }
    return label.TrimEnd();
  }
  public string GetShippingLabel()
  {
    return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
  }
}