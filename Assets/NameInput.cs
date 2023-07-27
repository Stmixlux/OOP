using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NameInput : MonoBehaviour
{
    TMP_InputField inputField;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void ChangeName()
    {
        Shouter.playerName = inputField.text;
    }

    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }
}
