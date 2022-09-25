public class Visit
{

    private Customer name;
    private string date;
    private double serviceExpense;
    private double productExpense;

    public Visit(Customer name, string date)
    {
        this.name = name;
        this.date = date;
    }

    public string getCustomerName()
    {
        return name.getName();
    }

    public double getServiceExpense()
    {
        return serviceExpense;
    }

    public void setServiceExpense(double serviceExpense)
    {
        this.serviceExpense = this.serviceExpense + serviceExpense;
    }

    public double getProductExpense()
    {
        return productExpense;
    }

    public void setProductExpense(double productExpense)
    {
        this.productExpense = this.productExpense + productExpense;
    }

    public double? getTotalExpense()
    {
        return (serviceExpense - (serviceExpense * DiscountRate.getServiceDiscountRate(name.getMemberType()))) +
                (productExpense - (productExpense * DiscountRate.getProductDiscountRate(name.getMemberType())));

    }


    public string toString()
    {
        return "Visit{" +  "customer name=" + name.getName() +  ", customer member=" + name.isMember() + ", customer member type=" + name.getMemberType() +", date=" + date + ", serviceExpense=" + serviceExpense +", productExpense=" + productExpense +'}';
    }
}