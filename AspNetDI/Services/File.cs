using System;
using System.IO;
using System.Text;
using AspNetDI.Services.Interfaces;

namespace AspNetDI.Services
{
	public class DIFile : IFile
	{
        public void Create(DateTime data, string Nome)
        {
            var fs = File.Create(DateTime.Now.ToString().Replace("/", "_").Replace(" ", "") + ".txt");
            var ByteContent = new UTF8Encoding(true).GetBytes(data.ToString() + Nome);
            fs.Write(ByteContent, 0, ByteContent.Length);
            fs.Close();
        }
    }
}

