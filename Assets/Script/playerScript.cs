using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    float m_animStartTime;
    public GameObject yariprehab;
    // Start is called before the first frame update
    Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            Debug.Log("Ｚおしつづける");
            _anim.enabled = true;
            _anim.SetBool("yarikamae", true);
            _anim.SetBool("yarinageru", false);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            _anim.SetBool("yarikamae", false);
            _anim.SetBool("yarinageru", true);
            Debug.Log("Ｚはなすうう");
        }
    }
}
