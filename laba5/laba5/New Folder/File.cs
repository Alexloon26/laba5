using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.New_Folder
{
    public abstract class File : Disk
    {
        protected string fileName; 

        public File(int size, string fileName) : base(size)
        {
            this.fileName = fileName;
        }
        public override string GetTypeOfObject()
        {
            return fileName;
        }
    }
}
