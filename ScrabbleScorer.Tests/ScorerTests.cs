using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScorer.Models;


namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class LetterTests
  {
    // Test methods go here
    public void LetterConstructor_CreatesInstanceOfLetter_Letter()
    {
      Letter newLetter = new Letter();
      Assert.AreEqual(typeof(Letter), newLetter.GetType());
    }


 //     [TestMethod]
 // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
 // {
 //   // any necessary logic to prep for test; instantiating new classes, etc.
 //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
 // }
  }
}