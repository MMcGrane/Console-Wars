using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    public float TurnSpeed = -50f;

    public float Horizontal;
    public float Vertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
         Horizontal = Input.GetAxis("Horizontal");
         Vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.left * Horizontal * TurnSpeed * Time.deltaTime);

    }
}
