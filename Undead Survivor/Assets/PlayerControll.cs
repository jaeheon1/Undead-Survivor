using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControll : MonoBehaviour
{

    public Vector2 inputVec;
    int speed = 10;
    SpriteRenderer sprite;
    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

   
  
    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);

    }
    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

    private void LateUpdate()
    {
        if(inputVec.x!=0)
        {
            sprite.flipX = inputVec.x < 0;
        }
    }
}
