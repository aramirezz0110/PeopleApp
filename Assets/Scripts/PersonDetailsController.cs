using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonDetailsController : MonoBehaviour
{
    [SerializeField] private Image photo;
    [SerializeField] private TMP_Text emailText;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text ageText;
    [SerializeField] private TMP_Text genderText;
    [SerializeField] private TMP_Text cityText;
    public void SetInfo(Sprite photo, string email, string name, string age, string gender, string city)
    {
        this.photo.sprite= photo;
        emailText.text= email;
        nameText.text= name;
        ageText.text= age;
        genderText.text= gender;
        cityText.text= city;
    }
}
