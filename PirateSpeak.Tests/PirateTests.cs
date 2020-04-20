using System;
using Xunit;
using System.Collections.Generic;

namespace PirateSpeak.Tests
{
    public class PirateTests
    {
        [Fact]
        public void translate_ortsp()
        {
            var letters = new List<char>() { 'o', 'r', 't', 's', 'p' };
            var pirateWords = new List<string>() { "sport", "parrot", "ports", "matey" };
            var expectedResult = new List<string>() { "sport", "ports" };

            var translator = new Translator();

            var actualResult = translator.Translate(letters, pirateWords);

            Assert.Equal(expectedResult, actualResult);




        }
    }
}
