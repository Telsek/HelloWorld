using HelloWorld;

// checks the app prints the right text - if someone changes it, the pipeline fails here
public class GreetingTests
{
    [Fact]
    public void Get_returns_hello_world()
    {
        Assert.Equal("Hello, World!", Greeting.Get());
    }
}