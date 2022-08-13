using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System.Windows.Forms;

public class FileOpen : MonoBehaviour
{
    [SerializeField]
    private GameObject TextureUIObject;
    private List<string> ImagePathList;
    private Change_ImageTexture imagetexture;

    // Start is called before the first frame update
    void Start()
    {
        ImagePathList = new List<string>();
        imagetexture = TextureUIObject.GetComponent<Change_ImageTexture>();
    }

    public void Open()
    {
        //パスの取得
        var path = EditorUtility.OpenFilePanel("Image files", "", "png,jpg");
        if (string.IsNullOrEmpty(path)){return;}

        Debug.Log(path);

        // リストに追加
        ImagePathList.Add(path);
    }

    // スプライトの作成
    public void CreateSprite()
    {
        foreach(string i in ImagePathList)
        {
            imagetexture.CreateSprite(i);
        }

        imagetexture.DebugSpriteCount();
    }

    // リストの全クリア
    public void ClearList()
    {
        ImagePathList.Clear();
        imagetexture.ListAllClear();

        Debug.Log("リストを削除しました～");
    }
}
