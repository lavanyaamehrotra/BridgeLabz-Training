public class LabController{
    [PublicAPI("Get all lab tests")]
    public void GetAllTests() { }

    [PublicAPI("Get lab test by ID")]
    [RequiresAuth]
    public void GetTestById() { }
    // Missing annotation (for validation check)
    public void DeleteTest() { }
}
