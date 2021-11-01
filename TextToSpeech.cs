using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToSpeech : MonoBehaviour
{
    private string apiURL = "";

    public AudioSource audioSource;
    string text = "XR 2�б� tts �׽�Ʈ";     // �� ���ڿ��� �����ָ� ��

    // Start is called before the first frame update
    void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio());
    }

    IEnumerator DownloadTheAudio() {
        //string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=�����ٶ�&tl=ko-gb";
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + text +"&tl=ko-gb";
        WWW www = new WWW(url);
        yield return www;

        Debug.Log("DownlaodTheAudio �����" + text);
        audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        // audioSource.Play();
    }
}
