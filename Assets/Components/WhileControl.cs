using System.Collections.Generic;
using UnityEngine;

public class WhileControl : ForControl{
	// Advice: FYFY component aims to contain only public members (according to Entity-Component-System paradigm).
	public List<string> condition; // La condition du while sous forme d'une liste de string
}