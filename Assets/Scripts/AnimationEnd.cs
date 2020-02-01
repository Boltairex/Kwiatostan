using UnityEngine;
using static StaticFunc;

public class AnimationEnd : MonoBehaviour
{
    public void AnimEvent()
    {
        switch (gameObject.name)
        {
            case "Menu 1":
                MenuC.ChangeMenuMode();
                break;
            case "Menu 2 - Game":
                MenuC.ChangeMenu2Mode();
                break;
            case "Menu 3 - Saves":
                //Do Zrobienia
                break;
            case "Menu 4 - Options":
                //Do Zrobienia
                break;
            
        }
    }
}
