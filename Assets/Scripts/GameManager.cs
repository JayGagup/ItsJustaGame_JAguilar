using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalOne goal;
    private float elapsedTime = 0;
    private bool isRunning = true;
    private bool isFinished = false;
    private bool isGameOver = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGameOver = goal.isSolved;

        if (isRunning && !isGameOver) // Add the !isGameOver condition
        {
            elapsedTime += Time.deltaTime;
        }
    }


    public void FinishedGame()
    {
        isRunning = false;
        isFinished = true;

        // Add any additional actions you need when the game is finished
    }


    private void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "GOOD JOB!");

        }


        if (isRunning)
        {
            // If the game is running, show the current time
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }
        else if (isFinished)
        {

            GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
            GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
        }

    }
}
