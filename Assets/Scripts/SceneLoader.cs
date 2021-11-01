using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int scene2Load;

    public void LdScene()
    {
      SceneManager.LoadScene(scene2Load);
    }
}
