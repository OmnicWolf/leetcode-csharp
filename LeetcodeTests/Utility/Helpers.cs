using System.Text;

namespace LeetcodeTests.Utility
{
    public class Helpers
    {
        private Helpers() {}

        public static string ToString(string[] arr)
        {
            return "[" + string.Join(", ", arr) + "]";
        }

        public static string ToString(int[] arr)
        {
            if(arr.Length < 1)
            {
                return "[ <empty> ]";
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("[").Append(arr[0]);

            for(int i=1; i < arr.Length; ++i)
            {
                sb.Append(", ").Append(arr[i]);
            }

            sb.Append("]");

            return sb.ToString();
        }
    }
}
