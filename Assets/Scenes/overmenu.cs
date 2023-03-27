using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class overmenu : MonoBehaviour
{
    public AudioSource click;

    public void retrygame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void playsound()
    {
        click.Play();
    }


}