using UnityEngine;
using System.Collections;

public class PedestalManager : MonoBehaviour {

	public GameObject Pedestal;

	public float MaxDistance;
	public float MinDistance;

	public float MinHeight;
	public float MaxHeight;

	public int NumberOfPedestals = 10;

	public ArrayList Pedestals;

	// Use this for initialization
	void Start () {
		GeneratePedestals();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GeneratePedestals() {
		ArrayList Pedestals = new ArrayList();
		for (int i = 1; i < NumberOfPedestals; i++) {
			Pedestals.Add((GameObject)Instantiate (Pedestal, GeneratePedestalPosition(i), Quaternion.identity));
		}
	}

	Vector3 GeneratePedestalPosition(int pedestalIndex) {
		return new Vector3(Random.Range(MinDistance, MaxDistance) * pedestalIndex, Random.Range(MinHeight, MaxHeight), 0);
	}
}
