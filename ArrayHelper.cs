using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            // put your code here
            //throw new NotImplementedException();
            foreach (int s in source)
            {
                if (s != 0 && s != 1)
                {
                    throw new ArgumentException();
                }
            }

            if (source.Length % 2 != 0)
            {
                return "No";
            }
            bool flag = true;
            for (int i = 0; i < source.Length / 2; i++)
            {
                if (source[i] != source[source.Length - i - 1])
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                return "Yes";
            }
            else
                return "No";
        }
    }
}
