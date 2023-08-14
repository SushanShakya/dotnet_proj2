using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace sol26.Services;

public class TempDataStateManager : IStateManager
{

    ITempDataDictionary _data;

    public TempDataStateManager(ITempDataDictionary data)
    {
        _data = data;
    }

    public string GetString(string key)
    {
        return _data[key] as string ?? "";
    }

    public void SaveString(string key, string value)
    {
        _data[key] = value;
    }
}