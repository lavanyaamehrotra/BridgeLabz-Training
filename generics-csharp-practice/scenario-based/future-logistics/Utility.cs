using System;
using System.Text.RegularExpressions;
public class Utility{
    public bool ValidateTransportId(string transportId){
        if (Regex.IsMatch(transportId, "^RTS[0-9]{3}[A-Z]$")){
            return true;
        }
        Console.WriteLine($"Transport id {transportId} is invalid");
        Console.WriteLine("Please provide a valid record");
        return false;
    }
    public GoodsTransport ParseDetails(string input){
        string[] data = input.Split(':');
        string transportId = data[0];
        string transportDate = data[1];
        int rating = int.Parse(data[2]);
        string type = data[3];
        if (!ValidateTransportId(transportId)){
            return null;
        }
        if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase)){
            return new BrickTransport(transportId,transportDate,rating,float.Parse(data[4]),int.Parse(data[5]),float.Parse(data[6]));
        }
        else if (type.Equals("TimberTransport", StringComparison.OrdinalIgnoreCase)){
            return new TimberTransport(transportId,transportDate,rating,float.Parse(data[4]),float.Parse(data[5]),data[6],float.Parse(data[7]));
        }
        return null;
    }
}
