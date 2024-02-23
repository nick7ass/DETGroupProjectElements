using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWind : MonoBehaviour

{
    public GameObject windObject;
    public GameObject testObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WindCube")
        {
            windObject.SetActive(true);
            testObject.SetActive(true);
        }
    }
}
