using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;
using ZooLab;

namespace Program.tests
{
    public class ZooConsoleTests
    {
        [Fact]
        public void ShouldBeAbleToGetMainConsole()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            //_stringBuilder.AppendLine("!");
            //_stringBuilder.AppendLine("4");
            //_stringBuilder.AppendLine("(");
            //_stringBuilder.AppendLine("5");
            //_stringBuilder.AppendLine("a");
            //_stringBuilder.AppendLine("n");
            //StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            //Console.SetIn(_stringReader);

            ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Type another number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 9" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }
    }
}