// CommonStepDefinitions.cs
using ICT3101_Calculator;
using SpecFlowCalculatorTests.Support;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CommonStepDefinitions
    {
        private readonly CalculatorContext _context;

        public CommonStepDefinitions(CalculatorContext context)
        {
            _context = context;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _context.CalculatorInstance = new Calculator();
        }
    }
}
