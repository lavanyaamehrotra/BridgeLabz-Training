public static class Censorship{
    public static string MaskTeamName(string teamName){
        var parts = teamName.Split(' ');
        if (parts.Length >= 2)
            return parts[0] + " ***" + (parts.Length > 2 ? " " + parts[^1] : "");
        return teamName;
    }
}
