using UnityEngine;
using Assets.Code.States;
using Assets.Code.Interfaces;


public class StateManager : MonoBehaviour
{
	public GameData gameData;
	private IState activeState;
	public static StateManager instance;
	
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
		activeState = new StartState(this);
		gameData = GetComponent<GameData>();
	}
	void Update()
	{
		if(activeState != null)
			activeState.StateUpdate();
	}
	public void SwitchState(IState newState)
	{
		activeState = newState;
	}
}