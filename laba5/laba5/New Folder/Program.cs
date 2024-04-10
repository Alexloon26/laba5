namespace laba5.New_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory(1000);
            directory.AddObject(new Mp3(50, "song.mp3"));
            directory.AddObject(new TextFile(30, "word.txt"));
            directory.AddObject(new Archive(200, "BepInex.zip"));

            Console.WriteLine("Файли в директорії: " + directory.GetTypeOfObject());
            Console.WriteLine("Кількість аудіофайлів в директорії: " + directory.CountAudioFiles());
            directory.RunFile("song1.mp3");
            Console.WriteLine("Розмір директорії: " + directory.DirectorySize() + " KB");
        }
    }
}