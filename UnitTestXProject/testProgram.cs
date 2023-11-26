using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Arrange, Act, Assert
//Expected and Actual
 
namespace UnitTestXProject
{
    public class testProgram
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange
            DisplayMessage messages = new DisplayMessage();
            string expected = "Good Morning Micheal";

            //Act
            string actual = messages.Greeting("Micheal", 2);

            //Assert
            Xunit.Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessage messages = new DisplayMessage();
            string expected = "Good Afternoon Micheal";

            //Act
            string actual = messages.Greeting("Micheal", 17);

            //Assert
            Xunit.Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Micheal", 0, "Good Morning Micheal")]
        public void GreetingShouldreturnexpectedvalue(string firstName, int hourOftheDay, string expected)
        {
            //Arrange
            DisplayMessage messages = new DisplayMessage();
           // string expected = "Good Afternoon Micheal";

            //Act
            string actual = messages.Greeting(firstName, hourOftheDay);

            //Assert
            Xunit.Assert.Equal(expected, actual);
        }
    }
}
