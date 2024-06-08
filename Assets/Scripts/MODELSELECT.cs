using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MODELSELECT : MonoBehaviour
{
public GameObject arch;
public GameObject str;
public GameObject mep;

public GameObject arch_B;
public GameObject str_B;
public GameObject MEP_B;
public GameObject Coordination_B;

public void archclicked()
{
	arch.SetActive(true);
	str.SetActive(false);
	mep.SetActive(false);


}

public void strclicked()
{
	arch.SetActive(false);
	str.SetActive(true);
	mep.SetActive(false);


}

public void mepclicked()
{
	arch.SetActive(false);
	str.SetActive(false);
	mep.SetActive(true);


}



public void coordinationclicked()
{
	arch.SetActive(false);
	str.SetActive(true);
	mep.SetActive(true);


}

}
