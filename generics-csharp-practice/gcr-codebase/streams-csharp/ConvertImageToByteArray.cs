using System;
using System.IO;
class ConvertImageToByteArray{
    static void Main(){
        string originalImage = "original.jpg";
        string newImage = "copy.jpg";
        try{
            // Read image into byte array
            byte[] imageBytes = File.ReadAllBytes(originalImage);
            // Use MemoryStream to handle byte array
            using (MemoryStream ms = new MemoryStream(imageBytes)){
                // Write byte array back to new image file
                using (FileStream fs = new FileStream(newImage, FileMode.Create)){
                    ms.WriteTo(fs);
                }
            }
            Console.WriteLine("Image copied successfully.");
            // Verifing both files are identical
            bool isSame = File.ReadAllBytes(originalImage).Length == File.ReadAllBytes(newImage).Length;
            Console.WriteLine("Files identical: " + isSame);
        }
        catch (IOException ex){
            Console.WriteLine("File error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
