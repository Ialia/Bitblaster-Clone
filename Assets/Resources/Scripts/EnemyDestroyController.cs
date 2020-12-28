using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyController : MonoBehaviour
{

    public int pointsOnPlayerDestruction;

    public bool isSplitter = false;

    Score score;

    Enemies enemiesScript;

    private void Awake()
    {
        GameObject gaOb = GameObject.FindGameObjectWithTag("EnemySpawnGameObject");
        this.enemiesScript = gaOb.GetComponent<Enemies>();

        this.score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    public void DestroyByPlayer()
    {
        Debug.Log("destroybytheplayer");
        score.RaiseScore(this.pointsOnPlayerDestruction);


        this.enemiesScript.currentEnemiesAmount--;
        Destroy(this.gameObject);
    }






}
