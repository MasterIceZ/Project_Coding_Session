using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apiHandler2 : MonoBehaviour
{
    public void onClick(){
        StartCoroutine(apiHandler());
    }
    IEnumerator apiHandler() {
        Dictionary <string, string> headers = new Dictionary<string, string>();
        headers.Add("apiKey", "12345");
        WWW www = new WWW("https://events-countdown.vercel.app/api/event", null, headers);
        yield return www;
        Debug.Log(www.text);
    }
}
