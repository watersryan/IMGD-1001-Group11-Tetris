using UnityEngine.UI;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public Text score;
    public Text highScore;

    void Start() 
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }


    [SerializeField] Text TextScoreUI;
    private int _scr;
    public int Score { get { return _scr; } set
        {
            _scr = value;
            TextScoreUI.text = Score.ToString();

            PlayerPrefs.SetInt("Score", Score);

            if (_scr > PlayerPrefs.GetInt("HighScore", 0)) 
            {
                PlayerPrefs.SetInt("HighScore", _scr);
                highScore.text = _scr.ToString();
            }
        }
    }

}

//After this go back to the main window and right click in the hierarchy menu
//Select create empty and name it “ScoreBoardScript”
//Drag the ‘ScoreBoardScript’ Object up to the Main Camera 
//Click on ScoreBoardScript and drag the actual C# script onto the object where it says “add component” 
//then there should be a box that says Text Score UI
//click on that and select “ScoreBoard”
//After that you should be all set.
