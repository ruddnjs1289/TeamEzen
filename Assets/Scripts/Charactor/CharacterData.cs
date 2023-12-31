using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "character", menuName = "Scriptable Object/character", order = int.MaxValue)]
public class CharacterData : ScriptableObject
{
    //인덱스
    public float fId;
    //캐릭터 사진
    public string sImage;
    //이름
    public string strName;
    //레벨
    public float fLevel;
    //체력
    public float fHealth;
    //공격력
    public float fAtk;
    //방어력
    public float fDef;
    //크리티컬 확률%
    public float fCriticalPer;
    //크리티컬 데미지 %
    public float fCriticalDmg;
    //회피
    public float fMiss;
    //이동속도
    public float fMoveSpeed;
    //공격속도
    public float fAtkSpeed;
    //쿨타임 감소
    public float fCoolDownReduction;
    //경험치
    public float fExp;
    //방어구 관통
    public float fDefBreak;
    //크리티컬 저항
    public float fCriticalResist;
    //데미지 감소%
    public float fDamageReduction;
    //체력흡수
    public float fHealthSteel;
    //IncreasedBuffDuration,스킬 버프 지속 시간 증가
    public float fIBD;
    //HealthRecoveryRate,체력회복 속도
    public float fHRR;
    //회복률(회복이 될 상태일때 회복 수치를 증가)
    public float fRecoveryRate;
    //시야 사거리
    public float fSightRange;
    //기본 사거리
    public float fDefaultRange;
    //속성(물,불 ,나무)
    public float fProperty;
    //설명
    public string strDescription;
    //타입 (어떤 종류의 캐릭인지)
    public float fType;
    //궁극기 게이지
    public float fUltimateGauge;
    //소유하고있는지 없는지
    public bool bIsOwn;
 
}
