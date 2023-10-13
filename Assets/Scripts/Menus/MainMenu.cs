using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    public bool gameStarted = false;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            mainMenu.SetActive(false);
            gameStarted = true;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
