namespace crgolden.Sage100
{
    using System.Linq;

    public static class ArrayExtensions
    {
        public static T[] ConcatArrays<T>(this T[][] arrays)
        {
            var result = new T[arrays.Sum(a => a.Length)];
            var offset = 0;
            foreach (var array in arrays)
            {
                array.CopyTo(result, offset);
                offset += array.Length;
            }

            return result;
        }
    }
}
