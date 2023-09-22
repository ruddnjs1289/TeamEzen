using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SkillEffrct : MonoBehaviour
    //해당캐릭 
{//적과의 충돌감지,대미지관련값 받아오고 마저 계산(o)
 //몬스터와 캐릭터에게 대미지값 전달
    FactoryManager factoryManager;
    
    protected float fSpeed=100f;
    protected Vector3 Firepiont;
    protected float fRancri;
    protected float fRanmondod;
    protected float fMonDadge;
    protected float fMonDefense;
    protected float fMonCriresi;
    protected float fTotalDamage;
    public  float fRange;
    protected float fMonProperty;
    protected Stat ChaStat;
    public Action SkillHit;//스킬 이펙트가 몬스터에게 충돌했을때   

    void Start()
    {
        
        fRancri = UnityEngine.Random.Range(0f, 100f);
        fRanmondod = UnityEngine.Random.Range(0f, 100f);
        Firepiont = gameObject.GetComponent<Transform>().position;
    }
    
    public void SkillActivationInit(ref Stat activeObjectStat)
    {
        ChaStat = activeObjectStat;
    }
    public  float CalculDamage(float chadam, float chacriper, float chacridam, float chadefenpier, float Attacker,
        float mondadge, float moncrire, float mondefen, float Defender)//받은 스텟으로 다시쓰기
    {
        if (fRanmondod < mondadge)
        {
            fTotalDamage = 0;
            return fTotalDamage;
        }
        else
        {
            if (fRancri <= chacriper - moncrire)
            {
                fTotalDamage = (chadam * chacridam * (mondefen - chadefenpier / mondefen + 100)) * CheckPro(Attacker, Defender);
            }
            else
            {
                fTotalDamage = chadam * (mondefen - chadefenpier / mondefen + 100) * CheckPro(Attacker, Defender);
            }
            return fTotalDamage;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log(other.tag);
            var monsterStat = other.GetComponent<Stat>();
            fMonDadge = monsterStat.fMiss;
            fMonCriresi = monsterStat.fCriticalResist;
            fMonDefense = monsterStat.fDef;
            fMonProperty = monsterStat.fProperty;

            CalculDamage(ChaStat.fAtk, ChaStat.fCriticalPer, ChaStat.fCriticalDmg, ChaStat.fDefBreak, ChaStat.fProperty
                , fMonDadge, fMonCriresi, fMonDefense, fMonProperty);
            // 오류 있음
            monsterStat.fHealth -= fTotalDamage;

        }
    }
    public virtual float CheckPro(float Attacker, float Defender)
    {
        if (Attacker - Defender == -1 || Attacker - Defender == 2)
        {//AttackerWin;
            return 1.3f;
        }
        if (Attacker - Defender == 1 || Attacker - Defender == -2)
        {//AttackerLose;
            return 0.7f;
        }
        else
            return 1f;
    }
    public virtual void CheckDistance(Vector3 firepoint,float range)
    {

        float distance = Vector3.Distance(firepoint, this.transform.position);
        Debug.Log("ran" + range);
        Debug.Log("dis" + distance);
        // Debug.Log("ran" + Ex_Active1Skill.Ex_Active1Params.fRange);
        if (distance > range)//Ex_Active1Params의 Range를 가져오는 방법??
        {
            // setactive 해주기
            factoryManager.SetObject(gameObject);
            

        }
        else
            return;
    }
    public virtual void MoveEffect()
    {        
        //GetComponent<Rigidbody>().AddForce(transform.forward * fSpeed*Time.deltaTime);
             
    }
    public virtual void myFactory(FactoryManager myFactoryManager)
    {
        factoryManager = myFactoryManager;
    }
   
}


/*public virtual float CalculDamage(float damage, float critical, float criticaldamage,
        float defensepierce, int chaprotype, float mondodge, float mondsfense, float moncriresi, int monprotype)
{//계산된 대미지,크리티컬확률,크리티컬대미지,방어구관통,캐릭터속성,
 //몬스터회피,몬스터방어,몬스터크리저항몬스터속성
 //대미지 계산
 // float calculdamage= damage
    damage = Charater1.damage;
    if (fRanmondod < mondodge)
    {
        float calculdamage = 0;
        return calculdamage;
    }
    else
    {
        if (fRancri <= critical - moncriresi)
        {

            float calculdamage =
                (damage * criticaldamage * (mondsfense - defensepierce) / (mondsfense + 100));
            return calculdamage;
        }
        else
        {
            float calculdamage = damage * (mondsfense - defensepierce) / (mondsfense + 100);
            return calculdamage;
        }//속성???
    }
}*/
/*if (other.tag == "Monster")
{
    var component = other.GetComponent<Monster>();
    fMonDadge = component.dodge;
    fMonCriresi = component.criticalresist;
    fMonDefense = component.defense;
    float fRancri = UnityEngine.Random.Range(0f, 100f);
    float fRanmondod = UnityEngine.Random.Range(0f, 100f);
    CalculDamage();
    SkillHit?.Invoke();//X?  X가 만족하면 뒤에거 실행  나중 실제 이펙트쪽으로 옮기기
                       //몬스터 피해입는곳
}*/