using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MyFirstTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void MyFirstTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MyFirstTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    [Test]

    public void WinLoseTest()
    {
        WinCondition winCondition = new WinCondition();
        // a test that checks istrue when the score given is between 5-1000 always passes
        for (int i = 5; i <= 1000; i++)
        {
            Assert.IsTrue(winCondition.CheckWinOrLose(i));
        }
        // now the random input which can also fail

        int randomNum = Random.Range(-1000, 1000);
        Assert.IsTrue(winCondition.CheckWinOrLose(randomNum));

        // i did a part where the test always passes and a part where the failure comes into play
        // i did it this way for fully grasping how the test work and to see if i can be certian where it will pass or fail
    }

}
