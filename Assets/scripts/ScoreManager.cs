using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [Header("score settings")]
    [SerializeField] private int score = 0;
    [SerializeField] private int pointsPerStep = 5;

    [Header("player")]
    [SerializeField] private Transform playerTransform; //player position

    [Header("UI")]
    [SerializeField] private TMP_Text scoreText; //show score on screen

    private float positionZ; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionZ = playerTransform.position.z; // get initial position from player



    }

    // Update is called once per frame
    void Update()
    {
        if( playerTransform.position.z > positionZ)
        {
            positionZ = playerTransform.position.z;

            score += pointsPerStep;
            Debug.Log("score: "+ score);
            scoreText.text = "score: " + score;
            


        }

    }
}
