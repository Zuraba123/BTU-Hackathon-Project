using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader2 : MonoBehaviour
{
    public Transform player;
    

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
        player.position = new Vector3(140, 0, 130);
    }
}
