using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderboardScript : MonoBehaviour
{

    public string gameControlTag;
    GameObject scoreContainer;

    string scoreHolder1;
    string scoreHolder2;
    string scoreHolder3;
    string scoreHolder4;
    string scoreHolder5;
    string scoreHolder6;
    string scoreHolder7;
    string scoreHolder8;
    string scoreHolder9;
    string scoreHolder10;

    string distHolder1;
    string distHolder2;
    string distHolder3;
    string distHolder4;
    string distHolder5;
    string distHolder6;
    string distHolder7;
    string distHolder8;
    string distHolder9;
    string distHolder10;

    int score1;
    int score2;
    int score3;
    int score4;
    int score5;
    int score6;
    int score7;
    int score8;
    int score9;
    int score10;

    float dist1;
    float dist2;
    float dist3;
    float dist4;
    float dist5;
    float dist6;
    float dist7;
    float dist8;
    float dist9;
    float dist10;

    int yourScore;
    float yourDist;

    public TextMeshProUGUI scoreHolder1Text;
    public TextMeshProUGUI scoreHolder2Text;
    public TextMeshProUGUI scoreHolder3Text;
    public TextMeshProUGUI scoreHolder4Text;
    public TextMeshProUGUI scoreHolder5Text;
    public TextMeshProUGUI scoreHolder6Text;
    public TextMeshProUGUI scoreHolder7Text;
    public TextMeshProUGUI scoreHolder8Text;
    public TextMeshProUGUI scoreHolder9Text;
    public TextMeshProUGUI scoreHolder10Text;

    public TextMeshProUGUI distHolder1Text;
    public TextMeshProUGUI distHolder2Text;
    public TextMeshProUGUI distHolder3Text;
    public TextMeshProUGUI distHolder4Text;
    public TextMeshProUGUI distHolder5Text;
    public TextMeshProUGUI distHolder6Text;
    public TextMeshProUGUI distHolder7Text;
    public TextMeshProUGUI distHolder8Text;
    public TextMeshProUGUI distHolder9Text;
    public TextMeshProUGUI distHolder10Text;

    public TextMeshProUGUI score1Text;
    public TextMeshProUGUI score2Text;
    public TextMeshProUGUI score3Text;
    public TextMeshProUGUI score4Text;
    public TextMeshProUGUI score5Text;
    public TextMeshProUGUI score6Text;
    public TextMeshProUGUI score7Text;
    public TextMeshProUGUI score8Text;
    public TextMeshProUGUI score9Text;
    public TextMeshProUGUI score10Text;

    public TextMeshProUGUI dist1Text;
    public TextMeshProUGUI dist2Text;
    public TextMeshProUGUI dist3Text;
    public TextMeshProUGUI dist4Text;
    public TextMeshProUGUI dist5Text;
    public TextMeshProUGUI dist6Text;
    public TextMeshProUGUI dist7Text;
    public TextMeshProUGUI dist8Text;
    public TextMeshProUGUI dist9Text;
    public TextMeshProUGUI dist10Text;

    public TextMeshProUGUI yourScoreText;
    public TextMeshProUGUI yourDistText;
    public TextMeshProUGUI yourScoreHoldingText;
    public TextMeshProUGUI yourDistHoldingText;

    public TMP_InputField nameInput;
    public GameObject enterNameObject;

    // Start is called before the first frame update
    void Awake()
    {
        scoreContainer = GameObject.FindGameObjectWithTag(gameControlTag);
        yourScore = scoreContainer.GetComponent<ScoreContainerScript>().score;
        yourDist = scoreContainer.GetComponent<ScoreContainerScript>().dist;
        yourScoreText.text = yourScore.ToString();
        yourDistText.text = yourDist.ToString("0.0") + "m";

        score1 = PlayerPrefs.GetInt("score1", 0);
        score2 = PlayerPrefs.GetInt("score2", 0);
        score3 = PlayerPrefs.GetInt("score3", 0);
        score4 = PlayerPrefs.GetInt("score4", 0);
        score5 = PlayerPrefs.GetInt("score5", 0);
        score6 = PlayerPrefs.GetInt("score6", 0);
        score7 = PlayerPrefs.GetInt("score7", 0);
        score8 = PlayerPrefs.GetInt("score8", 0);
        score9 = PlayerPrefs.GetInt("score9", 0);
        score10 = PlayerPrefs.GetInt("score10", 0);

        dist1 = PlayerPrefs.GetFloat("dist1", 0);
        dist2 = PlayerPrefs.GetFloat("dist2", 0);
        dist3 = PlayerPrefs.GetFloat("dist3", 0);
        dist4 = PlayerPrefs.GetFloat("dist4", 0);
        dist5 = PlayerPrefs.GetFloat("dist5", 0);
        dist6 = PlayerPrefs.GetFloat("dist6", 0);
        dist7 = PlayerPrefs.GetFloat("dist7", 0);
        dist8 = PlayerPrefs.GetFloat("dist8", 0);
        dist9 = PlayerPrefs.GetFloat("dist9", 0);
        dist10 = PlayerPrefs.GetFloat("dist10", 0);

        scoreHolder1 = PlayerPrefs.GetString("scoreHolder1", " ");
        scoreHolder2 = PlayerPrefs.GetString("scoreHolder2", " ");
        scoreHolder3 = PlayerPrefs.GetString("scoreHolder3", " ");
        scoreHolder4 = PlayerPrefs.GetString("scoreHolder4", " ");
        scoreHolder5 = PlayerPrefs.GetString("scoreHolder5", " ");
        scoreHolder6 = PlayerPrefs.GetString("scoreHolder6", " ");
        scoreHolder7 = PlayerPrefs.GetString("scoreHolder7", " ");
        scoreHolder8 = PlayerPrefs.GetString("scoreHolder8", " ");
        scoreHolder9 = PlayerPrefs.GetString("scoreHolder9", " ");
        scoreHolder10 = PlayerPrefs.GetString("scoreHolder10", " ");

        distHolder1 = PlayerPrefs.GetString("distHolder1", " ");
        distHolder2 = PlayerPrefs.GetString("distHolder2", " ");
        distHolder3 = PlayerPrefs.GetString("distHolder3", " ");
        distHolder4 = PlayerPrefs.GetString("distHolder4", " ");
        distHolder5 = PlayerPrefs.GetString("distHolder5", " ");
        distHolder6 = PlayerPrefs.GetString("distHolder6", " ");
        distHolder7 = PlayerPrefs.GetString("distHolder7", " ");
        distHolder8 = PlayerPrefs.GetString("distHolder8", " ");
        distHolder9 = PlayerPrefs.GetString("distHolder9", " ");
        distHolder10 = PlayerPrefs.GetString("distHolder10", " ");

        CompareScores();
        DisplayScores();
        CompareDists();
        DisplayDists();

        if(yourDistHoldingText != null || yourScoreHoldingText != null)
        {
            nameInput.gameObject.SetActive(true);
            enterNameObject.SetActive(true);
        }
        else
        {
            nameInput.gameObject.SetActive(false);
            enterNameObject.SetActive(false);
        }

        if(yourScoreHoldingText != null)
        {
            yourScoreHoldingText.text = "ENTER NAME";
        }
        if (yourDistHoldingText != null)
        {
            yourDistHoldingText.text = "ENTER NAME";
        }

    }

    void CompareScores()
    {
        yourScoreHoldingText = null;
        if(yourScore >= score10)
        {
            score10 = yourScore;
            yourScoreHoldingText = scoreHolder10Text;
        }
        if(yourScore >= score9)
        {
            score10 = score9;
            scoreHolder10 = scoreHolder9;
            score9 = yourScore;
            yourScoreHoldingText = scoreHolder9Text;
        }
        if (yourScore >= score8)
        {
            score9 = score8;
            scoreHolder9 = scoreHolder8;
            score8 = yourScore;
            yourScoreHoldingText = scoreHolder8Text;
        }
        if (yourScore >= score7)
        {
            score8 = score7;
            scoreHolder8 = scoreHolder7;
            score7 = yourScore;
            yourScoreHoldingText = scoreHolder7Text;
        }
        if (yourScore >= score6)
        {
            score7 = score6;
            scoreHolder7 = scoreHolder6;
            score6 = yourScore;
            yourScoreHoldingText = scoreHolder6Text;
        }
        if (yourScore >= score5)
        {
            score6 = score5;
            scoreHolder6 = scoreHolder5;
            score5 = yourScore;
            yourScoreHoldingText = scoreHolder5Text;
        }
        if (yourScore >= score4)
        {
            score5 = score4;
            scoreHolder5 = scoreHolder4;
            score4 = yourScore;
            yourScoreHoldingText = scoreHolder4Text;
        }
        if (yourScore >= score3)
        {
            score4 = score3;
            scoreHolder4 = scoreHolder3;
            score3 = yourScore;
            yourScoreHoldingText = scoreHolder3Text;
        }
        if (yourScore >= score2)
        {
            score3 = score2;
            scoreHolder3 = scoreHolder2;
            score2 = yourScore;
            yourScoreHoldingText = scoreHolder2Text;
        }
        if (yourScore >= score1)
        {
            score2 = score1;
            scoreHolder2 = scoreHolder1;
            score1 = yourScore;
            yourScoreHoldingText = scoreHolder1Text;
        }
    }
    
    void DisplayScores()
    {
        scoreHolder1Text.text = scoreHolder1;
        scoreHolder2Text.text = scoreHolder2;
        scoreHolder3Text.text = scoreHolder3;
        scoreHolder4Text.text = scoreHolder4;
        scoreHolder5Text.text = scoreHolder5;
        scoreHolder6Text.text = scoreHolder6;
        scoreHolder7Text.text = scoreHolder7;
        scoreHolder8Text.text = scoreHolder8;
        scoreHolder9Text.text = scoreHolder9;
        scoreHolder10Text.text = scoreHolder10;

        score1Text.text = score1.ToString();
        score2Text.text = score2.ToString();
        score3Text.text = score3.ToString();
        score4Text.text = score4.ToString();
        score5Text.text = score5.ToString();
        score6Text.text = score6.ToString();
        score7Text.text = score7.ToString();
        score8Text.text = score8.ToString();
        score9Text.text = score9.ToString();
        score10Text.text = score10.ToString();
    }

    void CompareDists()
    {
        yourDistHoldingText = null;
        if (yourDist >= dist10)
        {
            dist10 = yourDist;
            yourDistHoldingText = distHolder10Text;
        }
        if (yourDist >= dist9)
        {
            dist10 = dist9;
            distHolder10 = distHolder9;
            dist9 = yourDist;
            yourDistHoldingText = distHolder9Text;
        }
        if (yourDist >= dist8)
        {
            dist9 = dist8;
            distHolder9 = distHolder8;
            dist8 = yourDist;
            yourDistHoldingText = distHolder8Text;
        }
        if (yourDist >= dist7)
        {
            dist8 = dist7;
            distHolder8 = distHolder7;
            dist7 = yourDist;
            yourDistHoldingText = distHolder7Text;
        }
        if (yourDist >= dist6)
        {
            dist7 = dist6;
            distHolder7 = distHolder6;
            dist6 = yourDist;
            yourDistHoldingText = distHolder6Text;
        }
        if (yourDist >= dist5)
        {
            dist6 = dist5;
            distHolder6 = distHolder5;
            dist5 = yourDist;
            yourDistHoldingText = distHolder5Text;
        }
        if (yourDist >= dist4)
        {
            dist5 = dist4;
            distHolder5 = distHolder4;
            dist4 = yourDist;
            yourDistHoldingText = distHolder4Text;
        }
        if (yourDist >= dist3)
        {
            dist4 = dist3;
            distHolder4 = distHolder3;
            dist3 = yourDist;
            yourDistHoldingText = distHolder3Text;
        }
        if (yourDist >= dist2)
        {
            dist3 = dist2;
            distHolder3 = distHolder2;
            dist2 = yourDist;
            yourDistHoldingText = distHolder2Text;
        }
        if (yourDist >= dist1)
        {
            dist2 = dist1;
            distHolder2 = distHolder1;
            dist1 = yourDist;
            yourDistHoldingText = distHolder1Text;
        }
    }

    void DisplayDists()
    {
        distHolder1Text.text = distHolder1;
        distHolder2Text.text = distHolder2;
        distHolder3Text.text = distHolder3;
        distHolder4Text.text = distHolder4;
        distHolder5Text.text = distHolder5;
        distHolder6Text.text = distHolder6;
        distHolder7Text.text = distHolder7;
        distHolder8Text.text = distHolder8;
        distHolder9Text.text = distHolder9;
        distHolder10Text.text = distHolder10;

        dist1Text.text = dist1.ToString("0.0") + "m";
        dist2Text.text = dist2.ToString("0.0") + "m";
        dist3Text.text = dist3.ToString("0.0") + "m";
        dist4Text.text = dist4.ToString("0.0") + "m";
        dist5Text.text = dist5.ToString("0.0") + "m";
        dist6Text.text = dist6.ToString("0.0") + "m";
        dist7Text.text = dist7.ToString("0.0") + "m";
        dist8Text.text = dist8.ToString("0.0") + "m";
        dist9Text.text = dist9.ToString("0.0") + "m";
        dist10Text.text = dist10.ToString("0.0") + "m";
    }

    public void UpdateName()
    {
        if(yourDistHoldingText != null && yourScoreHoldingText != null)
        {
            yourScoreHoldingText.text = nameInput.text;
            yourDistHoldingText.text = nameInput.text;
        }else if(yourDistHoldingText != null)
        {
            yourDistHoldingText.text = nameInput.text;
        }else if(yourScoreHoldingText != null)
        {
            yourScoreHoldingText.text = nameInput.text;
        }
    }

    public void EndInput()
    {
        if (yourDistHoldingText != null && yourScoreHoldingText != null)
        {
            yourScoreHoldingText.text = nameInput.text;
            yourDistHoldingText.text = nameInput.text;
        }
        else if (yourDistHoldingText != null)
        {
            yourDistHoldingText.text = nameInput.text;
        }
        else if (yourScoreHoldingText != null)
        {
            yourScoreHoldingText.text = nameInput.text;
        }

        PlayerPrefs.SetInt("score1", score1);
        PlayerPrefs.SetInt("score2", score2);
        PlayerPrefs.SetInt("score3", score3);
        PlayerPrefs.SetInt("score4", score4);
        PlayerPrefs.SetInt("score5", score5);
        PlayerPrefs.SetInt("score6", score6);
        PlayerPrefs.SetInt("score7", score7);
        PlayerPrefs.SetInt("score8", score8);
        PlayerPrefs.SetInt("score9", score9);
        PlayerPrefs.SetInt("score10", score10);

        PlayerPrefs.SetFloat("dist1", dist1);
        PlayerPrefs.SetFloat("dist2", dist2);
        PlayerPrefs.SetFloat("dist3", dist3);
        PlayerPrefs.SetFloat("dist4", dist4);
        PlayerPrefs.SetFloat("dist5", dist5);
        PlayerPrefs.SetFloat("dist6", dist6);
        PlayerPrefs.SetFloat("dist7", dist7);
        PlayerPrefs.SetFloat("dist8", dist8);
        PlayerPrefs.SetFloat("dist9", dist9);
        PlayerPrefs.SetFloat("dist10", dist10);

        PlayerPrefs.SetString("scoreHolder1", scoreHolder1Text.text);
        PlayerPrefs.SetString("scoreHolder2", scoreHolder2Text.text);
        PlayerPrefs.SetString("scoreHolder3", scoreHolder3Text.text);
        PlayerPrefs.SetString("scoreHolder4", scoreHolder4Text.text);
        PlayerPrefs.SetString("scoreHolder5", scoreHolder5Text.text);
        PlayerPrefs.SetString("scoreHolder6", scoreHolder6Text.text);
        PlayerPrefs.SetString("scoreHolder7", scoreHolder7Text.text);
        PlayerPrefs.SetString("scoreHolder8", scoreHolder8Text.text);
        PlayerPrefs.SetString("scoreHolder9", scoreHolder9Text.text);
        PlayerPrefs.SetString("scoreHolder10", scoreHolder10Text.text);

        PlayerPrefs.SetString("distHolder1", distHolder1Text.text);
        PlayerPrefs.SetString("distHolder2", distHolder2Text.text);
        PlayerPrefs.SetString("distHolder3", distHolder3Text.text);
        PlayerPrefs.SetString("distHolder4", distHolder4Text.text);
        PlayerPrefs.SetString("distHolder5", distHolder5Text.text);
        PlayerPrefs.SetString("distHolder6", distHolder6Text.text);
        PlayerPrefs.SetString("distHolder7", distHolder7Text.text);
        PlayerPrefs.SetString("distHolder8", distHolder8Text.text);
        PlayerPrefs.SetString("distHolder9", distHolder9Text.text);
        PlayerPrefs.SetString("distHolder10", distHolder10Text.text);

        nameInput.gameObject.SetActive(false);
        enterNameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
