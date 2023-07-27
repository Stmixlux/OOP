using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shouter : Clickable
{
    public static string playerName { private get; set; }
    protected override void OnMouseEnter()
    {
        base.OnMouseEnter();
        Debug.Log("Oh, hi " + playerName);
    }
}
