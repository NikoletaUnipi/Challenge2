using System;
using System.Collections.Generic;

namespace challenge2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            IEnumerable<string> names2 =FriendOrFoe(names);
            foreach (string s in names2) {
                Console.WriteLine(s);
            } 
        }
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            IEnumerable<string> names2 = Array.FindAll(names,x=>x.Length ==4);
           
            return names2;
        }
    }
}
