using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float batasAtas;
    public float batasBawah;
    public float kecepatan;

    public string axis;

    public GameObject gameOverWin;
    public GameObject gameOverLose;
    public GameObject obstacleLine;
    public GameObject loveShow;
    public GameObject coinShow;
    public GameObject scoreShow;
    public GameObject LevelShow;


    public Text coinText;
    public Text loveText;
    public Text scoreText;
    public Text levelText;

    private int count;
    private int count2;

    private float gameScore;

    void Start()
    {
        count = 0;
        count2 = 3;
        SetPoinText();
        SetLoveText();
        obstacleLine.SetActive(true);
        coinShow.SetActive(true);
        loveShow.SetActive(true);
        scoreShow.SetActive(true);
        LevelShow.SetActive(true);
        gameOverWin.SetActive(false);
        gameOverLose.SetActive(false);
        levelText.text = "LEVEL  1";
    }


    void Update()
    {
        float gerak = Input.GetAxis(axis) * kecepatan * Time.deltaTime;
        float nextPos = transform.position.y + gerak;
        if (nextPos > batasAtas)
        {
            gerak = 0;
        }
        if (nextPos < batasBawah)
        {
            gerak = 0;
        }
        transform.Translate(0, gerak, 0);

        gameScore += Time.deltaTime;
        scoreText.text = "\nSCORE: " + Mathf.Floor(gameScore);
        if (gameScore > 30)
        {
            levelText.text = "LEVEL  2";
        }
        if (gameScore > 60)
        {
            gameOverWin.SetActive(true);
            gameOverLose.SetActive(false);
            obstacleLine.SetActive(false);
            coinShow.SetActive(false);
            loveShow.SetActive(false);
            scoreShow.SetActive(false);
            LevelShow.SetActive(false);
        }
    }

    void SetPoinText()
    {
        coinText.text = count.ToString() + "x";
    }

    void SetLoveText()
    {
        loveText.text = count2.ToString() + "x";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("poinCoin"))
        {
            Debug.Log("Player kena poin");
            other.gameObject.SetActive(false);
            count = count + 1;
            SetPoinText();
        }
        if (other.gameObject.CompareTag("poinLove"))
        {
            other.gameObject.SetActive(false);
            count2 = count2 + 1;
            SetLoveText();
        }
        if (other.gameObject.CompareTag("obstacleCone"))
        {
            other.gameObject.SetActive(false);
            count2 = count2 - 1;
            SetLoveText();
            if (count2 == 0)
            {
                gameObject.SetActive(false);
                gameOverLose.SetActive(true);
                obstacleLine.SetActive(false);
                coinShow.SetActive(false);
                loveShow.SetActive(false);
                scoreShow.SetActive(false);
                LevelShow.SetActive(false);
            }
        }     
        if (other.gameObject.CompareTag("obstacleHole"))
        {
            gameOverLose.SetActive(true);
            obstacleLine.SetActive(false);
            coinShow.SetActive(false);
            loveShow.SetActive(false);
            scoreShow.SetActive(false);
            LevelShow.SetActive(false);
        }
    }
}