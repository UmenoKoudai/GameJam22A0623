using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    // /////////////////////////////////
    /* �Q�[���{�҂̃V�[���}�l�[�W���[ */
    // /////////////////////////////////

    [SerializeField] GameSceneUI _gameSceneUI;
    [SerializeField] Actor _player;
    [SerializeField] Actor _enemy;
    [SerializeField] GameObject _attackButton;
    [SerializeField] CountText _countText;
    // �U�����\�ɂȂ�܂ł̃J�E���g
    [SerializeField] int _count;
    // �T�E���h�}�l�[�W���[
    SoundManager soundManager;

    void Awake()
    {
        soundManager = GetComponent<SoundManager>();
    }

    void Start()
    {
        soundManager.Play("SE_�Ă���[��");
        _player._attack = Attack;
        _enemy._attack = Attack;
        _countText.SetCount(_count);
        StartCoroutine(Timer());
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(_gameSceneUI.ActivePenaltyPanel());
        }
    }

    // �Q�[���J�n����J�E���g���n�߂�
    IEnumerator Timer()
    {
        for (int i = _count - 1; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1.0f);
            _countText.SetCount(i);
        }
        _attackButton.SetActive(true);
        _enemy.enabled = true;
    }

    // �U��
    public IEnumerator Attack(bool isPlayer)
    {
        soundManager.Play("SE_�a��");
        _player.StopCoroutine(_player._autoAction);
        _enemy.StopCoroutine(_enemy._autoAction);
        _attackButton.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        _gameSceneUI.ActiveResultItem(isPlayer);
        Debug.Log("�U�����܂���");
    }
}
