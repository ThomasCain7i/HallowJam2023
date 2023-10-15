using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject enemy, fadeToBlackWin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enemy.SetActive(false);
            fadeToBlackWin.SetActive(true);
        }
    }
}
