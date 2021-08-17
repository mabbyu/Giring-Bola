using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindahAwan : MonoBehaviour
{
    float speed = 3f;
    public Sprite[] sprites;

    void Start()
    {
        int index = Random.Range(0, sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }


    void Update()
    {
        float move = (speed * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector3(move, transform.position.y);
    }
}