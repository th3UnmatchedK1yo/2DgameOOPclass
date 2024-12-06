using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Character
{
    public int Hp { get; private set; }
    public float Speed { get; set; }
    public Rigidbody2D Body { get; private set; }
    public Animator Animator { get; private set; }
    public BoxCollider2D BoxCollider2D { get; private set; }
    public Transform Transform { get; private set; }
    public GameObject Prefab { get; private set; }
    public string Name { get; private set; }

    public Character(GameObject gameObject, int hp = 4, float speed = 5f)
    {
        if (gameObject == null) throw new ArgumentNullException(nameof(gameObject));

        Hp = hp;
        Speed = speed;
        Body = gameObject.GetComponent<Rigidbody2D>();
        Animator = gameObject.GetComponent<Animator>();
        BoxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        Transform = gameObject.transform;
        Prefab = gameObject;
        Name = gameObject.name;
    }
}