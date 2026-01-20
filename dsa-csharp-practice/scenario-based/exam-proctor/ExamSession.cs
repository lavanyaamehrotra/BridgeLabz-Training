class ExamSession{
    private CustomStack navigation;
    //exam session
    public ExamSession(){
        navigation = new CustomStack(10);
    }
    //visit question
    public void VisitQuestion(int qid){
        navigation.Push(qid);
    }
    //go back
    public int GoBack(){
        return navigation.Pop();
    }
    //has history
    public bool HasHistory(){
        return !navigation.IsEmpty();
    }
}
