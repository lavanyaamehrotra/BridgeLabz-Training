using HealthClinicApp.Services;
namespace HealthClinicApp.Menu;
public class MainMenu{
    DoctorService doctorService = new DoctorService();
    PatientService patientService = new PatientService();
    RoomService roomService = new RoomService();
    AppointmentService appointmentService = new AppointmentService();
    BillingService billingService = new BillingService();

    public void ShowMenu(){
        while (true){
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("      HEALTH CLINIC MANAGEMENT SYSTEM");
            Console.WriteLine("==============================================");
            Console.WriteLine("1. Doctor Management");
            Console.WriteLine("2. Patient Management");
            Console.WriteLine("3. Room Management");
            Console.WriteLine("4. Appointment Management");
            Console.WriteLine("5. Billing Management");
            Console.WriteLine("6. Exit");
            Console.WriteLine("==============================================");
            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    DoctorMenu();
                    break;
                case 2:
                    PatientMenu();
                    break;
                case 3:
                    RoomMenu();
                    break;
                case 4:
                    AppointmentMenu();
                    break;
                case 5:
                    BillingMenu();
                    break;
                case 0:
                    Console.WriteLine("\nThank You.");
                    return;
                default:
                    Console.WriteLine("Invalid Choice.");
                    Console.ReadKey();
                    break;
            }
        }
    }
    private void DoctorMenu(){
        Console.Clear();
        Console.WriteLine("========== DOCTOR MANAGEMENT ==========");
        Console.WriteLine("1. Add Doctor");
        Console.WriteLine("2. View Doctors");
        Console.WriteLine("3. Search Doctor");
        Console.WriteLine("4. Update Doctor");
        Console.WriteLine("5. Delete Doctor");
        Console.WriteLine("0. Back");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice){
            case 1: doctorService.AddDoctor(); break;
            case 2: doctorService.ViewDoctors(); break;
            case 3: doctorService.SearchDoctor(); break;
            case 4: doctorService.UpdateDoctor(); break;
            case 5: doctorService.DeleteDoctor(); break;
            case 0: return;
            default: Console.WriteLine("Invalid Choice."); break;
        }
        Console.ReadKey();
    }
    private void PatientMenu(){
        Console.Clear();
        Console.WriteLine("========== PATIENT MANAGEMENT ==========");
        Console.WriteLine("1. Add Patient");
        Console.WriteLine("2. View Patients");
        Console.WriteLine("3. Search Patient");
        Console.WriteLine("4. Update Patient");
        Console.WriteLine("5. Delete Patient");
        Console.WriteLine("0. Back");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice){
            case 1: patientService.AddPatient(); break;
            case 2: patientService.ViewPatients(); break;
            case 3: patientService.SearchPatient(); break;
            case 4: patientService.UpdatePatient(); break;
            case 5: patientService.DeletePatient(); break;
            case 0: return;
            default: Console.WriteLine("Invalid Choice."); break;
        }
        Console.ReadKey();
    }
    private void RoomMenu(){
        Console.Clear();
        Console.WriteLine("========== ROOM MANAGEMENT ==========");
        Console.WriteLine("1. Add Room");
        Console.WriteLine("2. View Rooms");
        Console.WriteLine("3. Search Room");
        Console.WriteLine("4. Update Room");
        Console.WriteLine("5. Delete Room");
        Console.WriteLine("0. Back");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice){
            case 1: roomService.AddRoom(); break;
            case 2: roomService.ViewRooms(); break;
            case 3: roomService.SearchRoom(); break;
            case 4: roomService.UpdateRoom(); break;
            case 5: roomService.DeleteRoom(); break;
            case 0: return;
            default: Console.WriteLine("Invalid Choice."); break;
        }
        Console.ReadKey();
    }
    private void AppointmentMenu(){
        Console.Clear();
        Console.WriteLine("======= APPOINTMENT MANAGEMENT =======");
        Console.WriteLine("1. Schedule Appointment");
        Console.WriteLine("2. View Appointments");
        Console.WriteLine("3. Search Appointment");
        Console.WriteLine("4. Update Appointment");
        Console.WriteLine("5. Cancel Appointment");
        Console.WriteLine("0. Back");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice){
            case 1: appointmentService.AddAppointment(); break;
            case 2: appointmentService.ViewAppointments(); break;
            case 3: appointmentService.SearchAppointment(); break;
            case 4: appointmentService.UpdateAppointment(); break;
            case 5: appointmentService.DeleteAppointment(); break;
            case 0: return;
            default: Console.WriteLine("Invalid Choice."); break;
        }
        Console.ReadKey();
    }
    private void BillingMenu(){
        Console.Clear();
        Console.WriteLine("========== BILLING MANAGEMENT ==========");
        Console.WriteLine("1. Generate Bill");
        Console.WriteLine("2. View Bills");
        Console.WriteLine("3. Search Bill");
        Console.WriteLine("4. Update Bill");
        Console.WriteLine("5. Delete Bill");
        Console.WriteLine("0. Back");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice){
            case 1: billingService.AddBill(); break;
            case 2: billingService.ViewBills(); break;
            case 3: billingService.SearchBill(); break;
            case 4: billingService.UpdateBill(); break;
            case 5: billingService.DeleteBill(); break;
            case 0: return;
            default: Console.WriteLine("Invalid Choice."); break;
        }
        Console.ReadKey();
    }
}