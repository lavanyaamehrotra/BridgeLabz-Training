using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections;
class VotingSystem{
    static Dictionary<string, int> voteCount = new Dictionary<string, int>();
    static OrderedDictionary voteOrder = new OrderedDictionary();
    static SortedDictionary<int, List<string>> sortedResults = new SortedDictionary<int, List<string>>();
    static void Main(){
        CastVote("Lavanya");
        CastVote("Roshni");
        CastVote("Khushi");
        CastVote("Laviosa");
        CastVote("Lavii");
        CastVote("Roshii");
        Console.WriteLine("Voting Order (Insertion Order):");
        DisplayVoteOrder();
        Console.WriteLine("\nFinal Vote Count:");
        DisplayVoteCount();
        Console.WriteLine("\nResults Sorted By Votes:");
        DisplaySortedResults();
    }
    // Cast a vote
    static void CastVote(string candidate){
        // Track vote order
        voteOrder.Add(voteOrder.Count + 1, candidate);
        // Update vote count
        if (!voteCount.ContainsKey(candidate)){
            voteCount[candidate] = 0;
        }
        voteCount[candidate]++;
        UpdateSortedResults();
    }
    // Display vote order
    static void DisplayVoteOrder(){
        foreach (DictionaryEntry vote in voteOrder){
            Console.WriteLine($"Vote {vote.Key}: {vote.Value}");
        }
    }
    // Display vote count
    static void DisplayVoteCount(){
        foreach (var candidate in voteCount){
            Console.WriteLine($"{candidate.Key} : {candidate.Value} votes");
        }
    }
    // Update sorted results
    static void UpdateSortedResults(){
        sortedResults.Clear();
        foreach (var entry in voteCount){
            if (!sortedResults.ContainsKey(entry.Value)){
                sortedResults[entry.Value] = new List<string>();
            }
            sortedResults[entry.Value].Add(entry.Key);
        }
    }
    // Display sorted results
    static void DisplaySortedResults(){
        foreach (var entry in sortedResults){
            foreach (var candidate in entry.Value){
                Console.WriteLine($"{candidate} : {entry.Key} votes");
            }
        }
    }
}
