using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)// 인스턴스가 없는 경우에 접근하려 하면 인스턴스를 할당
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        
        else if (_instance != this) // 인스턴스가 존재하는 경우 새로 생기는 인스턴스를 삭제
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameOver()
    {
        ToggleCursor();
        SceneManager.LoadScene("GameOver");
    }

    public void EndGame()
    {
        ToggleCursor();
        SceneManager.LoadScene("End");
    }

    public void ToggleCursor()
    {
        bool toggle = Cursor.lockState == CursorLockMode.Locked;
        Cursor.lockState = toggle ? CursorLockMode.None : CursorLockMode.Locked;
    }
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }


    public void RetryGame()
    {
        SceneManager.LoadScene("Start");
    }
}
