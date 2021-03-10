using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOpenings : MonoBehaviour
{
	[SerializeField] private List<GameObject> m_ToDisable;
	[SerializeField] private List<GameObject> m_ToEnable;

	private void OnTriggerEnter(Collider other)
	{
		foreach (var item in m_ToEnable)
		{
			item.SetActive(true);
		}
		foreach (var item in m_ToDisable)
		{
			item.SetActive(false);
		}
	}
}
