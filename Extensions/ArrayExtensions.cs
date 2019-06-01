namespace crgolden.Sage
{
    using System.Linq;

    public static class ArrayExtensions
    {
        public static T[] ConcatArrays<T>(this T[][] arrays)
        {
            var result = new T[arrays.Sum(a => a.Length)];
            int offset = 0;
            for (int x = 0; x < arrays.Length; x++)
            {
                arrays[x].CopyTo(result, offset);
                offset += arrays[x].Length;
            }

            return result;
        }
    }
}
