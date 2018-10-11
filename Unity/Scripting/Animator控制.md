# Animator控制


![Animator](https://github.com/HumorLogic/TechDocments/blob/master/Unity/Scripting/images/Animator001.png)

新建AnimatorController脚本，挂到有Animator的模型上。
``` C#
using UnityEngine;

public class AnimatorController : MonoBehaviour {

    Animator m_Animator;
     	
	void Start () {

             m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
            m_Animator.SetBool("IsSing", true);
    
	}
    
    }

```
