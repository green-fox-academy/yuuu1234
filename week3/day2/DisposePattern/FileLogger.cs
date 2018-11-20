using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DisposePattern
{
    class FileLogger:IDisposable
    {
        protected  FileStream fileStream;
        protected  StreamWriter writer;
        public FileLogger(string filePath)
        { 
           fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);

        }


        public virtual void Log(string message)
        {
            // Implement the file logging. Every line should follow the format:
            // <current date and time> - <message>
            // e.g.
            // 2018-11-09T14:46:55.345 - This is a sample message
            // Hint: use StreamWriter
            using (writer = new StreamWriter(this.fileStream, Encoding.ASCII, 1024, true))
            {
                writer.WriteLine(message);
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                
                fileStream?.Dispose();
            }
        }
    }
}
