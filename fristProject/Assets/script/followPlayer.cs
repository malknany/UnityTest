using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 ofset;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);

        //the camer will follwe the play by postino
        transform.position=player.position+ofset;

    }
}
