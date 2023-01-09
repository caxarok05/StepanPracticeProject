using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public static void Spawn(GameObject bunnyPrefab, List<GameObject> pointsList)
    {
        Instantiate<GameObject>(bunnyPrefab, pointsList[Random.Range(0, pointsList.Count)].transform.position, Quaternion.identity);
    }
}
