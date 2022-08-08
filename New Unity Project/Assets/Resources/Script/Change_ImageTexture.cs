using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_ImageTexture : MonoBehaviour
{
    public Texture2D tex;
    private Sprite sprite;

    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        //sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        }
    }

    public void ChangeSprite()
    {
        image.sprite = sprite;
    }
}
