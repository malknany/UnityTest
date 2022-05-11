using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManger : MonoBehaviour
{
    public float restarDelay = 2f;
    bool gamehasEnded=false;

    public GameObject completelevel1UI;
    public void Completgame()
    {
        completelevel1UI.SetActive(true);
        Debug.Log("YOU WIN BITCH AND FUCK YOU _|_ ");
    }
    public void Endgame()
    {
        //here u do it bcuz dont repeat the string in console
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("game over");
            //Restart(); u can run it but u run so qucliy so we will use the next code
            Invoke("Restart", restarDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
