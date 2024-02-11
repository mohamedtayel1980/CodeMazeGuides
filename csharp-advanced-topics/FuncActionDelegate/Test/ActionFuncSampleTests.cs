using FuncActionDelegate;

namespace Test
{
    [TestFixture]
    public class ActionFuncSampleTests
    {        
        [Test]
        public void GivenListOfNames_WhenGreetingIsCalled_ThenShouldPrintCorrectMessages()
        {
            var names = new List<string> { "Alice", "Bob", "Charlie" };
            var actionSample = new ActionSample();
            var output = new StringWriter();

            Console.SetOut(output);

            actionSample.Greeting(names);
            
            var outputString = output.ToString();

            StringAssert.Contains("Hello, Alice!", outputString);
            StringAssert.Contains("Hello, Bob!", outputString);
            StringAssert.Contains("Hello, Charlie!", outputString);
            
            Console.SetOut(Console.Out);
        }

        [Test]
        public void GivenListOfIntegers_WhenFilterAndSumIsCalled_ThenShouldReturnSumOfEvenNumbers()
        {

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var funcSample = new FuncSample();
            
            var result = funcSample.FilterAndSum(numbers);
            
            Assert.That(result, Is.EqualTo(30)); 
        }
    }
}