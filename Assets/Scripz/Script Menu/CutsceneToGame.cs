using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneToGame : MonoBehaviour

{
    public void Play()
    {
        SceneManager.LoadScene("Boss_Tuto");
        Debug.Log("Lol");
    }

}

