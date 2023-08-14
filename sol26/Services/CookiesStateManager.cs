namespace sol26.Services;

public class CookiesStateManager : IStateManager
{
    HttpResponse _response;
    HttpRequest _request;

    public CookiesStateManager(HttpResponse response, HttpRequest request)
    {
        _response = response;
        _request = request;
    }

    public string GetString(string key)
    {
        return _request.Cookies[key] ?? "";
    }

    public void SaveString(string key, string value)
    {
        var options = new CookieOptions();
        options.Expires = DateTime.Now.AddDays(1);
        options.Path = "/";
        _response.Cookies.Append(key, value, options);
    }
}