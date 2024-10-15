using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ExperimentalShell.Utils;

public static class JsonConverterUtil
{
    public static string ConvertObjectToJson(object jsonObject)
    {
        return JsonConvert.SerializeObject(jsonObject);
    }

    public static T? GetObjectFromJson<T>(string key)
    {
        return key == null ? default : JsonConvert.DeserializeObject<T>(key);
    }

    public static ObservableCollection<T>? GetListFromJson<T>(string key)
    {
        return key == null ? default : JsonConvert.DeserializeObject<ObservableCollection<T>>(key);
    }
}
