using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBehaviour : MonoBehaviour
{
    private GameObject deathPanel;
    private KillBunnyScript KillBunnyScript;
    private IEnumerator coroutine;

    private void Start()
    {
        coroutine = BunnyDisapear();
        StartCoroutine(coroutine);
        KillBunnyScript = GameObject.FindWithTag("manager").GetComponent<KillBunnyScript>();
        deathPanel = GameObject.FindWithTag("Panel");
    }
    private void OnMouseDown()
    {
        ScoreScript.Instance.score++;
        Destroy(gameObject);
        KillBunnyScript.SpawnNewBunny();
    }

    private IEnumerator BunnyDisapear()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
        KillBunnyScript.LoseGame();
    }
    
}
