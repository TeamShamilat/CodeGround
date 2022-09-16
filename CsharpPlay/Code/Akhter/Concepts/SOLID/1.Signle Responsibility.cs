namespace SOLID_Principles;
/**
   Key Points:
1. The SOLID Design Principles in C# are the design principles that help us to solve most of the software design problems.
2. Solid Principles are SRP,OCP,LSP,ISP,DIP.
3. The Single Responsibility Principle in C# states that “Each software module or class should have only one reason to change“.
4. In other words, we can say that each module or class should have only one responsibility to do.
5. So, with the help of SRP in C#, the classes become smaller and cleaner and thus easier to maintain.

**/

// Without using Single Responsibility Principle 
    public class Invoices
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                MailSender mailMessage = new MailSender();
                this.SendInvoiceEmail();
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendInvoiceEmail( )
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }

//using Single Responsibility Principle 
public interface ILogger{
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
}

public class Logger:ILogger{
    public Logger(){

    }
     public void Info(string info)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }
        public void Debug(string info)
        {
            // here we need to write the Code for Debug information into the ErrorLog text file
        }
        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
        }
}
public class MailSender{
  
        public string? EMailFrom { get; set; }
        public string? EMailTo { get; set; }
        public string? EMailSubject { get; set; }
        public string? EMailBody { get; set; }
         public void SendEmail()
        {
        }
}
 public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        private ILogger fileLogger;
        private MailSender emailSender;
        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }
        public string AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method Start");
                emailSender.EMailFrom = "emailfrom@xyz.com";
                emailSender.EMailTo = "emailto@xyz.com";
                emailSender.EMailSubject = "Single Responsibility Princile";
                emailSender.EMailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
                return emailSender.EMailFrom;
                
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
            return "null";
        }
        public void DeleteInvoice()
        {
            try
            {
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }

public class SingleReponsiblityPrinciple
{
    [Fact]
    public void SingleResponsibiltyTest()
    {
        // var actualEmailFrom = "emailfrom@xyz.com";
        Invoice invoice = new Invoice();
        var actualFrom = invoice.AddInvoice();
       Assert.Equal(actualFrom,"emailfrom@xyz.com");
    }
}

