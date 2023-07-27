using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField] protected Material baseMaterial, highlightMaterial;
    protected MeshRenderer meshRenderer;

    virtual protected void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    protected virtual void OnMouseEnter()
    {
        meshRenderer.material = highlightMaterial;
    }

    protected virtual void OnMouseExit()
    {
        meshRenderer.material = baseMaterial;
    }
}
