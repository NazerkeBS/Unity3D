using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Level4
    {
        // A Test behaves as an ordinary method
        // This test tests the Scene 16
        [Test]
        public void LevelFour()
        {
            GameObject choiceA = GameObject.Find("TextAPro");
            Assert.AreEqual(choiceA.name, "TextAPro");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Level4WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
