
namespace TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]

    public void FechaCorrecta()
    {
        string input = "20/09/2002";
        string expected = "2002-09-20";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
    public void SrtingVacio()
    {
        string input = "";
        string expected = "";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
    public void Invertida()
    {
        string input = "20/09/2002";
        string expected = "2002-09-20";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
}