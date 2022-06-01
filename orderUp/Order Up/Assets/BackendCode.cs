using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackendCode : MonoBehaviour

{
    string api_key = "e31e874c4c0b400c956dcf5341857159";
    public TextMeshProUGUI statusText;
    public GameObject orderCanvas;

    // Start is called before the first frame update
    void Start()
    {
        statusText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string convertToLink(string audioFile) {
        string link = "";
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://api.assemblyai.com/v2/");
        client.DefaultRequestHeaders.Add("authorization", api_key);

        string jsonResult = sendRecording(client, @"/path/to/foo.wav").Result;
        return jsonResult;
    }

    private static async Task sendRecording(HttpClient client, string link) {
        try {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "upload");
            request.Headers.Add("Transer-Encoding", "chunked");

            var fileReader = System.IO.File.OpenRead(filePath);
            var streamContent = new StreamContent(fileReader);
            request.Content = streamContent;

            HttpResponseMessage response = await client.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex) {
            System.Console.WriteLine($"Exception: {ex.Message}");
            throw;
        }
    }

    public void OnPointerDown() {
        statusText.text = "Listening for your order...";

        // Microphone setup here.



    }

    public void OnPointerUp() {
        statusText.text = "Processing your order...";
        StartCoroutine(delay(2.34f));
        
        string fileType = "";

        sendRecording(fileType);
    }
    
    IEnumerator delay(float time) {
        yield return new WaitForSeconds(time);

        orderCanvas.SetActive(true);
        gameObject.SetActive(false);
        statusText.text = "";
    }

}
