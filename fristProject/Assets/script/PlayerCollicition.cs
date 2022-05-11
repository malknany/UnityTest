using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollicition : MonoBehaviour
{
    public playermove movele;
    public gameManger gameManger;
    //entabeh ll 7rof 
    public void OnCollisionEnter(Collision colitionInfo)
    {
        //هنا بنقوله لو لمست obstacle وقفلي حركه اللاعب 
        if(colitionInfo.collider.tag == "obstacle")
        {
            //Debug.Log("shit ya shaaaaaaaa5");
            movele.enabled = false;
            FindObjectOfType<gameManger>().Endgame();
        }
    }
}
