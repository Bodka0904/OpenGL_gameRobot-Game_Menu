using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Threading;

namespace MemoryMap
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                using (MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen("startmenu", 4))
                {
                    using (MemoryMappedViewStream stream = mmf.CreateViewStream())
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        writer.Write(1);
                    }
                }
            }
        }
    }
}
