using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class order : MonoBehaviour
{
    public GameObject completePanel;
    public GameObject orderPanel;
    public GameObject mainCanvas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Order() {
        completePanel.SetActive(true);
        orderPanel.SetActive(false);
    }

    public void OrderAgain() {
        completePanel.SetActive(false);
        orderPanel.SetActive(true);
        mainCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
