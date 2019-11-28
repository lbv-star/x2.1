using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject menu;
    public GameObject rules;
    public GameObject exit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pushPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("x21");
    }

    public void pushRules()
    {
        menu.SetActive(false);
        rules.SetActive(true);
    }

    public void pushExit()
    {
        menu.SetActive(false);
        exit.SetActive(true);
    }

    public void pushExitYes()
    {
        Application.Quit();
    }

    public void pushExitNo()
    {
        exit.SetActive(false);
        menu.SetActive(true);
    }

    public void goTomenu()
    {
        rules.SetActive(false);
        menu.SetActive(true);
    }
}
