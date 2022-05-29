using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looksgood : MonoBehaviour
{
    public GameObject finalCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScreen() {
        finalCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
