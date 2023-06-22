using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("REFERENCES")]
    [SerializeField] private UIController uiController;
    [SerializeField] private APIClient apiClient;

    [field:SerializeField]public Root Root { get; private set; }

    private void Awake()
    {
        if(!Instance)
            Instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        apiClient.DataReceived += LoadPeopleList;
    }

    private void LoadPeopleList()
    {
        Root = apiClient.Root;        
        uiController.LoadPersonCardsInfo(Root.results);
    }
}
