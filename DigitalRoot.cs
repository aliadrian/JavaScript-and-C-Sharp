using NUnit.Framework;

public class Number
{
  public static int DigitalRoot(long n)
  {
    string s = n.ToString();
    int sum = 0;
    foreach (char c in s)
    {
      // This converts the char to an int
      int x = c - '0';
      sum += x;
    }

    sum.ToString();

    int newSum;
    if (sum.ToString().Length >= 2)
    {
      newSum = DigitalRoot(sum);
    }
    else
    {
      return sum;
    }

    return newSum;
  }
}

[TestFixture]
public class NumberTest
{
  [TestCase(0, ExpectedResult = 0)]
  [TestCase(10, ExpectedResult = 1)]
  [TestCase(16, ExpectedResult = 7)]
  [TestCase(195, ExpectedResult = 6)]
  [TestCase(992, ExpectedResult = 2)]
  [TestCase(167346, ExpectedResult = 9)]
  [TestCase(999999999999, ExpectedResult = 9)]
  public int Tests(long n)
  {
    return Number.DigitalRoot(n);
  }
}