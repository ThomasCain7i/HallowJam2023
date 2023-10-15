using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject enemy, fadeToBlackWin, winMessage;
    [SerializeField] MainMenu mainMenu;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            fadeToBlackWin.SetActive(true);
            enemy.SetActive(false);
            winMessage.SetActive(true);
            mainMenu.gameStarted = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
