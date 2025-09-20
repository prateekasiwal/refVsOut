namespace refVsOut;

public class MainService
{
    private IMyService _myService;
    public MainService(IMyService myService)
    {
        this._myService = myService;
    }

    public void Run(string name)
    {
        _myService.MyName(name);
    }
}
