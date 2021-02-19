using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnableObject : MonoBehaviour
{
    [SerializeField] private GameObject m_ObjectToCheckFor;
    [SerializeField] private GameObject m_ObjectToDisableEnable;
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == m_ObjectToCheckFor)
		{
			m_ObjectToDisableEnable.SetActive(false);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == m_ObjectToCheckFor)
		{
			m_ObjectToDisableEnable.SetActive(true);
		}
	}
}
