using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsFreeze = false;
    public GameObject PauseMenuHud;
    public PlayerMove Player;
    public GameObject Trail;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsFreeze == true)
            {
                Reprendre();
            }
            else
            {
                Freeze();
            }
        }
    }


    void Freeze ()
    {
        PauseMenuHud.SetActive(true);
        Time.timeScale = 0f;
        GameIsFreeze = true;
        Trail.GetComponent<TrailRenderer>().enabled = false;
    }

    public void Reprendre ()
    {
        Debug.Log("Vous quittez le spatioPort, bon voyage.");
        PauseMenuHud.SetActive(false);
        Time.timeScale = 1f;
        GameIsFreeze = false;
        Trail.GetComponent<TrailRenderer>().enabled = true;
    }

    public void Recommencer()
    {
        Debug.Log("Respawn");
        Player.transform.position = new Vector3(-13.53f, 12.43f, 0);
        Player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        Player.vX = 0;
        Player.vY = 0;
        Trail.GetComponent<TrailRenderer>().enabled = true;
    }

    public void Quitter()
    {
        Debug.Log("Vous fermez l'application.");
        Application.Quit();
    }

}
