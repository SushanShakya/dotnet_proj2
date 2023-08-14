namespace sol26.Services;

public class HttpContextStateManager : IStateManager
{

    IHttpContextAccessor _accessor;

    public HttpContextStateManager(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public string GetString(string key)
    {
        Console.WriteLine("---- HttpContextStateManager");
        Console.WriteLine(_accessor);
        Console.WriteLine(_accessor.HttpContext);
        Console.WriteLine(_accessor.HttpContext.Items);
        foreach(var e in _accessor.HttpContext.Items.Keys)
        {
            Console.WriteLine(e);
        }

        return _accessor.HttpContext?.Items[key] as string ?? "";
    }

    public void SaveString(string key, string value)
    {
        Console.WriteLine("---- HTTP Context State Manager");
        Console.WriteLine(key);
        Console.WriteLine(value);
        Console.WriteLine(_accessor);
        Console.WriteLine(_accessor.HttpContext);
        _accessor.HttpContext.Items[key] = value;
        Console.WriteLine(_accessor.HttpContext.Items[key]);
    }
}