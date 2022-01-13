double failCounter = 1;
double numberCheck = 3;
double totalResultSum = 0;

while(failCounter < 100000)
{
    double numberSum = 0;
    string strNumCheck = numberCheck.ToString();

    foreach(char c in strNumCheck)
    {
        numberSum = numberSum + Factorial(Convert.ToDouble(c.ToString()));
    }
    if(numberSum == numberCheck)
    {
        totalResultSum = totalResultSum + numberCheck;
        failCounter = 0;
    }
    failCounter++;
    numberCheck++;
}

Console.WriteLine("The sum of all numbers which are equal to the sum of the factorial of their digits is: " + totalResultSum);

double Factorial(double x)
{
    double result = 1;

    for(double i = x; i > 0; i--)
    {
        result = result * i;
    }

    return result;
}
