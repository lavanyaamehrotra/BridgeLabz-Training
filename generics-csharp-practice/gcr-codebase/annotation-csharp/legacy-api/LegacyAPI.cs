using System;
public class LegacyAPI{
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature(){
        Console.WriteLine("Old feature executed");
    }
    public void NewFeature(){
        Console.WriteLine("New feature executed");
    }
}
