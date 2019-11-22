using System;
using System.IO;

namespace UploadImageInDatabase.Controllers
{
    internal class Binaryreader
    {
        private Stream inputStream;

        public Binaryreader(Stream inputStream)
        {
            this.inputStream = inputStream;
        }

        internal string ReadBytes(Stream inputStream)
        {
            throw new NotImplementedException();
        }
    }
}