using System;
using System.Linq;
using System.Collections.Generic;
namespace EIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // move_zeros(new int[] { 5, 0, 2, 0, 1, 0, 0, 3, 2, 0, 1 }).ToList()
            // .ForEach(i => Console.WriteLine(i));

            //Console.WriteLine(binary(100));

            //var result = permutations(new int[] { 1, 2, 3 });

            var list = new JaneList();
            list.add("Jane");  // jane makes sure to include herself
            list.add("Fred");
            list.add("Mary");
            list.add("Bob");

            list.get("Fred"); // -> ["Bob", "Jane"]

            list.delete("Bob");
            list.get("Fred");  //-> ["Mary", "Jane"]
        }

    }
}
