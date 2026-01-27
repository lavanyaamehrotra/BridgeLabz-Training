class Program{
    static void Main(){
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();   // warning
        api.NewFeature();
    }
}
