using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    GameObject player;
    public string playerTag;
    public string chunkSpawnTag;
    public string noTag;

    public GameObject[] levelChunks;
    public float loadChunkDist;

    GameObject chunkSpawner;
    float startPosX;

    private void Start()
    {
        startPosX = transform.position.x;
        chunkSpawner = GameObject.FindGameObjectWithTag(chunkSpawnTag);
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag(playerTag);
        }
        else if (player.transform.position.x > startPosX)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }

        if(Vector2.Distance(gameObject.transform.position, chunkSpawner.transform.position) <= loadChunkDist)
        {
            GameObject.Instantiate(levelChunks[Random.Range(0, levelChunks.Length)], chunkSpawner.transform);
            chunkSpawner.tag = noTag;
            chunkSpawner = GameObject.FindGameObjectWithTag(chunkSpawnTag);
        }

    }
}
