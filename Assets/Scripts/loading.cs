using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    [SerializeField] private float delayLoading = 5f;
    [SerializeField] private string Gameplay1;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayLoading)
        {
            SceneManager.LoadScene("Gameplay1");
        }
    }
}