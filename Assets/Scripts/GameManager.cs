using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
	// public readonly int BOOT_STATE_ID    = Animator.StringToHash("BootSMBehaviour");
	// public readonly int LOAD_STATE_ID    = Animator.StringToHash("LoadAssetsSMBehaviour");
	// public readonly int TITLE_STATE_ID   = Animator.StringToHash("TitleSMBehaviour");
	// public readonly int GAME_STATE_ID    = Animator.StringToHash("GameSMBehaviour");
	// public readonly int ENDGAME_STATE_ID = Animator.StringToHash("EndGameSMBehaviour");

	private Animator m_animator;
	// private IStateMachine[] m_stateMachineArray;

	void Awake()
	{
		m_animator = this.GetComponent<Animator>();
		Assert.IsNotNull(m_animator, "Animator component does not exist!");
	}

	void Start ()
	{
		// add StateMachineBehaviour here
		IStateMachine[] stateMachineArray = new IStateMachine[]
		{
			m_animator.GetBehaviour<BootSMBehaviour>(),
			m_animator.GetBehaviour<LoadAssetsSMBehaviour>(),
			m_animator.GetBehaviour<TitleSMBehaviour>(),
			m_animator.GetBehaviour<GameSMBehaviour>(),
			m_animator.GetBehaviour<EndGameSMBehaviour>()
		};

		for(int idx = stateMachineArray.Length-1; idx >= 0; --idx)
		{
			Assert.IsNotNull(stateMachineArray[idx], "State Machine [" + idx + "] does not exist!");
			stateMachineArray[idx].SetGameManager(this);
		}
	}

	public void OnStateEnter()
	{

	}

	public void OnStateUpdate()
	{

	}

	public void OnStateExit()
	{
		
	}
}
