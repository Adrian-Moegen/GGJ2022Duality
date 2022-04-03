using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGhostSpawn : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject ghost;

    TestLightArea testLightArea;
    GameObject ghostEntity;

    public bool ghostIsSpawn = false;


    void Start()
    {
        testLightArea = GetComponent<TestLightArea>();
    }

    private void Update()
    {
        SpawnGhost();
    }

    public void SpawnGhost()
    {
        if(testLightArea.playerInLight == false)
        {
            if (!ghostIsSpawn)
            {
                ghostEntity = Instantiate(ghost, spawnPoint.position, Quaternion.identity);
                ghostIsSpawn = true;
            }
        }
        if(testLightArea.playerInLight == true)
        {
            Destroy(ghostEntity);
            ghostIsSpawn = false;
        }
  
    }
}
