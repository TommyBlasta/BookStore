using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Converters
{
    public class ByteConverter
    {
        public string ToString(byte[] byteArray)
        {
            if (byteArray == null)
                return null;
            return Encoding.UTF8.GetString(byteArray);
        }
        public byte[] ToByteArray(string str)
        {
            if (str == null)
                return null;
            return Encoding.UTF8.GetBytes(str);

        }
     }
}
