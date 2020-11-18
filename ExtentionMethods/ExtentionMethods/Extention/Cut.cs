using System;

namespace System
{
    static class Cut
    {
        public static string Cortar(this string thisObj, int count)
        {
            if (thisObj.Length < count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count);
            }
        }
    }
}
