using System;
using System.Collections.Generic;
namespace laba5.New_Folder
{
    public class Directory : Disk
    {
        private List<Disk> contents; 

        
        public Directory(int size) : base(size)
        {
            contents = new List<Disk>();
        }

        
        public void AddObject(Disk obj)
        {
            contents.Add(obj);
        }

        
        public override string GetTypeOfObject()
        {
            string fileNames = "";
            foreach (Disk obj in contents)
            {
                fileNames += obj.GetTypeOfObject() + ", ";
            }
            
            fileNames = fileNames.TrimEnd(' ', ',');
            return fileNames;
        }

        
        public int CountAudioFiles()
        {
            int count = 0;
            foreach (Disk obj in contents)
            {
                if (obj.GetType() == typeof(Mp3))
                    count++;
            }
            return count;
        }

        
        public void RunFile(string fileName)
        {
            Console.WriteLine("Запуск файлу: " + fileName);
        }

        
        public int DirectorySize()
        {
            int totalSize = 0;
            foreach (Disk obj in contents)
            {
                totalSize += obj.GetSize();
            }
            return totalSize;
        }
    }

}