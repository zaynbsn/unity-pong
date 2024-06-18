using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI scoreTextLeft;
    public TextMeshProUGUI scoreTextRight;

    public Starter starter;
    private bool started = false;

    public GameObject ball;

    private int scoreLeft;
    private int scoreRight;

    private Vector3 startingPosition;

    private BallController ballController;

    // Start is called before the first frame update
    void Start()
    {
        this.ballController = this.ball.GetComponent<BallController>(); 
        this.startingPosition = this.ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.started)
        {
            return;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            this.started = true;
            this.starter.StartCountdown();
        }
    }

    public void StartGame() {
        this.ballController.Go();
    }

    public void ScoreGoalLeft() {
        scoreRight += 1;
        UpdateUI();
        ResetBall();
    }

    public void ScoreGoalRight() {
        scoreLeft += 1;
        UpdateUI();
        ResetBall();
    }


    private void UpdateUI() {
        this.scoreTextLeft.text = this.scoreLeft.ToString();
        this.scoreTextRight.text = this.scoreRight.ToString();
    }
    
    
    private void ResetBall() {
        this.ballController.Stop();
        this.ball.transform.position = this.startingPosition;
        this.starter.StartCountdown();
    }
    

}
