using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    Controls controls;
    Rigidbody2D rb;
    SpriteRenderer sr;
    Collider2D col;
    

    [Header("GameObjects")]
    [SerializeField] Transform start;
    [SerializeField] Transform goal;



    [Header("Stats")]
    [SerializeField] float speed = 5f;

    

    bool alive = false;


    void Awake()
    {
        controls = new Controls();
        controls.Enable();
        controls.Player.Spawn.performed += _ => spawn();
        controls.Player.Up.performed += _ => Up();
        controls.Player.Down.performed += _ => Down();
        controls.Player.Left.performed += _ => Left();
        controls.Player.Right.performed += _ => Right();

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<CircleCollider2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn(){
        if(!alive)
        {
            alive = true;
            transform.position = start.position;
            sr.enabled = true;
        }
    }

    void Up(){
        if(rb.velocity != Vector2.down*speed && alive) rb.velocity = Vector2.up*speed;
    }

    void Down(){
        if(rb.velocity != Vector2.up*speed && alive) rb.velocity = Vector2.down*speed;;
    }

    void Left(){
        if(rb.velocity != Vector2.right*speed && alive) rb.velocity = Vector2.left*speed;
    }

    void Right(){
        if(rb.velocity != Vector2.left*speed && alive) rb.velocity = Vector2.right*speed;
    }

    void OnCollisionEnter2D(Collision2D collision){
    //    ContactPoint contact = collision.contacts[0];

        sr.enabled = false;
        alive = false;
        
    }


}
