using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawn : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject ghost;

    PlayerInLight playerInLight;
    GameObject ghostEntity;

    public bool ghostIsSpawn = false;


    void Start()
    {
        playerInLight = GetComponent<PlayerInLight>();

    }

    private void Update()
    {
        SpawnGhost();
    }

    public void SpawnGhost()
    {
        if (playerInLight.playerInLight == false)
        {
            if (!ghostIsSpawn)
            {
                ghostEntity = Instantiate(ghost, spawnPoint.position, Quaternion.identity);
                ghostIsSpawn = true;
            }
        }
        if (playerInLight.playerInLight == true)
        {
            Destroy(ghostEntity);
            ghostIsSpawn = false;
        }

    }
}
