using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lobang : MonoBehaviour
{

    public float Kecepatan = 2;
    public float dorongan = 200;
    public Rigidbody rigidbody;
    
    void Start()
    {
        Debug.LogError("Kecepatan");
    }

    // Update is called once per frame
    void Update()
    {

        // transform.position += new Vector3(Kecepatan * Input.GetAxisRaw("Horizontal"), 
        //0, Kecepatan * Input.GetAxisRaw("Vertical")) * Time.deltaTime;


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, Kecepatan) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-Kecepatan, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Kecepatan, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -Kecepatan) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0, dorongan, 0));
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.layer = 6;
    }
    public void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = 7;
    }
}
