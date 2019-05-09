using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DecoratorPattern_Stream
{
    public class LowerCaseStreamReader : StreamReader
    {
        public LowerCaseStreamReader(Stream stream) : base(stream)
        {
        }

        public LowerCaseStreamReader(string path) : base(path)
        {
        }

        public LowerCaseStreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) : base(stream, detectEncodingFromByteOrderMarks)
        {
        }

        public LowerCaseStreamReader(Stream stream, Encoding encoding) : base(stream, encoding)
        {
        }

        public LowerCaseStreamReader(string path, bool detectEncodingFromByteOrderMarks) : base(path, detectEncodingFromByteOrderMarks)
        {
        }

        public LowerCaseStreamReader(string path, Encoding encoding) : base(path, encoding)
        {
        }

        public LowerCaseStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) : base(stream, encoding, detectEncodingFromByteOrderMarks)
        {
        }

        public LowerCaseStreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) : base(path, encoding, detectEncodingFromByteOrderMarks)
        {
        }

        public LowerCaseStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : base(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize)
        {
        }

        public LowerCaseStreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) : base(path, encoding, detectEncodingFromByteOrderMarks, bufferSize)
        {
        }

        public LowerCaseStreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) : base(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen)
        {
        }

        public override int Read()
        {
            int charCode = base.Read();
            int lowerCharCode = charCode == -1 ? charCode : Convert.ToChar(charCode).ToString().ToLower()[0];
            return lowerCharCode;
        }
    }
}
