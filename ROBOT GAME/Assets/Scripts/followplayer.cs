using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player;
    private Vector3 posFromPlayer;

    // Update is called once per frame
    private void Start()
    {
        posFromPlayer = transform.position - player.position;
    }
    void Update()
    {
        transform.position = player.position + posFromPlayer;
    }
}
