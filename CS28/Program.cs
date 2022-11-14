namespace CS28
{
    class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Drive: {drive.Name}");
                Console.WriteLine($"Drive Type: {drive.DriveType}");
                Console.WriteLine($"Drive Size: {drive.TotalSize}");
                Console.WriteLine($"Drive Free: {drive.TotalFreeSpace}");
                Console.WriteLine("----------");           
                /////
                
               
            }
            string path = "obj";
            var files = Directory.GetFiles(path);
            var Directories = Directory.GetDirectories(path);
            foreach (var file in files)
            {
                Console.WriteLine($"File: {file}");
            }
            foreach (var dir in  Directories)           
            {
                Console.WriteLine($"Directory: {dir}");
            }
            if(Directory.Exists(path))
            {
                Console.WriteLine($"{path} - ton tai");
            }
            else{
                Console.WriteLine($"{path} - khong ton tai");
            }
        }
        static void testWriteAllText () {
        var filename = "test.txt";
        string contentfile = "Xin chào";

        // Lấy thư mục Document của User trên hệ thống
        var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        var fullpath = Path.Combine(directory_mydoc, filename);
        File.WriteAllText (filename, contentfile);

        Console.WriteLine ($"File lưu tại {directory_mydoc}{Path.DirectorySeparatorChar}{filename}");

        }
        static void testAppendAllText() {

        var filename = "test.txt";
        string contentfile = "\nXin chào! xuanthulab.net - " + DateTime.Now.ToString ();

        var directory_mydoc = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
        var fullpath = Path.Combine (directory_mydoc, filename);

        if (File.Exists (fullpath)) {
            // File đã tồn tại - nối thêm nội dung
            File.AppendAllText (fullpath, contentfile);
        } else {
            // tạo mới vì chưa tồn tại file
            File.WriteAllText (fullpath, contentfile);
        }
        // Đọc nội dung File
        Console.WriteLine (fullpath);
        string s = File.ReadAllText (fullpath);
        Console.WriteLine (s);
        }
        static void ListFileDirectory(string path)
        {
        String[] directories = System.IO.Directory.GetDirectories(path);
        String[] files = System.IO.Directory.GetFiles(path);
        foreach (var file in files)
        {
        Console.WriteLine(file);
        }
        foreach (var directory in directories)
        {
        Console.WriteLine(directory);
        ListFileDirectory(directory); // Đệ quy
        }
    }

    }
    
}