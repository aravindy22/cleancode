namespace TemplateEngine.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Aravind")]
    [TestCase("Y")]
    public void TestingForSingleVariable(string value)
    {
        //Arrange
        TemplateEngine templateEngine = new TemplateEngine();

        //Act
        templateEngine.SetTemplate("Hello {name}");
        templateEngine.SetVariable("name", value);
        string result = templateEngine.Evaluate();

        //Assert
        Assert.That("Hello " + value, Is.EqualTo(result));
    }

    [TestCase("Aravind", "Y")]
    [TestCase("Elon", "Musk")]
    public void TestingForTwoVariable(string firstName, string lastName)
    {
        //Arrange
        TemplateEngine templateEngine = new TemplateEngine();

        //Act
        templateEngine.SetTemplate("Hello {firstName} {lastName}");
        templateEngine.SetVariable("firstName", firstName);
        templateEngine.SetVariable("lastName", lastName);
        string result = templateEngine.Evaluate();

        //Assert
        Assert.That("Hello " + firstName + " " + lastName, Is.EqualTo(result));
    }
}