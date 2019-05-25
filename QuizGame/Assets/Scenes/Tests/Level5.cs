using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Level5
    {
        // A Test behaves as an ordinary method
        // This test is based on the Scene 19
        [Test]
        public void LevelFive()
        {
            Transform textField = GameObject.Find("Text Area").GetComponentInChildren<Transform>();
            Assert.AreEqual(textField.childCount, 2);
            Assert.AreEqual(textField.GetChild(1).name, "Text");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Level5WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
