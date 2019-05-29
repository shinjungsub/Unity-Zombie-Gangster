using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{

    public float rot_speed = 50.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            float Key = rot_speed * Time.deltaTime;
            transform.rotation *= Quaternion.AngleAxis(Key, Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            float Key = rot_speed * Time.deltaTime;
            transform.rotation *= Quaternion.AngleAxis(Key, -Vector3.up);
        }
    }
}
