
/*
key Points:
1. The Interface Segregation Principle states that “Clients should not be forced to implement any methods they don’t use.
2. First, no class should be forced to implement any method(s) of an interface they don’t use.
3. Secondly, instead of creating large or you can say fat interfaces,
   create multiple smaller interfaces with the aim that the clients should only think about the methods that are of interest to them.
4. In ISP we have split big interface into  smaller interfaces. Each interface now having some specific purpose. 
*/

// without using the Interface Segregation Principle.

public interface IPrinterTasks
{
    string Print();
    string Scan(string ScanContent);
    string Fax(string FaxContent);
    string PrintDuplex(string PrintDuplexContent);
}

public class HPLaserJetPrinter : IPrinterTasks
{
    /* As you can see in the above HPLaserJetPrinter class the Fax and PrintDuplex methods are not required by the class but,
       still, it is implementing these two methods.
       This is violating the Interface Segregation Principle in C# as we are forcing the class to implement two methods that they don’t require.*/
    public string Print()
    {
        return "Print Done";
    }
    public string Scan(string ScanContent)
    {
        return "Scan content";
    }
    public string Fax(string FaxContent)
    {
        return "Fax content";
    }
    public string PrintDuplex(string PrintDuplexContent)
    {
        return "Print Duplex content";
    }
}

// Using the Interface Segregation Principle.
public interface IPrinterTask
{
    public string Print();
    public string Scan();
}

public interface IFaxTask
{
    public string FaxTask();
}
public interface IPrintDuplexTask
{
    public void PrintDuplexTask();
}

public class HPLaserJetPrinters : IFaxTask, IPrintDuplexTask
{
    public string FaxTask()
    {
        return "Fax Task";
    }
    public void PrintDuplexTask()
    {

    }
}

public class InterfaceSegregationPrinciple
{
    [Fact]
    public void WithoutISPTest()
    {
        HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
        var actual = "Print Done";
        var expected = hPLaserJetPrinter.Print();
        Assert.Equal(actual, expected);
    }
    [Fact]
    public void InterfaceSegregationPrincipleTest()
    {
        HPLaserJetPrinters expected = new HPLaserJetPrinters();
        var actual = "Fax Task";
        Assert.Equal(actual, expected.FaxTask());
    }
}