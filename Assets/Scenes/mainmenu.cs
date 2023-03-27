using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public AudioSource click;

    public void startgame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void playsound()
    {
        click.Play();
    }

}
