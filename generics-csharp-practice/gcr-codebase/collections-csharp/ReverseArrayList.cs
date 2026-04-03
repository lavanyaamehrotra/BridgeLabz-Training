using System;
using System.Collections;
class ReverseArrayList{
    static void Main(){
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        int left = 0;
        int right = list.Count - 1;
        while (left < right){
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
        Console.WriteLine("Reversed ArrayList:");
        foreach (var item in list){
            Console.Write(item + " ");
        }
    }
}
