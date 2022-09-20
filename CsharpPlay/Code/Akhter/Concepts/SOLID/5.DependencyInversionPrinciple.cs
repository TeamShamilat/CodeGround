/*
Key points:
1.  The DIP states that high-level modules/classes should not depend on low-level modules/classes.
2.  Both should depend upon abstractions.
3.  Abstractions should not depend on details. Details should depend on abstractions

*/
public interface ICustomerDataAccess
{
    string GetCustomerName(int id);
}
public class CustomerDataAccess : ICustomerDataAccess
{
    public string GetCustomerName(int id)
    {
        return "Dummy Customer";
    }
}
public class DataAccessFactory
{
    public static ICustomerDataAccess GetCustomerDataAccessObj()
    {
        return new CustomerDataAccess();
    }
}
public class CustomerBusinessLogic
{
    ICustomerDataAccess _custDataAccess;

    public CustomerBusinessLogic()
    {
        _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
    }

    public string GetCustomerName(int id)
    {
        return _custDataAccess.GetCustomerName(id);
    }
}
public class DependencyInversionPrinciple
{
    [Fact]
    public void DependencyInversionPTest()
    {
        CustomerBusinessLogic customerBusinessLogic = new CustomerBusinessLogic();
        Assert.Equal(customerBusinessLogic.GetCustomerName(33),"Dummy Customer");
    }
}