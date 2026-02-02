using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
public class JsonService{
    // 1️. Create Student JSON
    public string CreateStudentJSON(){
        Student student = new Student{
            Name = "Lavanya",
            Age = 21,
            Subjects = new List<string> { "Maths", "Physics", "Chemistry" }
        };
        return JsonConvert.SerializeObject(student, Formatting.Indented);
    }

    // 2️. Convert Car to JSON
    public string ConvertCarToJSON(){
        Car car = new Car{
            Brand = "Honda",
            Model = "City",
            Year = 2022
        };
        return JsonConvert.SerializeObject(car, Formatting.Indented);
    }
    // 3️. Read JSON & Extract Fields
    public void ExtractFields(string json){
        JObject obj = JObject.Parse(json);
        Console.WriteLine("Name: " + obj["name"]);
        Console.WriteLine("Email: " + obj["email"]);
    }
    // 4️. Merge Two JSON Objects
    public JObject MergeJSON(string json1, string json2){
        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);
        obj1.Merge(obj2);
        return obj1;
    }
    // 5️. Validate JSON Using Schema
   public bool ValidateJSON(string json, string schemaJson){
    JSchema schema = JSchema.Parse(schemaJson);
    JObject obj = JObject.Parse(json);
    IList<ValidationError> errors;
    bool isValid = obj.IsValid(schema, out errors);
    return isValid;
   }
    // 6️. Convert List of Objects to JSON Array
    public string ConvertListToJSONArray(List<Student> students){
        return JsonConvert.SerializeObject(students, Formatting.Indented);
    }
    // 7️. Filter Records Where Age > 25
    public IEnumerable<JToken> FilterAge(string json){
    JArray array = JArray.Parse(json);
    return array.Where(x => x["age"] != null && (int)x["age"] > 25);
    }
}
