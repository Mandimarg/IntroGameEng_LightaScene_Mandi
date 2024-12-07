using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitTriggerHandler : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
