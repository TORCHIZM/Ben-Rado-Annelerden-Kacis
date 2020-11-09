using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public CharacterMove MoveScript;
    public GameObject Pipes;
    public float Height;

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    public IEnumerator SpawnPipes()
    {
        while (MoveScript.IsDead == false && MoveScript.IsStarted)
        {
            Instantiate(Pipes, new Vector3(3, Random.Range(-Height, Height), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
