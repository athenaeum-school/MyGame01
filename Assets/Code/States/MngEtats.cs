using UnityEngine;
using Assets.Code.States;
using Assets.Code.Interfaces;


public class MngEtats : MonoBehaviour
{
	public GameData gameData;
	private ETatsi activeState;
	public static MngEtats instance;
	
	void Awake()
	{
		if(instance == null) {
			instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			DestroyImmediate(gameObject);
		}
	}
	
	void OnGUI()
	{
		activeState.Render();
	}
	
	void Start()
	{
		activeState = new StartEtats(this);
		gameData = GetComponent<GameData>();
	}
	void Update()
	{
		if(activeState != null)
			activeState.StateUpdate();
	}
	public void SwEtats(ETatsi newState)
	{
		activeState = newState;
	}
}