using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Before you can manipulate any object, we first need to know which component
        // we're manipulating. Since  the POSITION property is inside of the 
        // TRANSFORM component, we're going to first get that component

        // To start this out we first get the component by doing
        // GetComponent<Transform>();

        // From there, we access the position property. That looks like this
        // GetComponent<Transform>().position;

        // We can choose to either GET the position or SET the position
        // To GET the position, do this...
        // Vector3 myPos = GetComponent<Transform>().position;

        // To SET the position, do this
        // GetComponent<Transform>().position = new Vector3(0,0,0);

        GetComponent<Transform>().position = new Vector3(-9, 1, -8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
