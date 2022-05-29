using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackendCode : MonoBehaviour

{

    public TextMeshProUGUI statusText;

    // Start is called before the first frame update
    void Start()
    {
        statusText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown() {
        statusText.text = "Listening for your order...";
    }

    public void OnPointerUp() {
        statusText.text = "";
    }
    
}
