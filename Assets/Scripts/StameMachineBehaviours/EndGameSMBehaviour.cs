using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSMBehaviour : StateMachineBehaviour, IStateMachine
{
    private GameManager m_gameManager;

	public void SetGameManager(GameManager p_gameManager)
    {
        m_gameManager = p_gameManager;
    }
}
