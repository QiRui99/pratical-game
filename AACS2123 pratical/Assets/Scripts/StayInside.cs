using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    float xWidthP;
    float yHeightP;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // xWidthP = (Screen.width - 34) / 100;
        // yHeightP = (Screen.height - 52) / 100;
        xWidthP = 6.6f;
        yHeightP = 9.2f;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xWidthP, xWidthP),
            Mathf.Clamp(transform.position.y, -yHeightP, yHeightP), 0);
    }
}
