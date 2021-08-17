using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{

    public GameObject player;
    public GameObject gamePaused;

    public Text scoreText;

    void Start()
    {
        gamePaused.SetActive(false);
        player.SetActive(true);
    }

    void Update()
    {
        
    }
}
