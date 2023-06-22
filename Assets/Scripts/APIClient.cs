using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft;
using Newtonsoft.Json;
using System;

public class APIClient : MonoBehaviour
{
    [SerializeField] private string URL = "https://randomuser.me/api/?results=20";
    [field:SerializeField] public Root Root { get; private set; }
    public Action DataReceived;
    private void Awake()
    {
        StartCoroutine(GetDataCO());
    }
    private IEnumerator GetDataCO() 
    {
        using (UnityWebRequest request = UnityWebRequest.Get(URL))
        {
            yield return request.SendWebRequest();

            if(request.result==UnityWebRequest.Result.ConnectionError)
                Debug.Log(request.error);
            else
            {
                string json = request.downloadHandler.text;
                Root = JsonConvert.DeserializeObject<Root>(json);      
                DataReceived?.Invoke();
            }
        }
    }
    
}
