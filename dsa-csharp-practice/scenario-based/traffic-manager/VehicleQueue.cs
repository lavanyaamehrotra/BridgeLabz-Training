using System;
using System.Collections.Generic;
//Manages vehicles waiting to enter the roundabout
class VehicleQueue{
    private Queue<string> queue;
    private int capacity;
    public VehicleQueue(int capacity){
        this.capacity=capacity;
        queue=new Queue<string>();
    }
    //Add vehicle to the queue
    public void Enqueue(string vehicleNumber){
        if (queue.Count == capacity){
            Console.WriteLine("cannot add more vehicles.");
            return;
        }
        queue.Enqueue(vehicleNumber);
        Console.WriteLine($"Vehicle {vehicleNumber} added to the waiting queue");
    }
    //Remove vehicle  from the queueu
    public string Dequeue(){
        if (queue.Count == 0){
            Console.WriteLine("No vehicle in waiting");
            return null;
        }
        return queue.Dequeue();
    }
    //Print Queue
    public void PrintQueue(){
     if (queue.Count == 0){
        Console.WriteLine("Waiting queue is empty.");
        return;
    }
    Console.Write("Waiting Queue: ");
    foreach (string v in queue){
        Console.Write(v + " ");
    }
    Console.WriteLine();
    }
}