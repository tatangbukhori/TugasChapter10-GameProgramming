using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_MoveScene : MonoBehaviour
{
    public string namaScene;

    public void PindahScene()
    {
        Scene sceneIni = SceneManager.GetActiveScene();
        if (sceneIni.name != namaScene)
        {
            SceneManager.LoadScene(namaScene);
        }
    }
}

