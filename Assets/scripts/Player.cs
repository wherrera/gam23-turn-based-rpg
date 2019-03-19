using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 1F;

    public SpriteRenderer walk;

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        if(Horizontal > 0f)
        {
            walk.flipX = false;
        }
        else if (Horizontal < 0f)
        {
            walk.flipX = true;
        }

        transform.position += (new Vector3(Horizontal, Vertical, 0f) * speed) * Time.deltaTime;
    }
}
