using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckpointTracker : MonoBehaviour
{
    //public event EventHandler OnMessage1;
    //public event EventHandler OnMessage2;
    //public event EventHandler OnMessage3;
    //public event EventHandler OnMessage4;

    private List<CheckpointSingle> checkpointSingleList;

    //[SerializeField] DialogUI dialogUI1;
    //[SerializeField] DialogUI dialogUI2;



    //private int nextCheckpointSingleIndex;

    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("CheckpointSystem");

        checkpointSingleList = new List<CheckpointSingle>();
        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackCheckpoints(this);

            checkpointSingleList.Add(checkpointSingle);
        }

        //nextCheckpointSingleIndex = Object 0;
    }


    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle)
    {
        if (checkpointSingleList.IndexOf(checkpointSingle) == 0)
        {
            Debug.Log("Erste Nachricht");
            //OnMessage1?.Invoke(this, EventArgs.Empty);
            //dialogUI1 = GetComponent<DialogUI>();
            //dialogUI1.StartTypeDialog();

        }

        if (checkpointSingleList.IndexOf(checkpointSingle) == 1)
        {
            Debug.Log("Zweite Nachricht");
            //OnMessage2?.Invoke(this, EventArgs.Empty);
            //dialogUI2 = FindObjectOfType<DialogUI>();
            //dialogUI2.StartTypeDialog();

        }

        if (checkpointSingleList.IndexOf(checkpointSingle) == 2)
        {
            Debug.Log("Dritte Nachricht");
            //OnMessage3?.Invoke(this, EventArgs.Empty);

        }

        if (checkpointSingleList.IndexOf(checkpointSingle) == 3)
        {
            Debug.Log("Vierte Nachricht");
            //OnMessage4?.Invoke(this, EventArgs.Empty);
        }
    }
}
