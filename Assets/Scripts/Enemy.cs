using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameController Controller;
    public Character Character;

    private float _destinationTimer;
    private void OnEnable()
    {
        Character.Movement.SetSpeed(5f);
        Controller.AddObject(gameObject);
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
}
