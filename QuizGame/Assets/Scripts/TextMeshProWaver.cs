using System.Collections;
using UnityEngine;
using TMPro;

public class TextMeshProWaver : MonoBehaviour
{

    private TextMeshPro textpro;
    public float CurveScale = 1.0f;
    private struct VertexAnim {

        //public float angleRange;
        // public float angle;
        public float speed;
    }

    public AnimationCurve VertexCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(0.25f, 2.0f), new Keyframe(0.5f, 0), new Keyframe(0.75f, 2.0f), new Keyframe(1, 0f));

    private void Awake()
    {
        textpro = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        textpro.ForceMeshUpdate();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimateVertexPositions());
        
    }
    IEnumerator AnimateVertexPositions() {
        VertexCurve.preWrapMode = WrapMode.Loop;
        VertexCurve.postWrapMode = WrapMode.Loop;
        Vector3[] newVertexPositions;
        int loopCount = 0;
        while (true) {
            textpro.renderMode = TextRenderFlags.DontRender;
            textpro.ForceMeshUpdate();
            TMP_TextInfo textInfo = textpro.textInfo;
            int charCount = textInfo.characterCount;
            newVertexPositions = textInfo.meshInfo[0].vertices;
            for(int i=0; i<charCount; i++)
            {
                if (!textpro.textInfo.characterInfo[i].isVisible) {
                    continue;
                }
                int vertexIndex = textpro.textInfo.characterInfo[i].vertexIndex;
                float offsetY = VertexCurve.Evaluate((float)i / charCount + loopCount / 50f)*CurveScale;

                newVertexPositions[vertexIndex + 0].y += offsetY;
                newVertexPositions[vertexIndex + 1].y += offsetY;
                newVertexPositions[vertexIndex + 2].y += offsetY;
                newVertexPositions[vertexIndex + 3].y += offsetY;
            }
            loopCount += 1;
            textpro.mesh.vertices = newVertexPositions;
            textpro.mesh.uv = textpro.textInfo.meshInfo[0].uvs0;
            textpro.mesh.uv2 = textpro.textInfo.meshInfo[0].uvs2;
            textpro.mesh.colors32 = textpro.textInfo.meshInfo[0].colors32;

            yield return new WaitForSeconds(0.025f);


        }

    }


}
