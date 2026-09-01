using System.Net.Security;
using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy
    {
        public int damage;
        protected int aiLevel;

        public virtual void Attack(Entity targrt) {
            
        }

        protected virtual void Patrol()
        {

        }

    }
}
