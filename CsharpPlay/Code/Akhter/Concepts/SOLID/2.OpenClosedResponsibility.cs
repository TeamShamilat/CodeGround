namespace SOLID_Principles;
/*
key points:
1. Software entities such as modules, classes, functions, etc. should be open for extension, but closed for modification.
2. Functionalities should be added easily when new requirements come.
3. We should not modify the class/module until we find some bugs.

*/

//Without using the Open-Closed Principle 

public class InvoiceSheet
{
    /*Tomorrow, if one more Invoice Type comes into the picture then we need to modify the GetInvoiceDiscount() method
     logic by adding another else if block to the source code.
     As we are changing the source code for the new requirement, we are violating the Open-Closed principle */
    public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
    {
        double finalAmount = 0;
        if (invoiceType == InvoiceType.FinalInvoice)
        {
            finalAmount = amount - 100;
        }
        else if (invoiceType == InvoiceType.ProposedInvoice)
        {
            finalAmount = amount - 50;
        }
        return finalAmount;
    }
}

//With Open-Closed Principle 
/* As per the Open-Closed principle, Instead of MODIFYING, we should go for EXTENSION.
 If you want to follow the Open-Closed Principle in the above example,
 when a new invoice type needs to be added, then we need to add a new class and these classes inherited from base class. */
public class InvoiceSheetOCP
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount - 10;
    }
}
public class FinalInvoice : InvoiceSheetOCP
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 50;
    }
}
public class ProposedInvoice : InvoiceSheetOCP
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 40;
    }
}
public class OpenClosedResponsibility
{
    [Fact]
    public void OpenClosedResponsibilityTest()
    {
        var actual = 50;
        InvoiceSheet invoiceSheet = new InvoiceSheet();
        var expected = invoiceSheet.GetInvoiceDiscount(150, InvoiceType.FinalInvoice);
        Assert.Equal(actual, expected);
    }
}
public enum InvoiceType
{
    FinalInvoice,
    ProposedInvoice
}