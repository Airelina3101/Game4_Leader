using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    public GameController Controller;
    public Character PlayerPrefab;
    public Vector3 Position1 = new Vector3();
    public Character Support;
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
        var support1 = Instantiate(Support, Controller.Player.transform.position + Position1, PlayerStartPoint.rotation);
        var support2 = Instantiate(Support, Controller.Player.transform.position - Position1, PlayerStartPoint.rotation);
    }
}