using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemus1 : MonoBehaviour
{
    public Transform player;
        void OnTriggerEnter(Collider other)
        {
            SceneManager.LoadScene(0);
            player.position = new Vector3(259.75f, 2.75f, 225f);
        }
}
