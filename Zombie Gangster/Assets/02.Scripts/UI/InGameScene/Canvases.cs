using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvases : MonoBehaviour
{
    [SerializeField]
    private PlayCanvas playCanvas;
    [SerializeField]
    private DieCanvas dieCanvas;

    private void PlayerDie()
    {
        playCanvas.Hide();
        dieCanvas.Show();
    }
}
