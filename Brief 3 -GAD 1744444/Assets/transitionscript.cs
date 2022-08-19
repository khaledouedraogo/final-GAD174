using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionscript : MonoBehaviour
{
     void OnEnable()
    {
        SceneManager.LoadScene("starting menu scene 2", LoadSceneMode.Single);
    }

}
