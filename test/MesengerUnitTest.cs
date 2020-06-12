using System;
using Xunit;
using AppCore;
using System.Threading.Tasks;

namespace test
{
    public class MesengerUnitTest
    {
        [Fact]
        public async Task GetMessage()
        {
            //Arrange
            Messenger msg = new Messenger();
            //Act
            string result = await msg.GetMessage("LUIS");
            //Assert
            Assert.NotEmpty(result);
            Assert.Equal("hola LUIS", result);
        }


    }
}