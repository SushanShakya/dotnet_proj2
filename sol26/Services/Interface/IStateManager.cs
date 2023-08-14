namespace sol26.Services;


public interface IStateManager
{
    public void SaveString(string key, string value);

    public string GetString(string key);
}