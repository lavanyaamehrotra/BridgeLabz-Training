class CustomDictionary{
    private int[] keys;
    private string[] values;
    private int count;
    //custom dictionary
    public CustomDictionary(int size){
        keys = new int[size];
        values = new string[size];
        count = 0;
    }
    //add
    public void Add(int key, string value){
        for (int i = 0; i < count; i++){
            if (keys[i] == key){
                values[i] = value;
                return;
            }
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }
    //get
    public string Get(int key){
        for (int i = 0; i < count; i++){
            if (keys[i] == key){
                return values[i];
            }
        }
        return null;
    }
    //size
    public int Size(){
        return count;
    }
    public int GetKey(int index) => keys[index];
    public string GetValue(int index) => values[index];
}
