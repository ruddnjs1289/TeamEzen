using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHg_Basic_Effect : SkillEffrct
{
    
    void Start()
    {        
        myFactory(GameManager.instance.objectFactory.CharHGBasicEffectFactory);
    }

}