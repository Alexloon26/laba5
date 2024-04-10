using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.New_Folder
{
    public abstract class Disk
    {
        protected int size; 

       
        public Disk(int size)
        {
            this.size = size;
        }

        
        public abstract string GetTypeOfObject();

        
        public int GetSize()
        {
            return size;
        }
    }
}
