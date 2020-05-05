using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameController Controller;
    public Character Character;
    public float StandartSpeed = 7f;

    private float _destinationTimer;
    private void OnEnable()
    {
        Character.Movement.SetSpeed(StandartSpeed);
        Controller.AddObject(gameObject);
    }

    private void OnDisable()
    {
        Controller.RemoveObject(gameObject);
    }
    void Start()
    {
    }
    void Update()
    {
        if (Controller.Player != null)
        {
            Character.Movement.MovePosition(Controller.Player.transform.position);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
