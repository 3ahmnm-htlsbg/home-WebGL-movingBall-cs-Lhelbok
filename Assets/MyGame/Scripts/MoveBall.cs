using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private GameObject[] BallPosition;
    public GameObject Ball;
    public int lastValue;
    public int randomValue;

    public void SetBallPosition()
    {
        Ball.transform.position = BallPosition[CalcRandomValue()].transform.position;
        // Set the ball position to a random value
    }
    private int CalcRandomValue()
    {
        randomValue = UnityEngine.Random.Range(0, 4);
        while (randomValue == lastValue)
        // Ensure that a new position is calculated
        {
            randomValue = UnityEngine.Random.Range(0, 4);
        }
        lastValue = randomValue;
        return randomValue;
    }
}
