using UnityEngine;
using UnityEngine.SceneManagement;
using static StaticFunc;

public class MenuController : MonoBehaviour
{
    public GameObject Menu; //Startowe
    public GameObject Menu2; //Od przycisku Graj
    public GameObject Menu3; //Wczytywanie
    public GameObject Menu4;
    public Animator MenuA;
    public Animator MenuA2;
    int mode = 0;

    private void Start()
    {
        MenuC = gameObject.GetComponent<MenuController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mode = 0;
            Menu.SetActive(true);
            MenuA.Play("MenuOpen");
            Menu2.SetActive(false);
            //Menu3.SetActive(false);
            //Menu4.SetActive(false);
        }
    }

    public void GameOptions()
    {
        mode = 1;
        MenuA.Play("MenuClose");
    }

    public void SaveLoad()
    {
        mode = 2;
        MenuA.Play("MenuClose");
    }

    public void Options()
    {
        mode = 3;
        MenuA.Play("MenuClose");
    }

    public void Exit()
    {
        mode = 4;
        MenuA.Play("MenuClose");
    }

    public void LastGame()
    {
        mode = 5;
        MenuA.Play("MenuClose");
    }

    public void ChangeMenuMode()
    {
        Menu.SetActive(false);
        switch (mode)
        {
            case 1:
                Menu2.SetActive(true);
                MenuA2.Play("Menu2Open");
                break;
            case 2:
                Menu3.SetActive(true);
                break;
            case 3:
                Menu4.SetActive(true);
                break;
            case 4:
                Application.Quit();
                break;
            default:
                mode = 0;
                Menu.SetActive(true);
                MenuA.Play("MenuOpen");
                Menu2.SetActive(false);
                break;
        }
    }

    public void NewGame()
    {
        mode = 6;
        MenuA2.Play("Menu2Close");
    }

    public void Challenges()
    {
        mode = 7;
        MenuA2.Play("Menu2Close");
    }

    public void Skirmish()
    {
        mode = 8;
        MenuA2.Play("Menu2Close");
    }

    public void ChangeMenu2Mode()
    {
        Menu2.SetActive(false);
        switch (mode)
        {
            case 6:
                SceneManager.LoadScene(1);
                break;
            case 7:
                //Do zrobienia 
                break;
            case 8:
                //Do zrobienia
                break;
        }
    }
}
