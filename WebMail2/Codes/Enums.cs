using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMail2.Codes
{
    public enum EnumMailType
    {
        InMail = 1,
        OutMail = 2,
        DraftMail = 3,
        DustMail = 4
    }

    public enum EnumMailAction
    {
        Send=0,
        Forward = 1,
        Reply=2,
        Edit=3,
    }

    public class EnumHelper
    {
        public static TEnum GetEnum<TEnum>(string value) where TEnum : struct
        {
            TEnum EnumType;
            if (Enum.TryParse<TEnum>(value, out EnumType))
            {
                return EnumType;
            }
            else
            {
                return new TEnum();
            }
        }
    }
}