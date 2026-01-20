class Evaluator{
    private CustomDictionary correctAnswers;
    //evaluator
    public Evaluator(){
        correctAnswers = new CustomDictionary(10);
        correctAnswers.Add(1, "A");
        correctAnswers.Add(2, "B");
        correctAnswers.Add(3, "C");
    }
    //calculate score
    public int CalculateScore(CustomDictionary studentAnswers){
        int score = 0;
        for (int i = 0; i < studentAnswers.Size(); i++){
            int qid = studentAnswers.GetKey(i);
            string ans = studentAnswers.GetValue(i);
            if (correctAnswers.Get(qid) != null  && correctAnswers.Get(qid).Equals(ans)){
                score++;
            }
        }
        return score;
    }
}
