using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
class Program{
    static void Main(){
        ProcessJson("ipl.json", "censored_ipl.json");
        ProcessCsv("ipl.csv", "censored_ipl.csv");
        Console.WriteLine("IPL Data Censorship Completed Successfully!");
    }
    // ---------------- JSON ----------------
    static void ProcessJson(string inputPath, string outputPath){
        var json = File.ReadAllText(inputPath);
        var matches = JsonConvert.DeserializeObject<List<IPLMatch>>(json);
        foreach (var match in matches){
            string maskedTeam1 = Censorship.MaskTeamName(match.team1);
            string maskedTeam2 = Censorship.MaskTeamName(match.team2);
            match.team1 = maskedTeam1;
            match.team2 = maskedTeam2;
            match.winner = Censorship.MaskTeamName(match.winner);
            match.player_of_match = "REDACTED";
            match.score = match.score.ToDictionary(
                k => Censorship.MaskTeamName(k.Key),
                v => v.Value
            );
        }
        File.WriteAllText(outputPath,JsonConvert.SerializeObject(matches, Formatting.Indented));
    }
    // ---------------- CSV ----------------
    static void ProcessCsv(string inputPath, string outputPath){
        var lines = File.ReadAllLines(inputPath).Skip(1);
        var output = new List<string>{
            "match_id,team1,team2,score_team1,score_team2,winner,player_of_match"
        };
        foreach (var line in lines){
            var cols = line.Split(',');
            string team1 = Censorship.MaskTeamName(cols[1]);
            string team2 = Censorship.MaskTeamName(cols[2]);
            string winner = Censorship.MaskTeamName(cols[5]);
            output.Add($"{cols[0]},{team1},{team2},{cols[3]},{cols[4]},{winner},REDACTED");
        }
        File.WriteAllLines(outputPath, output);
    }
}
