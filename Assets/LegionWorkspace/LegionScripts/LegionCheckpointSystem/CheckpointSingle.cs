using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{

    private CheckpointTracker checkpointTracker;

    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tester")
        {
            checkpointTracker.PlayerThroughCheckpoint(this);
            boxCollider = GetComponent<BoxCollider2D>();
            boxCollider.enabled = false;
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.enabled = false;
            
        }
    }

    public void SetTrackCheckpoints(CheckpointTracker checkpointTracker)
    {
        this.checkpointTracker = checkpointTracker;
    }
}
