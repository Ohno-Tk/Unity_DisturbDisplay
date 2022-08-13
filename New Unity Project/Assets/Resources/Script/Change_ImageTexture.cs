using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Change_ImageTexture : MonoBehaviour
{
    private string path = Application.dataPath + "/TextureList.txt";
    private List<string> TexturePathList;
    private List<Texture2D> Texture2DList;
    private List<Sprite> SpriteList;
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            TexturePathList = new List<string>();
            Texture2DList = new List<Texture2D>();
            SpriteList = new List<Sprite>();
            image = GetComponent<Image>();
        }
        catch
        {
            Debug.Log("Change_ImageTexture.csでERRORとなりました。");
            UnityEditor.EditorApplication.isPaused = true;
        }

        // テキストファイル読み込み
        LoadText();

        // テクスチャ読み込み
        foreach(string i in TexturePathList)
        {
            Texture2D tex = Resources.Load<Texture2D>(i);
            Debug.Log(tex);
            Texture2DList.Add(tex);
        }

        Sprite sprite;
        foreach(Texture2D j in Texture2DList)
        {
            // スプライト生成
            sprite = CreateSprite(j);
            SpriteList.Add(sprite);
        }

        Debug.Log("スプライトテクスチャ総数；" + SpriteList.Count);

        // スプライト変更
        ReplaceSprite(SpriteList[0]);
    }

    // スプライト変更
    public void ReplaceSprite(Sprite sprite)
    {
        image.sprite = sprite;
    }

    // スプライト変更 ランダム
    public void RandomReplaceSprite()
    {
        int random = Random.Range(0, SpriteList.Count);

        Debug.Log("ランダムテクスチャ：" + random);

        image.sprite = SpriteList[random];
    }

    // テキストファイル読み込み
    private void LoadText()
    {
        string file = "";
        var filesystem = new StreamReader(path, System.Text.Encoding.GetEncoding("UTF-8"));

        // 1行ずつ読み込む
        while (filesystem.Peek() != -1)
        {
            file = filesystem.ReadLine();
            Debug.Log(file);
            TexturePathList.Add(file);
        }
    }

    // Texture2DからSpriteを作成
    private Sprite CreateSprite(Texture2D tex)
    {
        return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
    }
}
