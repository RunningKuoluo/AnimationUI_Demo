using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_AniamtiionCtrl : MonoBehaviour
{
    public Animator main_Ani;
    public Animator secend_Ani;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_OpenSecend()
    {
        if (main_Ani == null || secend_Ani == null) return;
        main_Ani.SetBool("IsOpen", false);
        secend_Ani.SetBool("IsOpen", true);
    }

    public void OnClick_SecendBack()
    {
        if (main_Ani == null || secend_Ani == null) return;
        main_Ani.SetBool("IsOpen", true);
        secend_Ani.SetBool("IsOpen", false);
    }

    private Animator previousAni;

    public void OnClick_OpenItemBtn(Animator ani)
    {
        ani.SetBool("IsOpen", true);
        if(previousAni != null)
        {
            previousAni.SetBool("IsOpen", false);
        }
        previousAni = ani;
    }
}
