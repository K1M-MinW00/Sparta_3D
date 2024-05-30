using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    public void StartBtnClick()
    {
        GameManager.Instance.StartGame();
    }
    public void RetryBtnClick()
    {
        GameManager.Instance.RetryGame();
    }
    public void ExitBtnClick()
    {
        GameManager.Instance.Exit();
    }

}
