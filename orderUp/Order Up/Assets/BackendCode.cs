using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class BackendCode : MonoBehaviour
{

    public TextMeshProUGUI statusText;
    public GameObject orderCanvas;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        statusText.text = "";
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown() {
        statusText.text = "Listening for your order...";
        StartRecording();
    }

    public void OnPointerUp() {
        statusText.text = "Processing your order...";
        StopRecording();
        
    }
    
    public void StartRecording() {
        audioSource.clip = Microphone.Start("", true, 30, 44100);
    }

    public void StopRecording() {
        Microphone.End("");
        audioSource.Play();
    }

    IEnumerator delay(float time) {
        yield return new WaitForSeconds(time);

        orderCanvas.SetActive(true);
        gameObject.SetActive(false);
        statusText.text = "";
    }

}
