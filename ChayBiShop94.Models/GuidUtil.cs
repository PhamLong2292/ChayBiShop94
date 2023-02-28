using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.Models
{
    public class GuidUtil
    {
        public static Guid GenerateComb()
        {
            byte[] array = Guid.NewGuid().ToByteArray();
            DateTime dateTime = new DateTime(1900, 1, 1);
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(now.Ticks - dateTime.Ticks);
            TimeSpan timeOfDay = now.TimeOfDay;
            byte[] bytes = BitConverter.GetBytes(timeSpan.Days);
            byte[] bytes2 = BitConverter.GetBytes((long)(timeOfDay.TotalMilliseconds / 3.333333));
            Array.Reverse(bytes);
            Array.Reverse(bytes2);
            Array.Copy(bytes, bytes.Length - 2, array, array.Length - 6, 2);
            Array.Copy(bytes2, bytes2.Length - 4, array, array.Length - 4, 4);
            return new Guid(array);
        }

        public static bool IsGuid(string value)
        {
            Guid guid;
            return Guid.TryParse(value, out guid);
        }

        public static bool TryParseGuid(string value, out string val)
        {
            Guid guid;
            bool flag = Guid.TryParse(value, out guid);
            bool result;
            if (flag)
            {
                val = guid.ToString();
                result = true;
            }
            else
            {
                val = value;
                result = false;
            }
            return result;
        }
    }
}
