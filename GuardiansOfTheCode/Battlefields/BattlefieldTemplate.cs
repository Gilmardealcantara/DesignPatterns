using System.Text;

namespace GuardiansOfTheCode.Battlefields
{
    public abstract class BattlefieldTemplate
    {
        public string DescribeSky() => "The Battlefield sky is blue";

        public abstract string DescribeGround();
        public abstract string DescribeClimate();
        public abstract string DescribeEffects();

        public string Describe()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(DescribeSky());
            builder.Append("\r\n");
            builder.Append(DescribeClimate());
            builder.Append("\r\n");
            builder.Append(DescribeEffects());
            builder.Append("\r\n");
            builder.Append(DescribeGround());
            builder.Append("\r\n");
            return builder.ToString();
        }
    }
}