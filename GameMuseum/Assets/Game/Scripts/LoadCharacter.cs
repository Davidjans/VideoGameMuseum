using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    [SerializeField]
    private bool m_DoVR = true;
    [SerializeField]
    private GameObject m_NonVRCharacter;
    [SerializeField]
    private GameObject m_VRCharacter;
    void Start()
    {
		if (m_DoVR)
		{
            m_VRCharacter.SetActive(true);
            m_NonVRCharacter.SetActive(false);
        }
		if (!m_DoVR)
		{
            m_VRCharacter.SetActive(false);
            m_NonVRCharacter.SetActive(true);
		}
    }
}
