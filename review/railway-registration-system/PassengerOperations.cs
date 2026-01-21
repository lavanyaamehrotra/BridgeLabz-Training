using System;
using System.Collections.Generic;
public class PassengerOperations{
    // Sorting using Bubble Sort
    public static void SortByPNR(List<Passenger> passengers){
        for (int i = 0; i < passengers.Count - 1; i++){
            for (int j = 0; j < passengers.Count - i - 1; j++){
                if (passengers[j].PNR > passengers[j + 1].PNR){
                        var temp = passengers[j];
                        passengers[j] = passengers[j + 1];
                        passengers[j + 1] = temp;
                    }
                }
            }
        }
        // Searching using Linear Search by name
        public static Passenger SearchByName(List<Passenger> passengers, string name){
            //looping each passenger to find out the passenger by name
            foreach (var p in passengers){
                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)){
                    return p;
                }
            }
            return null;
        }
    }