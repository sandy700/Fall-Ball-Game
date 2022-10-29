using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewBackgroundChange : MonoBehaviour
{

    [Header("Drag & Drop the backgound image")]
    public Image backgoundImage;

    public List<Sprite> allBackgroundImage = new List<Sprite>();

    void OnEnable()
    {
        Scrolling.ChangeBackground += ChangeBackgroundImage;
    }

    void OnDisable()
    {
        Scrolling.ChangeBackground -= ChangeBackgroundImage;
    }

    ///<Summary>
    /// This is for changing the background sprite based on scroll value
    ///<_index> sprite Number
    public void ChangeBackgroundImage(int _indexNumber)
    {
        backgoundImage.sprite = allBackgroundImage[_indexNumber];
    }
}
