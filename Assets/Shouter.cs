using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shouter : Clickable
{
    protected override void OnMouseEnter()
    {
        base.OnMouseEnter();
        Debug.Log("Oh, hi MARK");
    }
}
