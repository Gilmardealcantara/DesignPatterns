namespace GuardiansOfTheCode.Battlefields
{
    public class VolcanoBattleField : BattlefieldTemplate
    {
        public override string DescribeClimate() => "There's fog and dust everywhere. The heat melts the armor";
        public override string DescribeEffects() => "There are flames jumping from underneath";
        public override string DescribeGround() => "The ground is rock and unstable";
    }
}