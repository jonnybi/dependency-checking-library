namespace MyBaseLibrary
{
    public interface IMyToolClass
    {
        string Serialize<T>(T obj);

        T Deserialize<T>(string json);
    }
}