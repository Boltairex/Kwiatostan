using UnityEngine;
using System.Collections;

public class StaticFunc : MonoBehaviour
{
    static public MenuController MenuC;
    static public DialogueSystem Dialogue;

    static public AudioSource MonoVoice;

    static public bool Decision = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    static public void DecisionsOpen()
    {
        Decision = true;
        Dialogue.DialA.Play("DialogueOptionsOn");
    }

    static public void DecisionsClose()
    {
        Decision = false;
        Dialogue.DialScroll = -1;
        Dialogue.DialA.Play("DialogueOptionsOff");
    }
}
