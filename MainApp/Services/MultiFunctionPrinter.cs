using MainApp.Interfaces;

namespace MainApp.Services;

public class MultiFunctionPrinter : IMultiFunctionPrinter, IPrinter, IScanner, ICopy, IEmail
{
    public void CopyInBlackAndWhite()
    {
        throw new NotImplementedException();
    }

    public void CopyInColor()
    {
        throw new NotImplementedException();
    }

    public void PrintInBlackAndWhite()
    {
        throw new NotImplementedException();
    }

    public void PrintInColor()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }

    public void SendEmail(string to, string subject, string body)
    {
        throw new NotImplementedException();
    }
}
