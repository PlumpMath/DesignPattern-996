using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Decorator
{
    public class UpperStream : Stream
    {
        private Stream _stream;
        public UpperStream(Stream stream)
        {
            this._stream = stream;
        }
        public override bool CanRead
        {
            get { return _stream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _stream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override long Length
        {
            get { return _stream.Length; }
        }

        public override long Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var numberOfBytesRead = _stream.Read(buffer, offset, count);
            for (int i = 0; i < numberOfBytesRead; i++)
            {
                buffer[i] = (byte)char.ToUpper((char)((int)buffer[i]));
            }


            return numberOfBytesRead;

        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }



        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
}
