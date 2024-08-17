using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetLevel : MonoBehaviour
{
    void Update()
    {
        // Detecta si se ha presionado la tecla 'R'
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Recarga la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
