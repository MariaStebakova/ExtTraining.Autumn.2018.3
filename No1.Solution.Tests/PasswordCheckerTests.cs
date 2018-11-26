using System;
using System.Linq;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerTests
    {
        [TestCase(null, false, "null is null arg")]
        [TestCase("", false, " is empty ")]
        [TestCase("1111", false, "1111 length too short")]
        [TestCase("1111111111111111", false, "1111111111111111 length too long")]
        [TestCase("1111111111", false, "11111111111 hasn't alphanumerical chars")]
        [TestCase("aaaaaaaaaa", false, "aaaaaaaaaa hasn't digits")]
        public (bool, string) Test_WithGivenConditions(string password, bool result, string stringResult)
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository(), null);
            return passwordChecker.VerifyPassword(password);
        }

        [TestCase("aaa,12345", false, "aaa,12345 doesn't correspond some of custom conditions")]
        public (bool, string) Test_WithCustomCondition(string password, bool result, string stringResult)
        {
            Func<string, bool> func1 = s => s.Any(char.IsPunctuation);
            Func<string, bool> func2 = s => !s.Any(char.IsUpper);
            var passwordChecker = new PasswordCheckerService(new SqlRepository(), new Func<string, bool>[] {func1, func2});
            return passwordChecker.VerifyPassword(password);
        }
    }
}
