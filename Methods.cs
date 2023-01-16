using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{


    public int goldAmount;
    // Start is called before the first frame update
    void OnDisable()
    {
        NPC myNPC = new NPC();
        myNPC.Talk();

        myNPC.SetGold(goldAmount);
        Debug.Log(myNPC.GetGold());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
