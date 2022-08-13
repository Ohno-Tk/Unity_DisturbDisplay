using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Change_ImageTexture : MonoBehaviour
{
    private List<Sprite> SpriteList;
    private Image image;
    private int TextureIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            SpriteList = new List<Sprite>();
            image = GetComponent<Image>();
        }
        catch
        {
            Debug.Log("Change_ImageTexture.csでERRORとなりました。");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPaused = true;
#elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
#endif
        }
    }

    // スプライト変更
    public void ReplaceSprite(Sprite sprite)
    {
        image.sprite = sprite;
    }

    // スプライト変更 ランダム
    public void RandomReplaceSprite()
    {
        TextureIndex = Random.Range(0, SpriteList.Count);

        Debug.Log("ランダムテクスチャ：" + TextureIndex);

        image.sprite = SpriteList[TextureIndex];
    }

    public int GetTextureIndex()
    {
        return TextureIndex;
    }

    public void DebugSpriteCount()
    {
        Debug.Log("スプライトテクスチャ総数；" + SpriteList.Count);
    }

    public void ListAllClear()
    {
        SpriteList.Clear();
    }

    // スプライト作成
    public void CreateSprite(string imagePath)
    {
        // バイナリで読み込み
        FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
        BinaryReader bin = new BinaryReader(fileStream);
        byte[] values = bin.ReadBytes((int)bin.BaseStream.Length);

        bin.Close();

        // Texture2D生成
        Texture2D texture = new Texture2D(1, 1);
        texture.LoadImage(values);

        // Sprite生成
        Sprite sprite = Texture2DConvertSprite(texture);
        SpriteList.Add(sprite);

        // スプライト変更
        ReplaceSprite(SpriteList[0]);
    }

    // Texture2DからSpriteを作成
    private Sprite Texture2DConvertSprite(Texture2D tex)
    {
        return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
    }
}
