// Order class
// The responsability of holding data about orders

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel = packingLabel +
                "\n" + $"Product Name: {product.GetName()}  - ProductId: {product.GetProductId()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel =
            $"\nCustomer name : {_customer.GetName()} \n Address : {_customer.GetAddress()}";
        return shippingLabel;
    }

    public Double CalculateTotalCost(){

        Double total = 0.0;
         foreach (Product product in _products)
        {
            total = total + product.GetPrice(); 
        }

        if(_customer.isUSACustomer()){
            total = total + 5;
        }else{
             total = total +  35;
        }

        return total;

    }
}
