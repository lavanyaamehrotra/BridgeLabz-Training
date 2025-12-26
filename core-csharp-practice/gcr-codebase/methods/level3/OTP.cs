//  Write a program to generate a six-digit OTP number using Math.Random() method. Validate the numbers are unique by generating the OTP number 10 times and ensuring all the 10 OTPs are not the same

class OTP{
    public static int Generate(){
        Random rand = new Random();
        return rand.Next(100000, 1000000);
    }
    public static bool IsUnique(int[] otp){
        for (int i = 0; i < otp.Length; i++){
            for (int j = i + 1; j < otp.Length; j++){
                if (otp[i] == otp[j]){
                    return false;
                }
            }
        }
        return true;
    }
    public static void Main(){
        int[] otp = new int[10];
        // Generating 10 times
        for (int i = 0; i < otp.Length; i++){
            otp[i] = OTP.Generate();
        }
        for (int i = 0; i < otp.Length; i++){
            Console.WriteLine(otp[i]);
        }
        // Checking uniqueness
        if (OTP.IsUnique(otp))
            Console.WriteLine("All UNIQUE");
        else
            Console.WriteLine("Duplicate found");
    }
}


