public class Sorter{
    // Bubble Sort 
    public void BubbleSort(User[] users){
        if (users == null){
            return;
        }
        for (int i = 0; i < users.Length - 1; i++){
            for (int j = 0; j < users.Length - i - 1; j++){
                if (users[j].Steps < users[j + 1].Steps){
                    User temp = users[j];
                    users[j] = users[j + 1];
                    users[j + 1] = temp;
                }
            }
        }
    }
}
