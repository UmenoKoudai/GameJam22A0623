using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountText : MonoBehaviour
{
    // ///////////////////////
    /* �J�E���g����e�L�X�g */
    // ///////////////////////

    Text text;
    // �J�E���g������ɂȂ�����B��
    int _invisibleCount;
    
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    // �J�E���g�̍X�V�A
    public void SetCount(int count)
    {
        text.text = count.ToString();
    }
}
