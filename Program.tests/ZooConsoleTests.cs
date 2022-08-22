using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;
using ZooLab;
using ZooLab.Animals;

namespace ZooAppConsole
{
    public class ZooConsoleTests
    {
        [Fact]
        public void ShoulBeAbleToCreateMainConsole()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("7");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                " 1.Look all information about all Zoos." +
                "  2.Hire new Employee" +
                "  3.Feed all animals" +
                "  4.Heal all anmals" +
                "  5.All sick animals" +
                "  6.Last time of feed" +
                " 7.Exit";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShoulBeAbleToHealAllAnimal()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("4");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                 " 1.Look all information about all Zoos." +
                 "  2.Hire new Employee" +
                 "  3.Feed all animals" +
                 "  4.Heal all anmals" +
                 "  5.All sick animals" +
                 "  6.Last time of feed" +
                 " 7.Exit" +
                 "All Animal is Heal!";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShoulBeAbleToFeedAllAnimal()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("3");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                 " 1.Look all information about all Zoos." +
                 "  2.Hire new Employee" +
                 "  3.Feed all animals" +
                 "  4.Heal all anmals" +
                 "  5.All sick animals" +
                 "  6.Last time of feed" +
                 " 7.Exit" +
                 "All Animal is feed!";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShoulBeAbleToHireNewEmployeeAllAnimal1()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("2");
            _stringBuilder.AppendLine("Ger");
            _stringBuilder.AppendLine("Gir");
            _stringBuilder.AppendLine("5/4");
            _stringBuilder.AppendLine("1");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                 " 1.Look all information about all Zoos." +
                 "  2.Hire new Employee" +
                 "  3.Feed all animals" +
                 "  4.Heal all anmals" +
                 "  5.All sick animals" +
                 "  6.Last time of feed" +
                 " 7.Exit" +
                 "Enter first name new employee:" +
                 "Enter last name new employee:" +
                 "Enter loccation of zoo:"+
                 "Location: 5/4 "+
                 "Location: 8/2 "+
                 "Chose profession: "+
                 " 1.Veterinarian " +
                 " 2.ZooKeeper"+
                 "Animal experience:" +
                " 1.Bison " +
                " 2.Lion " +
                " 3.Elephant " +
                " 4.Parrot " +
                " 5.Penguin " +
                " 6.Snake " +
                " 7.Turle";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShoulBeAbleToThrowExeption()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("f");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                 " 1.Look all information about all Zoos." +
                 "  2.Hire new Employee" +
                 "  3.Feed all animals" +
                 "  4.Heal all anmals" +
                 "  5.All sick animals" +
                 "  6.Last time of feed" +
                 " 7.Exit" +
                 "No valid command! ";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShoulBeAbleToHireNewEmployeeAllAnimal2()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("2");
            _stringBuilder.AppendLine("Ger");
            _stringBuilder.AppendLine("Gir");
            _stringBuilder.AppendLine("5/4");
            _stringBuilder.AppendLine("2");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                 " 1.Look all information about all Zoos." +
                 "  2.Hire new Employee" +
                 "  3.Feed all animals" +
                 "  4.Heal all anmals" +
                 "  5.All sick animals" +
                 "  6.Last time of feed" +
                 " 7.Exit" +
                 "Enter first name new employee:" +
                 "Enter last name new employee:" +
                 "Enter loccation of zoo:" +
                 "Location: 5/4 " +
                 "Location: 8/2 " +
                 "Chose profession: " +
                 " 1.Veterinarian " +
                 " 2.ZooKeeper" +
                 "Animal experience:" +
                " 1.Bison " +
                " 2.Lion " +
                " 3.Elephant " +
                " 4.Parrot " +
                " 5.Penguin " +
                " 6.Snake " +
                " 7.Turle";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShoulBeAbleToHireNewEmployeeAllAnimal3()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("2");
            _stringBuilder.AppendLine("Ger");
            _stringBuilder.AppendLine("Gir");
            _stringBuilder.AppendLine("5/4");
            _stringBuilder.AppendLine("3");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Program.Main(new string[0]);
            //ZooConsole.ConsoleMain(zooApp);
            var expectedResult = "Welcome to ZooLab! You can do next things." +
                 " 1.Look all information about all Zoos." +
                 "  2.Hire new Employee" +
                 "  3.Feed all animals" +
                 "  4.Heal all anmals" +
                 "  5.All sick animals" +
                 "  6.Last time of feed" +
                 " 7.Exit" +
                 "Enter first name new employee:" +
                 "Enter last name new employee:" +
                 "Enter loccation of zoo:" +
                 "Location: 5/4 " +
                 "Location: 8/2 " +
                 "Chose profession: " +
                 " 1.Veterinarian " +
                 " 2.ZooKeeper" +
                 "Animal experience:" +
                " 1.Bison " +
                " 2.Lion " +
                " 3.Elephant " +
                " 4.Parrot " +
                " 5.Penguin " +
                " 6.Snake " +
                " 7.Turle";

            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShouldBeAbleChoseAnimals1()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("1");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Bison().ToString(), ZooConsole.ChoseAnimal());

        }

        [Fact]
        public void ShouldBeAbleChoseAnimals2()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("2");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Lion().ToString(), ZooConsole.ChoseAnimal());

        }

        [Fact]
        public void ShouldBeAbleChoseAnimals3()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("3");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Elephant().ToString(), ZooConsole.ChoseAnimal());

        }

        [Fact]
        public void ShouldBeAbleChoseAnimals4()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("4");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Parrot().ToString(), ZooConsole.ChoseAnimal());

        }

        [Fact]
        public void ShouldBeAbleChoseAnimals5()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("5");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Penguin().ToString(), ZooConsole.ChoseAnimal());

        }

        [Fact]
        public void ShouldBeAbleChoseAnimals6()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("6");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Snake().ToString(), ZooConsole.ChoseAnimal());

        }

        [Fact]
        public void ShouldBeAbleChoseAnimals7()
        {
            ZooApp zooApp = new ZooApp();

            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("7");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);

            Assert.Equal(new Turtle().ToString(), ZooConsole.ChoseAnimal());

        }
    }
}