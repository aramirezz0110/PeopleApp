using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft;
using Newtonsoft.Json;

public class APIClient : MonoBehaviour
{
    [SerializeField] private string URL = "https://randomuser.me/api/?results=20";
    public Root root;
    private void Start()
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
                root = JsonConvert.DeserializeObject<Root>(json);
                print(root.info.version);
            }

        }
    }
    public Root GetData()
    {
        StartCoroutine(GetDataCO());
        return root;
    }
}
