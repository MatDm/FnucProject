using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Fnuc.Service.Filters
{
    public class Decoder
    {
       public string UncodePassword(byte[] cryptedPassword)
        {

            Encoding encoding = Encoding.ASCII;

            encoding = (Encoding)encoding.Clone();

            encoding.DecoderFallback = DecoderFallback.ExceptionFallback;
            string decodedCredentials;

            try
            {
                decodedCredentials = encoding.GetString(cryptedPassword);
            }
            catch (DecoderFallbackException)
            {
                return null;
            }

            if (String.IsNullOrEmpty(decodedCredentials))
            {
                return null;
            }


            return decodedCredentials;
        }
    }
}