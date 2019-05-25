using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine;

namespace Tests
{
    public class Level2
    {
        // A Test behaves as an ordinary method
        // This test is for testing Scene7 and Level 2
        [Test]
        public void LevelTwo()
        {
            GameObject model = GameObject.Find("Model");
            Assert.AreEqual(model.GetComponentInChildren<Transform>().GetChild(0).name, "SagradaFamilia");
            GameObject letterBoard = GameObject.Find("LetterBoard");
            var children = letterBoard.GetComponentInChildren<Transform>();
            Assert.AreEqual(children.childCount, 2);
            Assert.AreEqual(children.GetChild(0).name, "CorrectAnswer");
            Assert.AreEqual(children.GetChild(1).name, "SelectLetters");
            Assert.AreEqual(children.GetChild(1).childCount, 11);
            Assert.AreEqual(children.GetChild(1).GetChild(0).name,"l");
            Assert.AreEqual(children.GetChild(1).GetChild(1).name, "a");
            Assert.AreEqual(children.GetChild(1).GetChild(2).name, "p");
            Assert.AreEqual(children.GetChild(1).GetChild(3).name, "n");
            Assert.AreEqual(children.GetChild(1).GetChild(4).name, "m");
            Assert.AreEqual(children.GetChild(1).GetChild(5).name, "i");
            Assert.AreEqual(children.GetChild(1).GetChild(6).name, "b");
            Assert.AreEqual(children.GetChild(1).GetChild(7).name, "o");
            Assert.AreEqual(children.GetChild(1).GetChild(8).name, "r");
            Assert.AreEqual(children.GetChild(1).GetChild(9).name, "e");
            Assert.AreEqual(children.GetChild(1).GetChild(10).name, "c");

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Level2WithEnumeratorPasses()
        {
            yield return null;
        }
    }
}
