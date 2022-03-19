using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTS_DATA : MonoBehaviour
{
    public static string tts;

    public string getTTSDATA() {
        return tts;
    }

    public void setTTSDATA(string str) {
        tts = str;
    }
}
