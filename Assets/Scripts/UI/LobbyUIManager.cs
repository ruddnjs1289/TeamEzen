using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* 20230814
 * 각각의 활성화 버튼 함수 작성
 */
public class LobbyUIManager : MonoBehaviour
{
    // 메인 로비 UI 버튼
    public GameObject gSettingPanel;

    public GameObject gSkill; //스킬
    public GameObject gCharacterSelect;//캐릭터 
    public GameObject gStage;//스테이지

    // 설정 버튼
    public void ButtonSetting()
    {
        gSettingPanel.SetActive(true);
    }
    // 인벤토리 버튼
    public void ButtonInventory()
    {

    }
    // 스테이지 버튼
    public void ButtonStage()
    {
    }
    // 캐릭터 버튼
    public void ButtonCharacter()
    {
        gCharacterSelect.SetActive(true);
        
    }
    public void ButtonBack()
    {
        gCharacterSelect.SetActive(false);

    }
    // 스킬 버튼
    public void ButtonSkill()
    {

    }


}
