using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide : MonoBehaviour
{

    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        image.enabled = true;

        if (enabled)
        {
            image.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
