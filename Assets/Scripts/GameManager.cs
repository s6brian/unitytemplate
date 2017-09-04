using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
	private readonly int BOOT_STATE_ID    = Animator.StringToHash("BootSMBehaviour");
	private readonly int LOAD_STATE_ID    = Animator.StringToHash("LoadAssetsSMBehaviour");
	private readonly int TITLE_STATE_ID   = Animator.StringToHash("TitleSMBehaviour");
	private readonly int GAME_STATE_ID    = Animator.StringToHash("GameSMBehaviour");
	private readonly int ENDGAME_STATE_ID = Animator.StringToHash("EndGameSMBehaviour");

	private Animator m_animator;
	private IStateMachine[] m_stateMachineArray;

	void Awake()
	{
		m_animator = this.GetComponent<Animator>();
		Assert.IsNotNull(m_animator, "Animator component does not exist!");
	}

	void Start ()
	{
		// add StateMachineBehaviour here
		m_stateMachineArray = new IStateMachine[]
		{
			m_animator.GetBehaviour<BootSMBehaviour>(),
			m_animator.GetBehaviour<LoadAssetsSMBehaviour>(),
			m_animator.GetBehaviour<TitleSMBehaviour>(),
			m_animator.GetBehaviour<GameSMBehaviour>(),
			m_animator.GetBehaviour<EndGameSMBehaviour>()
		};

		for(int idx = m_stateMachineArray.Length-1; idx >= 0; --idx)
		{
			Assert.IsNotNull(m_stateMachineArray[idx], "State Machine [" + idx + "] does not exist!");
			m_stateMachineArray[idx].SetGameManager(this);
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
