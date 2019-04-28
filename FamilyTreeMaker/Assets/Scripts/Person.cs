using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Person : MonoBehaviour
{
    [SerializeField]
    Person mother;
    [SerializeField]
    Person father;
    [SerializeField]
    List<Person> siblings = new List<Person>();
    [SerializeField]
    Person partner;
    [SerializeField]
    List<Person> children = new List<Person>();

    public string firstName;
    public string lastName;
    public Gender gender;
    [SerializeField]
    public DateTime dob;

    private Texture2D box;

    public void Start()
    {

    }

}
