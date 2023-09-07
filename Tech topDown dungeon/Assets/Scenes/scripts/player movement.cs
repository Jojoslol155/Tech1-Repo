using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;

    private Vector2 dir;

    public bool hasKey = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //X input
        float y = Input.GetAxisRaw("Vertical");  //Y input
        Vector2 direction = new Vector2(x, y); //Direction we move
        transform.Translate(direction * Time.deltaTime * speed); //How we move
    }


}
