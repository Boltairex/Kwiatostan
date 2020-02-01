using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static StaticFunc;

public class DialogueSystem : MonoBehaviour
{
    public GameObject DialogueWindow;
    public TextMeshProUGUI OutputText;
    public Animator DialA;
    public bool DialogueOn = false;
    public int DialScroll = -1;
    bool Block;

    public RawImage Background1;
    public TextMeshProUGUI FirstText;
    public RawImage Background2;
    public TextMeshProUGUI SecoundText;
    public RawImage Background3;
    public TextMeshProUGUI ThirdText;
    public RawImage Background4;
    public TextMeshProUGUI FourthText;

    void Start()
    {
        Dialogue = gameObject.GetComponent<DialogueSystem>();
    }

    void Update()
    {
        if (DialogueOn)
        {
            DialogueWindow.SetActive(true);
        }
        else
        {
            DialogueWindow.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            DecisionsOpen();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            DecisionsClose();
        }

        if (Input.GetAxisRaw("Vertical") == -1 && !Block && Decision)
        {
            Block = true;
            DialScroll++;
        }
        else if (Input.GetAxisRaw("Vertical") == 1 && !Block && Decision)
        {
            Block = true;
            DialScroll--;
        }
        else if (Input.GetAxisRaw("Vertical") == 0 && Decision)
        {
            Block = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
            DialScroll = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            DialScroll = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            DialScroll = 3;
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            DialScroll = 4;

        switch (DialScroll)
        {
            case -1:
                Background1.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background2.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background3.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background4.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                break;
            case 0:
                DialScroll = 4;
                break;
            case 1:
                Background1.color = new Color(0.5f, 0.5f, 0.5f, 0.7f);
                Background2.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background3.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background4.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                break;
            case 2:
                Background2.color = new Color(0.5f, 0.5f, 0.5f, 0.7f);
                Background1.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background3.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background4.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                break;
            case 3:
                Background3.color = new Color(0.5f, 0.5f, 0.5f, 0.7f);
                Background2.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background1.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background4.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                break;
            case 4:
                Background4.color = new Color(0.5f, 0.5f, 0.5f, 0.7f);
                Background2.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background3.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                Background1.color = new Color(0.14f, 0.14f, 0.14f, 0.7f);
                break;
            case 5:
                DialScroll = 1;
                break;
            default:
                DialScroll = 1;
                break;
        }
    }
}