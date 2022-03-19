using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToSpeech : MonoBehaviour
{
    private string apiURL = "";

    public AudioSource audioSource;
    string textT = "XR 2학기 TTS 테스트";     // 이 문자열만 교체

    // Start is called before the first frame update
    void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio(textT));
    }

    public void playTTS(string[] text) {
        StartCoroutine(DownloadTheAudio2(text));
    }

    IEnumerator DownloadTheAudio(string text) {
        //string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=가나다라&tl=ko-gb";
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + text +"&tl=ko-gb";
        WWW www = new WWW(url);
        yield return null;

        Debug.Log("DownlaodTheAudio 실행됨" + text);
        audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        audioSource.Play();
    }

    IEnumerator DownloadTheAudio2(string[] text) {
        string[] test = new string[] {  // for test
            "세글자",
            "여덟글자여덟글자",
            "열여섯글자 열여섯글자열여섯글자",
        };
        WWW www = null;
        foreach (string t in text) {
            string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + t + "&tl=ko-gb";
            www = new WWW(url);
            audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
            audioSource.Play();

            Debug.Log("DownloadTheAudio2 실행됨" + t + ", " + t.Length / 2.5f + "초 대기");
            yield return new WaitForSeconds(1.0f * t.Length / 2.5f); // 2.5글자당 1초 대기
        }
        
    }
}
