using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToSpeech : MonoBehaviour
{
    private string apiURL = "";

    public AudioSource audioSource;
    string text = "XR 2학기 tts 테스트";     // 이 문자열만 갈아주면 됨

    // Start is called before the first frame update
    void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio());
    }

    IEnumerator DownloadTheAudio() {
        //string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=가나다라&tl=ko-gb";
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + text +"&tl=ko-gb";
        WWW www = new WWW(url);
        yield return www;

        Debug.Log("DownlaodTheAudio 실행됨" + text);
        audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        // audioSource.Play();
    }
}
