using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        this.velocity = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale > 0.0f)
        {
            if(Input.GetKey("w"))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * this.velocity);
            }
            if(Input.GetKey("s"))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * this.velocity);
            }
            if(Input.GetKey("a"))
            {
                this.transform.Rotate(0,-1,0);
            }
            if(Input.GetKey("d"))
            {
                this.transform.Rotate(0,1,0);
            }
        }
    }
}
