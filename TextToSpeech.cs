using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToSpeech : MonoBehaviour
{
    private string apiURL = "";

    public AudioSource audioSource;
    string textT = "XR 2�б� TTS �׽�Ʈ";     // �� ���ڿ��� ��ü

    // Start is called before the first frame update
    void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio(textT));
    }

    public void playTTS(string[] text) {
        StartCoroutine(DownloadTheAudio2(text));
    }

    IEnumerator DownloadTheAudio(string text) {
        //string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=�����ٶ�&tl=ko-gb";
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + text +"&tl=ko-gb";
        WWW www = new WWW(url);
        yield return null;

        Debug.Log("DownlaodTheAudio �����" + text);
        audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        audioSource.Play();
    }

    IEnumerator DownloadTheAudio2(string[] text) {
        string[] test = new string[] {  // for test
            "������",
            "�������ڿ�������",
            "���������� ���������ڿ���������",
        };
        WWW www = null;
        foreach (string t in text) {
            string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + t + "&tl=ko-gb";
            www = new WWW(url);
            audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
            audioSource.Play();

            Debug.Log("DownloadTheAudio2 �����" + t + ", " + t.Length / 2.5f + "�� ���");
            yield return new WaitForSeconds(1.0f * t.Length / 2.5f); // 2.5���ڴ� 1�� ���
        }
        
    }
}
