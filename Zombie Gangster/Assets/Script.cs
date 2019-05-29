using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

    private int timer;

    private void Update()
    {
        timer++;
        if (timer > 1)
        {
            Destroy(this.gameObject);
        }




    }




}
