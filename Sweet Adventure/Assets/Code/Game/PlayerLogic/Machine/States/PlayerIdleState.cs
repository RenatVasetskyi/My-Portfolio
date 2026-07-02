using Code.Game.PlayerLogic.Machine.Interfaces;
using UnityEngine;

namespace Code.Game.PlayerLogic.Machine.States
{
    public class PlayerIdleState : IPlayerState
    {
        private readonly Player _player;

        public PlayerIdleState(Player player)
        {
            _player = player;
        }
        
        public void Enter()
        {
            _player.Rigidbody.linearVelocity = new Vector2(0, _player.Rigidbody.linearVelocity.y);
            _player.PlayerSpineAnimator.PlayIdle();
        }

        public void Exit()
        {
        }

        public void OnUpdate()
        {
        }

        public void OnFixedUpdate()
        {
        }
    }
}