using Unity.Collections;

namespace GameplayAbilitySystem.AttributeSystem.Systems
{
    public interface IAttributeExecute<TAttribute, TAttributeModifier>
    where TAttribute : struct, IAttributeData
    where TAttributeModifier : struct, IAttributeModifier
    {
        void Execute(NativeArray<TAttribute> arg0, NativeArray<TAttributeModifier> arg1);
    }
}
