using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [Header("移動したいシーン名を入力")] [SerializeField] string _sceneName;
    public void ChangeScene(string _sceneName)
    {
        Debug.Log("Click");
        SceneManager.LoadScene(_sceneName);
    }

    public void Audio(string _sceneName)
    {
        StartCoroutine(Enumerator());

        IEnumerator Enumerator()
        {
            yield return new WaitForSeconds(1.0f);
            ChangeScene(_sceneName);
        }
    }
}