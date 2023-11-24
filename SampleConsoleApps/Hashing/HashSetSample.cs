namespace SampleConsoleApps.Hashing
{
    public static class HashSetSample
    {
        public static void Main()
        {

            Console.Write("1. List to HashSet: ");

            List<string> listHobbies = new List<string>
            {
                "calcio",
                "nuoto",
                "basket",
                "surf",
                "calcio",
                "nuoto",
                "basket",
                "surf",

            };

            Console.Write("Original List: ");
            PrintArray(listHobbies.ToArray());

            // A HashSet is an optimized collection of unordered, unique elements that provides fast lookups and high-performance set operations. 
            // Ottimo per le performance e non ammette dupplicati
            // HashSet più veloce di array

            Console.Write("Same list casted in HashSet: ");
            HashSet<string> hobbies = new HashSet<string>(listHobbies);
            PrintArray(hobbies.ToArray());


            Console.Write("2. Merge HashSet");

            HashSet<string> hobbiesB = new HashSet<string>() {
                "hiking",
                "calcio",
                "nuoto",
                "basket",
                "surf"
            };

            PrintArray(hobbies.Union(hobbiesB).ToArray());


            Console.Write("3. Intersection: ");

            PrintArray(hobbies.Intersect(hobbiesB).ToArray());

        }

        static void PrintArray(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
