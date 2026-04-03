using System.Reflection;
using System.Text;
public static class JsonSerializer{
    public static string ToJson(object obj){
        StringBuilder sb = new StringBuilder("{");
        var fields = obj.GetType().GetFields();
        foreach (var field in fields){
            var attr = field.GetCustomAttribute<JsonFieldAttribute>();
            if (attr != null){
                sb.Append($"\"{attr.Name}\":\"{field.GetValue(obj)}\",");
            }
        }
        sb.Length--;
        sb.Append("}");
        return sb.ToString();
    }
}
