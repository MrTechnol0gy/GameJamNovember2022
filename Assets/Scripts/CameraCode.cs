using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    GameObject player;
    public string playerTag;
    public string chunkTag;
    public string chunkSpawnTag;
    public string noTag;

    public GameObject[] levelChunks;
    public float loadChunkDist;

    GameObject chunkSpawner;
    //float startPosX;

    List<GameObject> activeChunks = new List<GameObject> { };
    GameObject toRemove;

    private void Start()
    {
        //tartPosX = transform.position.x;
        chunkSpawner = GameObject.FindGameObjectWithTag(chunkSpawnTag);
        activeChunks.Add(GameObject.FindGameObjectWithTag(chunkTag));
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag(playerTag);
        }
        else if (player.transform.position.x > gameObject.transform.position.x)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }

        if(Vector2.Distance(gameObject.transform.position, chunkSpawner.transform.position) <= loadChunkDist)
        {
            GameObject.Instantiate(levelChunks[Random.Range(0, levelChunks.Length)], chunkSpawner.transform);
            chunkSpawner.tag = noTag;
            activeChunks.Add(chunkSpawner.transform.GetChild(0).gameObject);
            chunkSpawner.transform.DetachChildren();
            chunkSpawner = GameObject.FindGameObjectWithTag(chunkSpawnTag);
        }
        foreach(GameObject chunk in activeChunks)
        {
            if(Vector2.Distance(chunk.transform.position, gameObject.transform.position) >= loadChunkDist && chunk.transform.position.x - gameObject.transform.position.x < 0)
            {
                toRemove = chunk;
            }
        }
        if(activeChunks.Contains(toRemove))
        {
            activeChunks.Remove(toRemove);
            toRemove.SetActive(false);
        }
    }
}
