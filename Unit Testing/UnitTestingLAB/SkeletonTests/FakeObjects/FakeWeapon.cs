using Skeleton.Interfaces;

namespace SkeletonTests.FakeObjects
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 10;

        public int DurabilityPoints => 10;

        public void Attack(ITarget target)
        {
            target.TakeAttack(this.AttackPoints);
        }
    }
}
