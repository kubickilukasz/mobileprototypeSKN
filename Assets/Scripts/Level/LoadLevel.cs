using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour{

    [SerializeField]
    string nameLevel;

    bool isLoading = false;

    public void Load() {
        SceneManager.LoadScene(nameLevel);
    }

}
