using TMPro; // TMP_Text
using UnityEngine;

// Updates the HUD every frame from the ScoreManager and PlayerPowerUps.
public class HUDController : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] private TMP_Text scoreText;

    private void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        // The Score property from Lab 4: anyone can read it
        scoreText.text = "Score: " + ScoreManager.Instance.Score;
    }

    


}
