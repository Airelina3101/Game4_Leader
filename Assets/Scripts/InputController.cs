using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public struct FireInput
{
    public KeyCode Key;
}
public class InputController : MonoBehaviour
{
    private Character _player;

    public void SetPlayer(Character player)
    {
        _player = player;
    }
    private void Update()
    {
        if (_player == null)
        {
            return;
        }
        if (_player.Movement != null)
        {
            _player.Movement.MoveDirection(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));

            var plane = new Plane(Vector3.up, Vector3.zero);
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            if (plane.Raycast(ray, out distance))
            {
                var planePoint = ray.GetPoint(distance);
                var d = planePoint - _player.transform.position;
                _player.Movement.LookDirection(d);
            }
        }
    }
}
