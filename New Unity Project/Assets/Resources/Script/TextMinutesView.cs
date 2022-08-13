using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMinutesView : MonoBehaviour
{
    [SerializeField]
    private Slider SliderUI;

    // Start is called before the first frame update
    void Start()
    {
        TextShow();
    }

    public void TextShow()
    {
        GetComponent<Text>().text = SliderUI.GetComponent<SliderNumericDelimiter>().Delimiter() + "分";
    }
}
