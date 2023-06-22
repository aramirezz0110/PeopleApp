using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonCardController : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text personName;

    public void SetInfo(string name)
    {        
        personName.text = name;
    }
    public void SetPhoto(Sprite photo)
    {        
        image.sprite = photo;
    }
}
