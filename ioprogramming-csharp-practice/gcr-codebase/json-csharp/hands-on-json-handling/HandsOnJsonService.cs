using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
public class HandsOnJsonService{
    // 1️. Read JSON and print all keys & values
    public void PrintKeysAndValues(string json){
        JObject obj = JObject.Parse(json);
        foreach (var pair in obj){
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
    // 2️.Convert list of C# objects into JSON array
    public string ConvertListToJsonArray(List<User> users){
        return JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);

    }
    // 3️. Filter JSON data (Age > 25)
    public IEnumerable<JToken> FilterUsersAbove25(string json){
    JArray array = JArray.Parse(json);
    return array.Where(x => x["age"] != null && (int)x["age"] > 25);
    }
    // 4.Validate email using JSON Schema
    public bool ValidateEmail(string json){
        string schemaJson = @"{
            'type':'object',
            'properties':{
                'email':{
                    'type':'string',
                    'pattern':'^[^@]+@[^@]+\\.[^@]+$'
                }
            },
            'required':['email']
        }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(json);
        IList<ValidationError> errors;
        return obj.IsValid(schema, out errors);
    }
    // 5️. Merge two JSON objects
    public JObject MergeJson(string json1, string json2){
        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);
        obj1.Merge(obj2);
        return obj1;
    }
    // 6️. Convert JSON to XML
    public XmlDocument ConvertJsonToXml(string json){
    return JsonConvert.DeserializeXmlNode(json, "Root")!;
    }
    // 7️. Convert CSV to JSON
    public JArray ConvertCsvToJson(string[] csvLines){
        JArray array = new JArray();
        foreach (var line in csvLines.Skip(1)){
            var values = line.Split(',');
            JObject obj = new JObject{
                ["name"] = values[0],
                ["age"] = values[1],
                ["email"] = values[2]
            };
            array.Add(obj);
        }
        return array;
    }
    // 8️. Generate JSON from database records (mock)
    public string GenerateJsonFromDatabase(){
        DataTable table = new DataTable();
        table.Columns.Add("Id");
        table.Columns.Add("Name");
        table.Columns.Add("Age");
        table.Rows.Add("1", "Lavanya", "21");
        table.Rows.Add("2", "Khushi", "22");
        return JsonConvert.SerializeObject(
    table,
    Newtonsoft.Json.Formatting.Indented);
    }
}