using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAttackAdult : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    GameObject player;


    private void Start()
    {
        player = GameObject.Find("Erwachsener");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
