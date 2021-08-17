using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    public bool isEscapeToExit;

    public GameObject creditGame;

    void Start()
    {
        creditGame.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Application.Quit();
            }
            else
            {
                KembaliKeMenu();
            }
        }
    }

    public void MulaiPermainan()
    {
        SceneManager.LoadScene("Gameplay1");
    }

    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void GameCredit()
    {
        creditGame.SetActive(true);
    }

    public void KeluarGame()
    {
        Application.Quit();
    }

    public void LoadingGame()
    {
        SceneManager.LoadScene("Loading");
    }

    public void yakinKeluar()
    {
        SceneManager.LoadScene("exit");
    }
}