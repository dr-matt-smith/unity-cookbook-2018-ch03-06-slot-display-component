using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerInventoryKeys))]
public class PlayerInventoryDisplayKeys : MonoBehaviour 
{
	// default to size 1 - but user can overried in Inspector at Design-Time
	public PickupUI[] slotsStars = new PickupUI[1];

	// default to size 1 - but user can overried in Inspector at Design-Time
	public PickupUI[] slotsKeys = new PickupUI[1];

	public void OnChangeStarTotal(int starTotal)
	{
		int numInventorySlots = slotsStars.Length;
		for(int i = 0; i < numInventorySlots; i++){
			PickupUI slot = slotsStars[i];
			if(i < starTotal)
				slot.DisplayColorIcon();
			else
				slot.DisplayGreyIcon();
		}
	}

	public void OnChangeKeyTotal(int keyTotal)
	{
		int numInventorySlots = slotsKeys.Length;
		for(int i = 0; i < numInventorySlots; i++){
			PickupUI slot = slotsKeys[i];
			if(i < keyTotal)
				slot.DisplayColorIcon();
			else
				slot.DisplayGreyIcon();
		}
	}
}
