//using LegacyApp; //TODO ppm na Dependencies w testach > Reference > LegacyApp >> Zmienić .NET na 7.

using LegacyApp;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Add_User_Should_Return_False_When_Missing_FirstName()
    {
        var service = new UserService(); //TODO dodać referencje do LegacyApp
        var result = service.AddUser(null, null, "kowalski@wp.pl", new DateTime(1980,1,1), 1);
        Assert.False(result);
    }

    [SetUp]
    public void AddUser_Should_Throw_Exception_When_User_Does_Not_Exist()
    {
        var service = new UserService();
        Assert.Throws<ArgumentException>(() =>
        {
            _ = service.AddUser("John", "Unknown", "kowalsi@wp.pl", new DateTime(1980, 1, 1), 100);
        });
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}