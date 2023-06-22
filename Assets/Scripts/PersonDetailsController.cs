using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PersonDetailsController : MonoBehaviour
{
    [SerializeField] private RawImage photo;
    [SerializeField] private TMP_Text emailText;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text ageText;
    [SerializeField] private TMP_Text genderText;
    [SerializeField] private TMP_Text cityText;
}
