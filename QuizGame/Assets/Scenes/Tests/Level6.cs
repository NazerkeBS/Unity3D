using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Level6
    {
        // A Test behaves as an ordinary method
        //This class tests the Scene 24
        [Test]
        public void LevelSix()
        {
            var children = GameObject.Find("ChoiceManager").GetComponentInChildren<Transform>();
            var cityA = children.GetChild(0).GetChild(0).GetComponent<Transform>().name;
            Assert.AreEqual(cityA, "ChoiceAText");

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Level6WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
