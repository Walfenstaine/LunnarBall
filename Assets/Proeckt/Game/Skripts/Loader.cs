using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;
public class Loader : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(YandexGame.savesData.lavel);
    }
}
