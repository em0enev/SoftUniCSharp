namespace TheTankGame.Entities.Miscellaneous
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Parts.Contracts;

    public class VehicleAssembler : IAssembler
    {
        private readonly IList<IAttackModifyingPart> arsenalParts;
        private readonly IList<IDefenseModifyingPart> shellParts;
        private readonly IList<IHitPointsModifyingPart> enduranceParts;

        public VehicleAssembler()
        {
            this.arsenalParts = new List<IAttackModifyingPart>();
            this.shellParts = new List<IDefenseModifyingPart>();
            this.enduranceParts = new List<IHitPointsModifyingPart>();
        }

        public IReadOnlyCollection<IAttackModifyingPart> ArsenalParts
                                => this.arsenalParts.ToList().AsReadOnly();

        public IReadOnlyCollection<IDefenseModifyingPart> ShellParts
                                => this.shellParts.ToList().AsReadOnly();

        public IReadOnlyCollection<IHitPointsModifyingPart> EnduranceParts
                                => this.enduranceParts.ToList().AsReadOnly();

        public double TotalWeight
                         => GetMaxPartsWeight(ArsenalParts) +
                            GetMaxPartsWeight(ShellParts) +
                           GetMaxPartsWeight(EnduranceParts);
            
        public decimal TotalPrice
                         => GetPartsTotalPrice(ArsenalParts) +
                            GetPartsTotalPrice(ShellParts) +
                            GetPartsTotalPrice(EnduranceParts);

        public long TotalAttackModification
             => this.ArsenalParts.Sum(p => p.AttackModifier);

        public long TotalDefenseModification
             => this.ShellParts.Sum(p => p.DefenseModifier);

        public long TotalHitPointModification
             => this.EnduranceParts.Sum(p => p.HitPointsModifier);

        public void AddArsenalPart(IPart arsenalPart)
        {
            this.arsenalParts.Add((IAttackModifyingPart)arsenalPart);
        }

        public void AddShellPart(IPart shellPart)
        {
            this.shellParts.Add((IDefenseModifyingPart)shellPart);
        }

        public void AddEndurancePart(IPart endurancePart)
        {
            this.enduranceParts.Add((IHitPointsModifyingPart)endurancePart);
        }

        private double GetMaxPartsWeight(IReadOnlyCollection<IPart> parts)
        {
            double weight = 0;
            if (parts.Count > 0)
            {
                weight = parts.Sum(p => p.Weight);
            }

            return weight;
        }

        private decimal GetPartsTotalPrice(IReadOnlyCollection<IPart> parts)
        {
            decimal price = 0;
            if (parts.Count > 0)
            {
                price = parts.Sum(p => p.Price);
            }
            return price;
        }


    }
}