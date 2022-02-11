using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{

    float pos1x, pos2x, pos1y, pos2y;

    // Start is called before the first frame update
    void Start()
    {
        pos1x = pos1y = pos2y = 0;
        pos2x = 18;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(",")) {
            transform.position = new Vector3(pos1x, pos1y, -3);
            Camera.main.backgroundColor = new Color(193f/255,228f/255,112f/255);
        }

        else if (Input.GetKey(".")) {
            transform.position = new Vector3(pos2x, pos2y, -3);
            Camera.main.backgroundColor = new Color(229f/255, 152f/255, 230f/255);
        } 
    }
}
