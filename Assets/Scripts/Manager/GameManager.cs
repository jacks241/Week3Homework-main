﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;
    int i = 0;
    int g = 0;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private Ball ballPrefab;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    void Start()
    {
        
    }

    void Awake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab);
        }

        for(i = 0; i < TOTAL_ROWS; i++)
        {
            for(g = 0; g < PIECE_COUNT_PER_ROW; g++)
            {
                Instantiate(piecePrefab);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
    }
    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with
}
