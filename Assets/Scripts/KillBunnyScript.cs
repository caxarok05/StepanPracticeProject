using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KillBunnyScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> pointsList;
    [SerializeField] private GameObject bunnyPrefab;
    [SerializeField] private GameObject deathPanel;

    private void Start()
    {  
        SpawnScript.Spawn(bunnyPrefab, pointsList);
    }

    public void SpawnNewBunny()
    {
        SpawnScript.Spawn(bunnyPrefab, pointsList);
    }

    public void LoseGame()
    {
        UIManager.DisplayPanel(deathPanel);
    }
   

}
