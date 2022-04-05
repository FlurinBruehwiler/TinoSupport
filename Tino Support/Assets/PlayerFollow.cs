using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        var playerPos = player.transform.position;
        var cameraPos = transform;
        cameraPos.position = new Vector3(playerPos.x, playerPos.y, cameraPos.position.z);
    }
}
