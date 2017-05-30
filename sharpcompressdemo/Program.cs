using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sharpcompressdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = System.IO.File.Create("D:\\a.zip"))
            {
                using (var zw = new SharpCompress.Writers.Zip.ZipWriter(file, new SharpCompress.Writers.Zip.ZipWriterOptions(SharpCompress.Common.CompressionType.Deflate)))
                {
                    zw.WriteToStream("a",new SharpCompress.Writers.Zip.ZipWriterEntryOptions()).Dispose();
                }
            }
        }
    }
}
