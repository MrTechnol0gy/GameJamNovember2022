using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreContainerScript : MonoBehaviour
{
    private static GameObject existCheck;

    public GameObject UI;

    public int LeaderboardSceneIndex;

    public int score;
    public float dist;

    private void Awake()
    {
        if (existCheck != null)
        {
            Destroy(existCheck);
        }

        existCheck = gameObject;
        DontDestroyOnLoad(gameObject);
    }

    public void EndLevel()
    {
        score = UI.GetComponent<UIScript>().score;
        dist = UI.GetComponent<UIScript>().dist;
        UnityEngine.SceneManagement.SceneManager.LoadScene(LeaderboardSceneIndex);
    }

}
