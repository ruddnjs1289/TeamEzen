using Params;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance;
    public GameObject objLoadingPanel;
    public Image imgLoadSliderImage;
    private StageParams.STAGE_TYPE _stCurrentStageType = StageParams.STAGE_TYPE.NONE;
    public delegate bool EpisodeBtnClickedDelegate(StageParams.STAGE_TYPE staygeType, GameObject target = null);
    public static event EpisodeBtnClickedDelegate EpisodeBtnClicked;
    public List<GameObject> Charactors;
    //임시로 넣어 놓은 플레이어
    public GameObject player;

    public void InitializeStage(StageParams.STAGE_TYPE type, GameObject player)
    {
        _stCurrentStageType = type;
        //패널로 로딩창 -> 이니셜라이즈 coroutine으로 작성 종료시 로딩창 클로즈
        EpisodeBtnClicked(_stCurrentStageType, player);

    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        print(GameManager.instance.stageType.ToString());
        //게임메니저에서 데이터 받아오기
        player = GameManager.instance.stageFactory.characterFactory.listPool[0];
        InitializeStage(GameManager.instance.stageType, player);
    }





}
