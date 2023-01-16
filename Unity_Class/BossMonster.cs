using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster
{
    public string Name;
    public int PointValue;

    public BossMonster(string name, int points)
    {
        this.Name = name;
        this.PointValue = points;
    }

    ~BossMonster()
    {
        Debug.Log("Boss Monster destroyed");
    }
}
