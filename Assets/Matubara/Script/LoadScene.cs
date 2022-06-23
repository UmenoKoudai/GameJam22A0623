using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [Header("�ړ��������V�[���������")] [SerializeField] string _sceneName;
    public void ChangeScene()
    {
        Debug.Log("Click");
        SceneManager.LoadScene(_sceneName);
    }

    public void Audio(float _delay)
    {
        Invoke("ChageScene", _delay);
    }
}