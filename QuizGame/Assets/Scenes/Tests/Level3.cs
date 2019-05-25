using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Level3
    {
        // A Test behaves as an ordinary method
        // This class tests the Scene 12
        [Test]
        public void LevelThree()
        {
            var hints = GameObject.Find("HintManager").GetComponentInChildren<Transform>();
            Assert.AreEqual(hints.childCount, 4);
            var music = GameObject.Find("nameMusicPlayer").GetComponent<AudioSource>();
            Assert.AreEqual(music.playOnAwake, false);
              
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Level3WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
