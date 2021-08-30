using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCollectionLibrary
{
    public static class HelperMethods
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng)
        {
            T[] elements = source.ToArray();
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                // Swap element "i" with a random earlier element it (or itself)
                // ... except we don't really need to swap it fully, as we can
                // return it immediately, and afterwards it's irrelevant.
                int swapIndex = rng.Next(i + 1);
                yield return elements[swapIndex];
                elements[swapIndex] = elements[i];
            }
        }
        //Fisher-Yates Shuffle Sourced from Stackoverflow, original author Jon Skeet
        //    https://stackoverflow.com/a/1287572

    }
}
