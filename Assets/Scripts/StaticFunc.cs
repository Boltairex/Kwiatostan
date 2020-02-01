using UnityEngine;

public class StaticFunc : MonoBehaviour
{
    static public MenuController MenuC;

    void Start()
    {
        MenuC = GameObject.Find("MenuController").GetComponent<MenuController>();
    }
}
