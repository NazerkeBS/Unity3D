using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;


namespace Tests
{
    public class UnitTestScript
    {
       
        // Trivial test cases
        [Test]
        public void LevelOne()
        {
            GameObject modelEiffel = GameObject.Find("Eiffel");
            Assert.AreEqual("Eiffel", modelEiffel.name);

            Assert.AreEqual(SceneManager.GetActiveScene().name, string.Empty);
            Transform flag = GameObject.Find("Flag").transform;
            Assert.AreEqual(flag.rotation.y, 0);
            Assert.AreEqual(flag.rotation.z, 0);
            Assert.AreEqual( flag.name, "Flag");

            var choices = GameObject.Find("Level1Manager").GetComponentInChildren<Transform>();
            Assert.AreEqual(choices.childCount, 4);

            //check names of the choices children
            Assert.AreEqual(choices.GetChild(0).name, "ChoiceA");
            Assert.AreEqual(choices.GetChild(1).name, "ChoiceB");
            Assert.AreEqual(choices.GetChild(2).name, "ChoiceC");
            Assert.AreEqual(choices.GetChild(3).name, "ChoiceD");
            var timeWaiter = GameObject.Find("TimeWaiter").GetComponent<Transform>();
            Assert.AreEqual(timeWaiter.name, "TimeWaiter");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
