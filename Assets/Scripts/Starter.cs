using UnityEngine;

public class Starter : MonoBehaviour
{
    private GameController gameController;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        animator = GetComponent<Animator>();
    }

    public void StartCountdown() {
        animator.SetTrigger("StartCountdown");
    }

    public void StartGame() {
        gameController.StartGame();
    }
}
