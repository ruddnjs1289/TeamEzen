using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using Params;

public class CharAr_Active_01 : AttackType
{
    //스킬레벨업 변수들 스킬마다 써주기  
    //이펙트를 경로타고 넣기
    //디저블로 스타트를
    private void OnDisable()
    {
        SkillFolderPath = FolderPath.PARAMS_ACTIVE_SKILL;
        SkillParamsPath = FileName.STR_JSON_CHARAR_ACTIVE_01_PARAMS;
        PLUS_VAL = 10f;
        PLUS_MAG = 10f;
        PLUS_TARGET_COUNT = 0f;
        PLUS_ATTACK_COUNT = 0f;
        SetType();
        LevelUpValue();
        InitParams();
        LoadEffect();
    }
    
    public override void SetType()
    {
        base.SetType();
        skillType = "ACTIVE";
        enumSkillType = SkillType.ACTIVE;
    }
    public override void SetDefault()
    {
        fSkillLevel = 1;
        fId = 200;
        strName = "Act1";
        strDiscription = "ok";
        //strIconpath=
        strEffectPath = FolderPath.PREFABS_ACTIVE_EFFECT;
        strEffectName = FileName.STR_CHA_AR_ACTIVE_01_EFFECT;
        fSkillExp = 0;
        fSkillRequireExp = 100;
        fUnlockLevel = 1;
        fUnlockHidenLevel = 20;
        fTimer = 0;
        fCoolTime = 1;
        fDuration = 1;
        fSkillCoolReduce = 0;
        fRange = 50;
        fMaxRange = 10;
        fValue = 10;
        fHidenValue = 10;
        fMagnification = 10;
        fTargetCount = 1;
        fAttackCount = 1;
        fBulletCount = 1;
        bisUnlockSkill = false;
        bisUnlockHiden = false;
        bisCanUse = false;
        bisActtivate = false;
    }
    public override void SkillHidenUnlock()
    {
        base.SkillHidenUnlock();
    }
}
