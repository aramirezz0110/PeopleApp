using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PersonCardController : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text personName;
    [SerializeField] private Button button;

    private void OnEnable()
    {
        button?.onClick.AddListener(OnButtonClicked);
    }
    private void OnDisable()
    {
        button?.onClick.RemoveAllListeners();
    }

    private void OnButtonClicked()
    {
        GameManager.Instance.CardClicked(id);
    }

    public void SetInfo(string name)
    {        
        personName.text = name;
    }
    public void SetPhoto(Sprite photo)
    {        
        image.sprite = photo;
    }
}
