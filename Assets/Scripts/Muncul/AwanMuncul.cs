using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwanMuncul: MonoBehaviour
{
    public float jeda = 1.5f;
    float timer;
    public GameObject[] obyekLine;

    void Start()
    {
    
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, obyekLine.Length);
            Instantiate(obyekLine[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}