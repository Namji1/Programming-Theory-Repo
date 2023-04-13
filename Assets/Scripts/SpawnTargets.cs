using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    public GameObject[] targets;

    public GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        SpawnFirstRow();
        SpawnSecondRow();
        SpawnThirdRow();
        SpawnFourthRow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnFirstRow()
    {
        if (gameManagerScript.gameOver == false)
        {
            Vector3 spawnPositionFirstRow = new Vector3(-7, 0.2f, -8);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index], spawnPositionFirstRow, Quaternion.Euler(-90, 0, -180));
            StartCoroutine(SpawningWaitFirstRow());
        }
    }

    private void SpawnSecondRow()
    {
        if (gameManagerScript.gameOver == false)
        {
            Vector3 spawnPositionSecondRow = new Vector3(-9, 0.6f, -7);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index], spawnPositionSecondRow, Quaternion.Euler(-90, 0, -180));
            StartCoroutine(SpawningWaitSecondRow());
        }
    }

    private void SpawnThirdRow()
    {
        if (gameManagerScript.gameOver == false)
        {
            Vector3 spawnPositionThirdRow = new Vector3(-8, 1.05f, -6);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index], spawnPositionThirdRow, Quaternion.Euler(-90, 0, -180));
            StartCoroutine(SpawningWaitThirdRow());
        }
    }

    private void SpawnFourthRow()
    {
        if (gameManagerScript.gameOver == false)
        {
            Vector3 spawnPositionFourthRow = new Vector3(-10, 1.8f, -5);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index], spawnPositionFourthRow, Quaternion.Euler(-90, 0, -180));
            StartCoroutine(SpawningWaitFourthRow());
        }
    }
    private IEnumerator SpawningWaitFirstRow()
    {
        yield return new WaitForSeconds(3);
        SpawnFirstRow();
    }

    private IEnumerator SpawningWaitSecondRow()
    {
        yield return new WaitForSeconds(2);
        SpawnSecondRow();
    }
    private IEnumerator SpawningWaitThirdRow()
    {
        yield return new WaitForSeconds(1.5f);
        SpawnThirdRow();
    }
    private IEnumerator SpawningWaitFourthRow()
    {
        yield return new WaitForSeconds(2.5f);
        SpawnFourthRow();
    }
}
