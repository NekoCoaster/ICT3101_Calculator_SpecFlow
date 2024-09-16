Feature: UsingCalculatorAddition
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculatorTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Addition
Scenario: Add two numbers
	Given I have a calculator
	When I have entered 50 and 70 into the calculator and press add
	Then the result should be 120