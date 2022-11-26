using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    public int level;
    public TMP_Text levelText;
    public int levelSelect;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level.ToString();
    }
    
    public void OpenScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl" + level.ToString());
    }
    public void LevelSelector()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("levelselect");
    }
}