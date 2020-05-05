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

    // Update is called once per frame
    void Update()
    {
        if (Controller.Player != null)
        {
            var destinationTimer = 10f;
            var v = Controller.Player.transform.position - transform.position;
            var dist = v.magnitude;
            _destinationTimer -= Time.deltaTime;
            if (_destinationTimer <= 0f)
            {
                Character.Movement.MovePosition(Controller.Player.transform.position);
                _destinationTimer = destinationTimer;
            }
        }


    }
    /*private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }*/
}
