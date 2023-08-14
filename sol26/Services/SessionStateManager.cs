namespace sol26.Services;

public class SessionStateManager : IStateManager
{

    IHttpContextAccessor _accessor;

    public SessionStateManager(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public string GetString(string key)
    {
        return _accessor.HttpContext?.Session.GetString(key) ?? "";
    }

    public void SaveString(string key, string value)
    {
        Console.WriteLine("---- Saving Key Value Pair inside Seession state ");
        Console.WriteLine(key);
        Console.WriteLine(value);
        Console.WriteLine(_accessor);
        Console.WriteLine(_accessor.HttpContext);
        _accessor.HttpContext?.Session.SetString(key, value);
    }
}