using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : Clickable
{
    protected override void OnMouseEnter()
    {
        transform.localScale = Vector3.one * 2;
        base.OnMouseEnter();
    }

    protected override void OnMouseExit()
    {
        transform.localScale = Vector3.one;
        base.OnMouseExit();
    }
}
