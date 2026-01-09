using System;
using System.Collections.Generic;

// Custom hash map implementation
class CustomHashMap{
    class Node{
        public int key, value;
        public Node next;
    }

    Node[] arr = new Node[10];

    // Compute hash index
    int Hash(int key){
        return key % 10;
    }

    // Insert or update key
    void Put(int key, int value){
        int idx = Hash(key);
        Node temp=arr[idx];

        while (temp != null)
        {
            if (temp.key == key)
            {
                temp.value=value;
                Console.WriteLine("Value updated");
                return;
            }
            temp=temp.next;
        }
        Node node = new Node { key = key, value = value, next = arr[idx] };
        arr[idx] = node;
        Console.WriteLine("Key inserted");
    }

    // Retrieve value by key
    int Get(int key)
    {
        int idx = Hash(key);
        Node temp = arr[idx];

        while (temp != null)
        {
            if (temp.key == key)
            {
                return temp.value;
            }
            temp = temp.next;
        }

        return -1;
    }

    // Remove key from map
    public void Delete(int key)
    {
        int idx=Hash(key);
        Node temp=arr[idx];
        Node prev=null;

        while (temp != null)
        {
            if (temp.key == key)
            {
                if (prev == null)
                {
                    arr[idx]=temp.next;
                }
                else
                {
                    prev.next=temp.next;
                }
                Console.WriteLine("Key deleted");
                return;
            }

            prev=temp;
            temp=temp.next;
        }

        Console.WriteLine("Key not found");
    }

    // Main demonstration method
    static void Main(string[] args)
    {
        CustomHashMap map = new CustomHashMap();

        Console.Write("Enter number of entries: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            map.Put(key, value);
        }

        Console.Write("Enter key to update: ");
        int updateKey=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new Value: ");
        int valnew=Convert.ToInt32(Console.ReadLine());
        map.Put(updateKey,valnew);

        // DELETE
        Console.Write("Enter key to delete: ");
        map.Delete(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Enter key to search: ");
        int result = map.Get(Convert.ToInt32(Console.ReadLine()));

        if (result == -1)
        {
            Console.WriteLine("Key not found");
        }
        else
        {
            Console.WriteLine("Value: " + result);
        }
    }
}