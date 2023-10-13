using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu, crosshairMenu;
    public bool gameStarted = false;
    [SerializeField] float timer1 = 1, timer2 = 2, timer3 = 3;
    [SerializeField] Light light1, light2, light3;

    private void Start()
    {
        light1.enabled = false;
        light2.enabled = false;
        light3.enabled = false;
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            mainMenu.SetActive(false);
            crosshairMenu.SetActive(true);
            gameStarted = true;
        }

        if (gameStarted)
        {
            timer1 -= Time.deltaTime;
            timer2 -= Time.deltaTime;
            timer3 -= Time.deltaTime;
        }

        if (timer1 <= 0)
        {
            light1.enabled = true;
        }

        if (timer2 <= 0)
        {
            light2.enabled = true;
        }

        if (timer3 <= 0)
        {
            light3.enabled = true;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
