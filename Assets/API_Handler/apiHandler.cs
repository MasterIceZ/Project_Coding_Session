using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class apiHandler : MonoBehaviour
{
    public void onClick(){
        StartCoroutine(GetRequest("https://events-countdown.vercel.app/api/event"));
    }
    IEnumerator GetRequest(string url){
        using(UnityWebRequest webRequest = UnityWebRequest.Get(url)){
            yield return webRequest.SendWebRequest();
            if(webRequest.isNetworkError){
                Debug.Log(webRequest.error);
            }else{
                Debug.Log(webRequest.downloadHandler.text);
            }
        }
    }

}
