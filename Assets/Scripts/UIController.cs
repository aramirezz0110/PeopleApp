using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject loadingPanel;
    [SerializeField] private GameObject peopleListPanel;
    [SerializeField] private GameObject personInfoPanel;
    [SerializeField] private PersonCardController[] personCardControllers;
    [SerializeField] private List<Sprite> photos=new List<Sprite>();
    private void Start()
    {
        ActivatePanel(loadingPanel);
    }
    public void ActivatePeopleListPanel() => ActivatePanel(peopleListPanel);
    public void ActivatePeopleInfoPanel() => ActivatePanel(personInfoPanel);
    public void LoadPersonCardsInfo(Result[] results)
    {
        StartCoroutine(DownloadImage(results));
        for (int i=0; i < 20; i++)
        {
            string personName = results[i].name.title;
            personName += $" {results[i].name.first}";
            personName += $" {results[i].name.last}";
                        
            personCardControllers[i].SetInfo(personName);            
        }        
        ActivatePeopleListPanel();
    }
    private void ActivatePanel(GameObject panel)
    {
        string panelName=panel.name;
        loadingPanel.SetActive(loadingPanel.name.Equals(panelName));
        peopleListPanel.SetActive(peopleListPanel.name.Equals(panelName));
        personInfoPanel.SetActive(personInfoPanel.name.Equals(panelName));
    }
    private IEnumerator DownloadImage(Result[] results)
    {
        foreach (Result item in results)
        {
            string url = item.picture.medium;
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.ConnectionError)
                Debug.Log(request.error);
            else
            {
                Texture2D webTexture = ((DownloadHandlerTexture)request.downloadHandler).texture as Texture2D;
                Sprite webSprite = SpriteFromTexture2D(webTexture);
                photos.Add(webSprite);                
            }
        }     
        for(int i = 0; i < 20; i++)
        {
            personCardControllers[i].SetPhoto(photos[i]);
        }
    }

    Sprite SpriteFromTexture2D(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
    }
}
