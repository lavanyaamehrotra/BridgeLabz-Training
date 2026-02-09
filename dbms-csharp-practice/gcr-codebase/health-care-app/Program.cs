using System;

class Program
{
    static void Main()
    {
        IPatientService patientService = new PatientService();
        IDoctorService doctorService = new DoctorService();
        IAppointmentService appointmentService = new AppointmentService();
        IVisitService visitService = new VisitService();
        IBillingService billingService = new BillingService();
        IAdminUtilityService adminUtilityService = new AdminUtilityService();
        AuthService authService = new AuthService();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   HEALTH CARE MANAGEMENT SYSTEM");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Login");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                ShowError("Invalid input.");
                continue;
            }

            if (choice == 0)
            {
                Console.WriteLine("Thank you for using the system.");
                return;
            }

            if (choice != 1)
            {
                ShowError("Invalid choice.");
                continue;
            }

            Console.Write("\nUsername: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = ReadPassword();

            string role = authService.Login(username, password);

            if (role == null)
            {
                ShowError("Invalid username or password.");
                continue;
            }

            Console.WriteLine($"\nLogin successful. Role: {role}");
            Pause();

            switch (role)
            {
                case "Administrator":
                    AdministratorMenu(doctorService, billingService, adminUtilityService);
                    break;

                case "Receptionist":
                    ReceptionistMenu(
                        patientService,
                        doctorService,
                        appointmentService,
                        billingService
                    );
                    break;

                case "Doctor":
                    DoctorMenu(
                        patientService,
                        appointmentService,
                        visitService
                    );
                    break;

                case "Patient":
                    PatientMenu(
                        doctorService,
                        appointmentService
                    );
                    break;

                default:
                    ShowError("Role not recognized.");
                    break;
            }
        }
    }

    /* ================= PASSWORD MASKING ================= */

    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        while (true)
        {
            key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Enter)
                break;

            if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password[..^1];
                Console.Write("\b \b");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                password += key.KeyChar;
                Console.Write("*");
            }
        }

        Console.WriteLine();
        return password;
    }

    /* ================= ADMINISTRATOR ================= */

    static void AdministratorMenu(
        IDoctorService doctorService,
        IBillingService billingService,
        IAdminUtilityService adminUtilityService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== ADMINISTRATOR MENU =====");
            Console.WriteLine("1. Add Doctor Profile");
            Console.WriteLine("2. Update Doctor Specialty");
            Console.WriteLine("3. Deactivate Doctor Profile");
            Console.WriteLine("4. View Doctors by Specialty");
            Console.WriteLine("5. View Outstanding Bills");
            Console.WriteLine("6. Generate Revenue Report");
            Console.WriteLine("7. Manage Specialties");
            Console.WriteLine("8. View System Audit Logs");
            Console.WriteLine("0. Logout");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                ShowError("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1: doctorService.AddDoctor(); break;
                case 2: doctorService.UpdateSpecialization(); break;
                case 3: doctorService.DeactivateDoctor(); break;
                case 4: doctorService.ViewDoctorsBySpecialty(); break;
                case 5: billingService.ViewOutstandingBills(); break;
                case 6: billingService.GenerateRevenueReport(); break;
                case 7: adminUtilityService.ManageSpecialties(); break;
                case 8: adminUtilityService.ViewAuditLogs(); break;
                case 0: return;
                default: ShowError("Invalid choice."); break;
            }

            Pause();
        }
    }

    /* ================= RECEPTIONIST ================= */

    static void ReceptionistMenu(
        IPatientService patientService,
        IDoctorService doctorService,
        IAppointmentService appointmentService,
        IBillingService billingService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== RECEPTIONIST MENU =====");

            Console.WriteLine("---- Patient Management ----");
            Console.WriteLine("1. Register New Patient");
            Console.WriteLine("2. Update Patient Information");
            Console.WriteLine("3. Search Patient Records");
            Console.WriteLine("4. View Patient Visit History");

            Console.WriteLine("\n---- Doctor & Appointment ----");
            Console.WriteLine("5. View Doctors by Specialty");
            Console.WriteLine("6. Book New Appointment");
            Console.WriteLine("7. Check Doctor Availability");
            Console.WriteLine("8. Cancel Appointment");
            Console.WriteLine("9. Reschedule Appointment");
            Console.WriteLine("10. View Daily Appointment Schedule");

            Console.WriteLine("\n---- Billing ----");
            Console.WriteLine("11. Generate Bill");
            Console.WriteLine("12. Record Payment");
            Console.WriteLine("13. View Outstanding Bills");

            Console.WriteLine("0. Logout");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                ShowError("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1: patientService.RegisterPatient(); break;
                case 2: patientService.UpdatePatient(); break;
                case 3: patientService.SearchPatient(); break;
                case 4: patientService.ViewPatientHistory(); break;
                case 5: doctorService.ViewDoctorsBySpecialty(); break;
                case 6: appointmentService.BookAppointment(); break;
                case 7: appointmentService.CheckDoctorAvailability(); break;
                case 8: appointmentService.CancelAppointment(); break;
                case 9: appointmentService.RescheduleAppointment(); break;
                case 10: appointmentService.ViewDailySchedule(); break;
                case 11: billingService.GenerateBill(); break;
                case 12: billingService.RecordPayment(); break;
                case 13: billingService.ViewOutstandingBills(); break;
                case 0: return;
                default: ShowError("Invalid choice."); break;
            }

            Pause();
        }
    }

    /* ================= DOCTOR ================= */

    static void DoctorMenu(
        IPatientService patientService,
        IAppointmentService appointmentService,
        IVisitService visitService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== DOCTOR MENU =====");
            Console.WriteLine("1. Search Patient Records");
            Console.WriteLine("2. View Patient Visit History");
            Console.WriteLine("3. View Daily Appointment Schedule");
            Console.WriteLine("4. Record Patient Visit");
            Console.WriteLine("5. View Patient Medical History");
            Console.WriteLine("6. Add Prescription Details");
            Console.WriteLine("0. Logout");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                ShowError("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1: patientService.SearchPatient(); break;
                case 2: patientService.ViewPatientHistory(); break;
                case 3: appointmentService.ViewDailySchedule(); break;
                case 4: visitService.RecordVisit(); break;
                case 5: visitService.ViewMedicalHistory(); break;
                case 6: visitService.AddPrescription(); break;
                case 0: return;
                default: ShowError("Invalid choice."); break;
            }

            Pause();
        }
    }

    /* ================= PATIENT ================= */

    static void PatientMenu(
        IDoctorService doctorService,
        IAppointmentService appointmentService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== PATIENT MENU =====");
            Console.WriteLine("1. View Doctors by Specialty");
            Console.WriteLine("2. View Daily Appointment Schedule");
            Console.WriteLine("0. Logout");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                ShowError("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1: doctorService.ViewDoctorsBySpecialty(); break;
                case 2: appointmentService.ViewDailySchedule(); break;
                case 0: return;
                default: ShowError("Invalid choice."); break;
            }

            Pause();
        }
    }

    /* ================= COMMON HELPERS ================= */

    static void ShowError(string message)
    {
        Console.WriteLine($"\n❌ {message}");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress ENTER to continue...");
        Console.ReadLine();
    }
}
