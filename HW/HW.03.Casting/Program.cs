using System;

namespace HW._03.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a (5 примеров явного преобразования типов)

            decimal d1 = 1;
            byte b1 = (byte)d1;
            short s1 = (short)d1;
            char c1 = (char)d1;
            int i1 = (int)d1;
            long l1 = (long) d1;

            #endregion

            #region b (5 примеров неявного преобразования типов)

            byte b2 = 1;
            short s2 = b2;
            int i2 = b2;
            long l2 = b2;
            decimal d2 = b2;
            float f2 = b2;

            #endregion

            #region c (5 примеров операции упаковки (boxing))

            int age = 25;
            object obj = age;
            string str = age.ToString();

            #endregion

            #region d (5 примеров операции распаковки (unboxing))

            int unboxAge1 = (int)obj;
            int unboxAge2 = Convert.ToInt32(str);

            #endregion
        }
    }
}
