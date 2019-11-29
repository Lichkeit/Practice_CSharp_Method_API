
using System;
using UnityEngine;

public class Fox : MonoBehaviour
{

    [Header("移動速度"), Range(0.1f, 0.9f)]
    public float speed ;

    public Rigidbody2D rig;
    private float thrust = 10f;
    public SpriteRenderer Sr;
    public bool flipX;
    float move;


    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();
       

    }



    private void Update()
    {
        move= Input.GetAxisRaw("Horizontal")*speed;
        transform.position = new Vector3(transform.position.x+ move, transform.position.y, transform.position.z);

        Vector2 movement = new Vector2(move, move);
        rig.AddForce(movement  * speed,ForceMode2D.Impulse);
    }

  
}
