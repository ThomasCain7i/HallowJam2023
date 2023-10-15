using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu, crosshairMenu;
    public bool gameStarted = false;
    [SerializeField] float timer1, timer2, timer3, timer4, timer5, timer6;
    [SerializeField] Light light1, light2, light3, light4, light5, light6;
    [SerializeField] AudioSource audioSource1, audioSource2, audioSource3, audioSource4, audioSource5, audioSource6;

    private void Start()
    {
        light1.enabled = false;
        light2.enabled = false;
        light3.enabled = false;
        light4.enabled = false;
        light5.enabled = false;
        light6.enabled = false;
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
            timer4 -= Time.deltaTime;
            timer5 -= Time.deltaTime;
            timer6 -= Time.deltaTime;
        }

        if (timer1 <= 0)
        {
            light1.enabled = true;
            audioSource1.Play();
        }

        if (timer2 <= 0)
        {
            light2.enabled = true;
            audioSource2.Play();
        }

        if (timer3 <= 0)
        {
            light3.enabled = true;
            audioSource3.Play();
        }

        if (timer4 <= 0)
        {
            light4.enabled = true;
            audioSource4.Play();
        }

        if (timer5 <= 0)
        {
            light5.enabled = true;
            audioSource5.Play();
        }

        if (timer6 <= 0)
        {
            light6.enabled = true;
            audioSource6.Play();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
