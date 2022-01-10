using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Xunit;


namespace CSharpExamples; // Ctrl+K, Ctrl+D

public class FormattingNames
{
    [Theory]
    [InlineData("Luke", "Skywalker", "Skywalker, Luke")]
    [InlineData("Lando", "Calrissian", "Calrissian, Lando")]
    [InlineData("Padme", "Amidala", "Amidala, Padme")]
    public void CanFormatAName(string firstName, string lastName, string expected)
    {
        // "Write the code you wish you had" 
        //Given
        var nameFormatter = new NameFormatter();


        // When
        string fullName = nameFormatter.FormatName(firstName, lastName);

        // Then
        Assert.Equal(expected, fullName);
    }


}
