using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePatrol : MonoBehaviour
{
    public float moveSpeed = 1;
    public Animator animator;
    //float xRight;
    float moveDis = 1;
    Vector3 localScale;
    bool isMoveRight = true;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //xRight = (Screen.width - 32) / 100;

        if (transform.position.x > moveDis)
        {
            isMoveRight = false;
        }

        if(transform.position.x < -moveDis)
        {
            isMoveRight = true;
        }

        if (isMoveRight)
            moveRight();
        else
            moveLeft();

        animator.SetBool("IsMoveRight", true);
        transform.Translate(new Vector3(localScale.x, 0, 0) * moveSpeed * Time.deltaTime);
    }

    void moveRight()
    {
        isMoveRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
    }

    void moveLeft()
    {
        isMoveRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
    }
}
