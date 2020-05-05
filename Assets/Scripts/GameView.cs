using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    public GameController Controller;
    public Character PlayerPrefab;
    public Transform PlayerStartPoint;
    public InputController InputController;
    public FollowCamera FollowCamera;


    public void Start()
    {
        SpawnPlayer();
    }
    private void SpawnPlayer()
    {
        var player = Instantiate(PlayerPrefab, PlayerStartPoint.position, PlayerStartPoint.rotation);
        if (player == null)
        {
            return;
        }

        InputController.SetPlayer(player);
        FollowCamera.Target = player.transform;
        Controller.Player = player;
    }
}