using System;
using System.IO;
using NUnit.Framework;
public class FileProcessor{
    // Writes given content to a file
    public void WriteToFile(string filename, string content){
        File.WriteAllText(filename, content);
    }
    // Reads and returns content from a file
    public string ReadFromFile(string filename){
        return File.ReadAllText(filename);
    }
}
[TestFixture]
public class FileProcessorTests{
    FileProcessor processor;
    string filePath;
    // Runs before each test
    [SetUp]
    public void Setup(){
        processor = new FileProcessor();
        filePath = "testfile.txt";
    }
    // Runs after each test to clean up files
    [TearDown]
    public void TearDown(){
        if(File.Exists(filePath)){
            File.Delete(filePath);
        }
    }
    [Test]
    public void WriteAndRead_File_ContentMatches(){
        processor.WriteToFile(filePath, "Hello Capgemini");
        string result = processor.ReadFromFile(filePath);
        Assert.AreEqual("Hello Capgemini", result);
    }
    [Test]
    public void Write_File_FileExists(){
        processor.WriteToFile(filePath, "Test Data");
        Assert.IsTrue(File.Exists(filePath));
    }
    [Test]
    public void Read_NonExistingFile_ThrowsIOException(){
        Assert.Throws<IOException>(() => processor.ReadFromFile("nofile.txt"));
    }
}
