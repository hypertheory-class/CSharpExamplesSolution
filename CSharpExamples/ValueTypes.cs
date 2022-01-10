using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpExamples
{
    public class ValueTypes
    {
        [Fact]
        public void DoingDogStuff()
        {
            var dog1 = new Dog() { Name = "Poppy" };
            var dog2 = new Dog() { Name = "Java", Breed = "Cairn Terrier" };


            
            //Assert.Equal("Cairn Terrier", dog2.Breed);
            //Assert.Equal("Boxer", dog1.Breed);

            ChangeBreed(dog1);
            ChangeBreed(dog2);

            Assert.Equal("Dog Poppy is playing Fetch!", dog1.Fetch());
            Assert.Equal("Dog Java is playing Fetch!", dog2.Fetch());

        }

        public void ChangeBreed(Dog x)
        {
            x.Breed = "Mutt";
        }
        
    }


    public class Dog
    {
        public string Name { get; set; } = "";

        public string Breed { get; set; } = "";

        public void RollOver()
        {
            // do the thing
        }

        public string Fetch()
        {
            return $"Dog {this.Name} is playing Fetch!";
        }

        public void TapDance()
        {
            if(this.Breed != "Jack Russel")
            {
                throw new Exception();
            } else
            {
                /// do the dancing.
            }
        }
    }
}
