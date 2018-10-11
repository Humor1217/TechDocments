# Animator控制

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
