using System;
public class BacktrackingEngine {
    private string realPassword;
    private bool found;
    private CharacterSet set;
    public BacktrackingEngine(string password){
        realPassword = password;
        found = false;
        set = new CharacterSet();
    }
    public void StartCracking(){
        found = false;
        Crack("", realPassword.Length);
    }
    private void Crack(string current, int n){
        if(found){
         return;
        }
        if(current.Length == n){
            Console.WriteLine("Trying: " + current);
            if(current == realPassword){
                Console.WriteLine("Password Found: " + current);
                found = true;
            }
        return;
        }
        foreach(char ch in set.chars){
            Crack(current + ch, n);
        }
    }
}

