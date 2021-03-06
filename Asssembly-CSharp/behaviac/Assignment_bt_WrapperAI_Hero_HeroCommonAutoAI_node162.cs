using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Assignment_bt_WrapperAI_Hero_HeroCommonAutoAI_node162 : Assignment
	{
		private SkillSlotType opr_p0;

		public Assignment_bt_WrapperAI_Hero_HeroCommonAutoAI_node162()
		{
			this.opr_p0 = SkillSlotType.SLOT_SKILL_2;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int skillAttackRange = ((ObjAgent)pAgent).GetSkillAttackRange(this.opr_p0);
			pAgent.SetVariable<int>("p_skillAttackRange", skillAttackRange, 1944425156u);
			return result;
		}
	}
}
