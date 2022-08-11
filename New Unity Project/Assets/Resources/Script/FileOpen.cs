using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

using UnityEngine.UI;
//using System.Windows.Forms;

public class FileOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public void Open()
    {
        /*OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter =  "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
        ofd.Title = "テキストファイルを選択してください";
        ofd.ShowDialog();

        string filePath = ofd.FileName;

        Debug.Log(filePath);*/

        //パスの取得
        /*var path = EditorUtility.OpenFilePanel("Image files", "", "png,jpg");
        if (string.IsNullOrEmpty(path))
            return;
        Debug.Log(path);*/

        //読み込み
        /*var reader = new StreamReader(path);
        Debug.Log(reader);*/
    }
}
