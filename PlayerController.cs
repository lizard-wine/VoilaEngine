using System;
using System.Collections;
using System.Collections.Generic;
using VoilaEngine;



public class PlayerController : MonoBehaviour
{   
    public PlayerController(GameObject parent): base(parent){}

    public Transform transform;
    public float speed = 500;

    public override void Awake()
    {
        transform = Parent.GetComponent<Transform>();
    }
    public override void Start()
    {
        transform.position = new Vector2(220,220);
    }
    public override void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw(Axis.Horizontal), Input.GetAxisRaw(Axis.Vertical));
        transform.position += (input.normalized * speed * Time.deltaTime);
    }

}