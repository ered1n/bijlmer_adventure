using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {

    public float moveSpeed;
    public float moveInterval;
    public float moveTime;

    private Rigidbody2D enemyRigidBody;
    private bool isMoving;
    private Vector3 moveDirection;

    private float moveIntervalCounter;
    private float moveTimeCounter;

    void Start()
    {
        //moveIntervalCounter = moveInterval;
        //moveTimeCounter = moveTime;
        enemyRigidBody = GetComponent<Rigidbody2D>();
        moveIntervalCounter = Random.Range(moveTime * 0.75f, moveIntervalCounter * 1.25f);
        moveTimeCounter = Random.Range(moveTime * 0.75f, moveIntervalCounter * 1.25f);
    }

    void Update()
    {
        if (isMoving)
        {
            moveTimeCounter -= Time.deltaTime;
            enemyRigidBody.velocity = moveDirection;

            if (moveTimeCounter < 0f)
            {
                //moveIntervalCounter = moveInterval;
                moveIntervalCounter = Random.Range(moveTime * 0.75f, moveIntervalCounter * 1.25f);
                isMoving = false;
            }

        }

        else
        {
            moveIntervalCounter -= Time.deltaTime;
            enemyRigidBody.velocity = Vector2.zero;

            if (moveIntervalCounter < 0f)
            {
                //moveTimeCounter = moveTime;
                moveTimeCounter = Random.Range(moveTime * 0.75f, moveIntervalCounter * 1.25f);
                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
                isMoving = true;
            }
        }
    }
}