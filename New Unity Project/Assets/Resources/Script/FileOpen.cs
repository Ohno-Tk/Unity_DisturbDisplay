using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class FileOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public void Open()
    {
        //パスの取得
        var path = EditorUtility.OpenFilePanel("Image files", Application.dataPath, "png,jpg");
        if (string.IsNullOrEmpty(path))
            return;
        Debug.Log(path);

        //読み込み
        var reader = new StreamReader(path);
        Debug.Log(reader);
    }
}
