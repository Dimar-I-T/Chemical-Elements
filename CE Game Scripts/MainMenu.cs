using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject suaraKlik;

    public void Main()
    {
        SceneManager.LoadScene(1);
    }

    public void Keluar()
    {
        Application.Quit();
    }

    public void Klik()
    {
        Instantiate(suaraKlik, transform.position, transform.rotation);
    }
}
