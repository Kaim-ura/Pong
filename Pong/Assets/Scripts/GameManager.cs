using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Paddle playerPaddle;
    [SerializeField] Paddle computerPaddle;
    [SerializeField] Text playerScoreText;
    [SerializeField] Text computerScoreText;
    [SerializeField] Ball ball;

    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetTheBallPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }

}
