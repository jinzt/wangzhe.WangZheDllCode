using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Assignment_bt_WrapperAI_Hero_HeroGuideFollow_node172 : Assignment
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			SkillSlotType value = SkillSlotType.SLOT_SKILL_1;
			pAgent.SetVariable<SkillSlotType>("p_curSlotType", value, 7107675u);
			return result;
		}
	}
}
