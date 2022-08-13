using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugTextureIndex : MonoBehaviour
{
    [SerializeField]
    private GameObject TextureUIObject;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "テクスチャ配列の添え字： " + TextureUIObject.GetComponent<Change_ImageTexture>().GetTextureIndex();
    }
}
