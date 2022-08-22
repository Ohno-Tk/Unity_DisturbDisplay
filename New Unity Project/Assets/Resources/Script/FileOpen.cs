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
    [SerializeField]
    private GameObject ScrollViewObject_Content;
    [SerializeField]
    private GameObject TextPrefabObject;
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
        var dlg = new OpenFileDialog();
        dlg.Filter = "png(*.png)|*.png|jpg(*.jpg)|*.jpg|All files(*.*)|*.*";
        dlg.CheckFileExists = false;
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            //  ...
            //MessageBox.Show(dlg.FileName);

            string path = dlg.FileName;
            Debug.Log("ファイルパス名：" + path);
            Debug.Log("ファイル名：" + System.IO.Path.GetFileName(path));

            // リストに追加
            ImagePathList.Add(path);

            // スクロールビューに登録
            GameObject Obj = (GameObject)Instantiate (TextPrefabObject, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            Obj.transform.parent = ScrollViewObject_Content.transform;
            Vector3 Pos = Obj.GetComponent<RectTransform>().localPosition;
            Obj.GetComponent<RectTransform>().localPosition = new Vector3(Pos.x, Pos.y, 1.0f);
            Obj.GetComponent<RectTransform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Obj.GetComponent<Text>().text = System.IO.Path.GetFileName(path);
        }
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

        // スクロールビューのテキストを削除
        foreach(Transform i in ScrollViewObject_Content.transform )
        {
            GameObject.Destroy(i.gameObject);
        }

        Debug.Log("リストを削除しました～");
    }
}
