public class PatientController{
    [PublicAPI("Register patient")]
    public void RegisterPatient() { }
    [RequiresAuth]
    public void ViewPatientHistory() { }
}
