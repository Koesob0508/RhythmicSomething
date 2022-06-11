using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetBuilder : MonoBehaviour
{
    public GameManager gameManager;
    public UIManager uiManager;
    public PlayerController playerController;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);    
    }

    public void ShowSheetBuilder(int _stageStep)
    {
        Debug.Log("Show Sheet Builder, Stage : " + _stageStep);
    }

    public void HideSheetBuilder()
    {
        Debug.Log("Hide Sheet Builder");
    }

    private void CompleteBuild()
    {
        this.HideSheetBuilder();
        // PlayerController에게 보내는 함수
        gameManager.CompleteBuild();
    }

    // Player Controller에게 보내는 함수
}
