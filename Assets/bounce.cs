using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public GameObject other_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == other_object)
        {
            other.GetComponent<Rigidbody>().AddForce(0, Time.deltaTime * 900.0f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == other_object)
        {
            other.GetComponent<AudioSource>().Play();
        }
    }

}
