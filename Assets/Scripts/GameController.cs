using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Controller")]
public class GameController : ScriptableObject
{
    public Character Player { get; set; }
    private readonly List<GameObject> _objects = new List<GameObject>();

	public void AddObject(GameObject obj)
	{
		_objects.Add(obj);
	}

	public void RemoveObject(GameObject obj)
	{
		_objects.Remove(obj);
	}
}
