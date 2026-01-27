using System.Reflection;
public class User{
    [MaxLength(10)]
    public string Username;
    public User(string username){
        FieldInfo field = typeof(User).GetField("Username");
        var attr = field.GetCustomAttribute<MaxLengthAttribute>();
        if (username.Length > attr.Length){
            throw new ArgumentException("Username exceeds max length");
        }
        Username = username;
    }
}
