using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderNumericDelimiter : MonoBehaviour
{
    [SerializeField]
    private int Unit_Separator = 1; // 区切り単位

    // N単位で区切る
    public float Delimiter()
    {
        float sliderValue = GetComponent<Slider>().value;

        sliderValue = Mathf.Round(sliderValue / Unit_Separator) * Unit_Separator;

        return sliderValue;
    }
}
