using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample : MonoBehaviour
{
    List<Minion> minions = null;

    // Start is called before the first frame update
    void Start()
    {
        minions = new List<Minion>();
        minions.Add(new Minion("Ted"));
        minions.Add(new Minion("Ned"));
        minions.Add(new Minion("Fred"));
        minions.Add(new Minion("ed"));
        minions.Add(new Minion("Phil"));


        
    }

    void OnDisable()
    {
        minions = null;
    }
}
