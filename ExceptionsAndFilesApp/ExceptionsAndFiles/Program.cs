class Program
{
    public static void Main(string[] args)
    {
        string filename = "test.txt";
        string destinationFile = "default.txt";
        string destinationPath = @"D:\Coding space\GitHub_repo\Temp\test.txt";
        string content = """
            This is a test file.
            It has multiple lines, 
            and it is created using C#.
            """;

        createFile(filename, content);
        readFile(filename);
        //deleteFile(filename);
        Console.WriteLine("Finished!");
        copyFile(filename, destinationFile);
        moveFile(filename, destinationPath);
    }

    private static void moveFile(string filename, string destinationPath)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist");
            return;
        }
        else
        {
            File.Move(filename, destinationPath);
        }
    }

    private static void copyFile(string filename, string destinationFile)
    {
        if (!File.Exists(filename) || File.Exists(destinationFile))
        {
            Console.WriteLine("File does not exist or the destination file does exist.");
            return;
        }
        else
        {

            File.Copy(filename, destinationFile);
        }
    }

    private static void deleteFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }
        else
        {
            //bool deleteFile = false;
            //while (!deleteFile)
            //{
            //    Console.Write("delete file?: ");
            //    Console.WriteLine();
            //    string yes = Console.ReadLine();
            //    if (yes != null && yes[0] == 'y')
            //    {
            // Delete the file.
            // Always confirm with the user that you want to delete the file first
            File.Delete(filename);
            //deleteFile = true; 
            //}
            //else
            //{
            //    return;
            //}
            //}


        }
    }

    private static void readFile(string filename)
    {
        // Read a file for demo purposes
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist");
            return;
        }
        else
        {
            // Open the file to read from
            using (StreamReader sr = File.OpenText(filename))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }

    private static void createFile(string path, string content)
    {
        // if the file doesn't exist, then we need to create the file and add text
        if (!File.Exists(path))
        {
            Console.WriteLine("The file doesn't exist. Creating the file and adding text to it.");
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(content);
            }
            return;
        }
        else
        {
            Console.WriteLine("File exists...");
        }

    }


}