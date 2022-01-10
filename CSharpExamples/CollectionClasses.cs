using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpExamples
{
    public class CollectionClasses
    {
        [Fact]

        public void ListsOfThings()
        {
            // lists are "indexed" by an integer, starting at zero.
            var luckyNumbers = new List<int>(); // "List of int" (Cup<T>)
            luckyNumbers.Add(9); /// [0]
            luckyNumbers.Add(10); // [1]
            luckyNumbers.Add(20);// [2]

            Assert.Equal(20, luckyNumbers[2]);
            luckyNumbers[1] = 108;
            Assert.Equal(108, luckyNumbers[1]);

            var friends = new List<string>() // initializer syntax.
            {
                "David",
                "Lee",
                "Byron"
            };

            Assert.Equal("David", friends[0]);

            var total = 0;
            foreach(var num in luckyNumbers)
            {
                // total += num;
                total = total + num;
            }
            Assert.Equal(137, total);
        }

        [Fact]
        public void UsingADictionary()
        {
            var friends = new Dictionary<char, string>();

            //var letterC = 'C';
            friends.Add('s', "Sean");
            friends.Add('d', "David");
            friends.Add('x', "David");

            Assert.Equal("Sean", friends['s']);
            /// Enumerate all the keys
            foreach(var key in friends.Keys)
            {
                // the keys.
            }
            // enumerate the values
            foreach(var val in friends.Values)
            {

            }

            // enumerate both at the same time
            foreach(var kvp in friends)
            {
                // "KVP is a "Key Value Pair"
               
            }


        }
    }
}
