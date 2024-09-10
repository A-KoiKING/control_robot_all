using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    private GameInputs _gameInputs;
    private void Awake()
    {
        // Action�X�N���v�g�̃C���X�^���X����
        _gameInputs = new GameInputs();

        _gameInputs.UI.Next.performed += OnNext;

        _gameInputs.Enable();
    }

    private void OnDestroy()
    {
        // ���g�ŃC���X�^���X������Action�N���X��IDisposable���������Ă���̂ŁA
        // �K��Dispose����K�v������
        _gameInputs?.Dispose();
    }

    private void OnNext(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene("MainScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
