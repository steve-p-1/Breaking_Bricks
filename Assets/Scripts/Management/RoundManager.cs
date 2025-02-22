using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //variables
   // [SerializeField] protected List<BreakableBrick> bricks;
    [SerializeField] protected GameObject canvasScene;

    //methods
    private void Update()
    {
        EndRound();
    }
    private void Awake()
    {
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if (gOs.Length  > 1)
        {
            Destroy(gameObject);
        }
    }

    protected void EndRound()
    {
        if (FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }
    }
}
