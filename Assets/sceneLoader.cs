using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneLoader : MonoBehaviour
{
    public string text;
    public InputField iField;
    public GameObject menu;
    public Transform player;
    void Start()
    {
        menu.SetActive (false);
    }

    void OnTriggerEnter(Collider other)
    {
        menu.SetActive (true);
        Debug.Log(iField.text);
        text = iField.text;
        if (text == "demetre")
        {
            menu.SetActive(true);
            Debug.Log("Welcome back Mr. Carter");
            SceneManager.LoadScene(1);
            player.position = new Vector3(140, 0, 130);
        }
        else
        {
            Debug.Log("I Don't Know You!");
        }
    }
}
