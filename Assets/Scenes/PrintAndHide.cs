using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    private int blueNone;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        blueNone = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.gameObject.name + ": " + i);

        if (i == 200 && this.gameObject.tag == "Red")
        {
            rend.enabled = false;
        }

        if (i == blueNone && this.gameObject.tag == "Blue")
        {
            rend.enabled = false;
        }

        i++;
    }
}