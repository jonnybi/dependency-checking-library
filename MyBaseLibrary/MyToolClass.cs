using Newtonsoft.Json;

namespace MyBaseLibrary
{
    public class MyToolClass : IMyToolClass
    {
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
